using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using BDOLangReplacement.Localizations;

namespace BDOLangReplacement
{
    public partial class Form1 : Form
    {
        private Languages lang = new Languages();
        private Config conf = new Config();
        private Localization loc = null;
        private const string tempFolder = @".\bdolr_config\";
        private const string locFileFolder = @"\ads\";
        private bool bdoLauncherFound = false;
        private bool replacementInProgress = false;
        private bool downloadLog = false;
        private bool cnFontInstalled = false;
        const string FontResWorkPlace = "BDOLangReplacement.FontResource.resources";
        private string BDOConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Black Desert\GameOption.txt";
        private string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public Form1()
        {
            if (!Directory.Exists(tempFolder))
            {
                Directory.CreateDirectory(tempFolder);
                conf.init(ConfigFilePath());
            }
            else
            {
                conf.load(ConfigFilePath());
            }
            InitializeComponent();
            switch (conf.appLang)
            {
                case "zh_cn":
                    appLangBox.SelectedIndex = 1;
                    break;
                case "en_us":
                default:
                    appLangBox.SelectedIndex = 0;
                    break;
            }
            if (!File.Exists(conf.BDOFolder + @"\BlackDesertLauncher.exe"))
            {
                if (MessageBox.Show(loc.localize(Localization.FormComponent.BDONotFound1), 
                    loc.localize(Localization.FormComponent.BDONotFoundDialogTitle), MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    dialog.Description = loc.localize(Localization.FormComponent.BDOFolderSelectionDescription);
                    while (true)
                    {
                        DialogResult result = dialog.ShowDialog();
                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath) &&
                            File.Exists(dialog.SelectedPath + @"\BlackDesertLauncher.exe"))
                        {
                            conf.BDOFolder = dialog.SelectedPath;
                            conf.write(tempFolder + "config.ini");
                            break;
                        }
                        if (MessageBox.Show(loc.localize(Localization.FormComponent.BDONotFound2), 
                            loc.localize(Localization.FormComponent.BDONotFoundDialogTitle), MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error) == DialogResult.No)
                        {
                            Environment.Exit(-1);
                        }
                    }
                }
                else
                {
                    Environment.Exit(-1);
                }
            }
            this.HandleCreated += Form1_HandleCreated;
            srcLangBox.Items.Clear();
            for (int i = 1; i < (int)Languages.Language.MAX; i++)
            {
                srcLangBox.Items.Add(lang.GetLanguageName((Languages.Language)i));
            }
            if (conf.defaultLanguage != Languages.Language.UNKNOWN && LocalLangFileExist(conf.defaultLanguage))
            {
                srcLangBox.SelectedIndex = (int)conf.defaultLanguage - 1;
            }
            fromSteam.Checked = conf.isSteam;
            ToolVersion.Text = appVersion;
        }

        private void localizeComponents()
        {
            this.Text = loc.localize(Localization.FormComponent.APPTitle);
            controlTab.TabPages[0].Text = loc.localize(Localization.FormComponent.Tab1Name);
            controlTab.TabPages[1].Text = loc.localize(Localization.FormComponent.Tab2Name);
            controlTab.TabPages[2].Text = loc.localize(Localization.FormComponent.Tab3Name);
            controlTab.TabPages[3].Text = loc.localize(Localization.FormComponent.Tab4Name);
            label1.Text = loc.localize(Localization.FormComponent.Tab1LabelText);
            refreshLanguageVersion.Text = loc.localize(Localization.FormComponent.Tab1RefreshBtnText);
            label2.Text = loc.localize(Localization.FormComponent.Tab2GameLanguage);
            label3.Text = loc.localize(Localization.FormComponent.Tab2ReplacementLanguage);
            label5.Text = loc.localize(Localization.FormComponent.Tab2IsSteam);
            fromSteam.Text = loc.localize(Localization.FormComponent.Tab2SteamCheckBox);
            startLauncher.Text = loc.localize(Localization.FormComponent.Tab2StartLaunchBtnText);
            Replace.Text = loc.localize(Localization.FormComponent.Tab2ReplaceBtnText);
            Restore.Text = loc.localize(Localization.FormComponent.Tab2RecoverBtnText);
            SetupCNFont.Text = loc.localize(Localization.FormComponent.Tab3CNFontBtnText);
            label7.Text = loc.localize(Localization.FormComponent.Tab3FontStatus);
            AboutTextBox.Text = loc.localize(Localization.FormComponent.Tab4AboutText);
            ZhcnFontSwitchButton.Text = loc.localize(Localization.FormComponent.Tab3FontTypeSimplifiedChinese);
            TwcnFontSwitchButton.Text = loc.localize(Localization.FormComponent.Tab3FontTypeTraditionalChinese);
        }

        private string ConfigFilePath()
        {
            return tempFolder + "config.ini";
        }

        private string LocalLangFilePath(Languages.Language language)
        {
            return conf.BDOFolder + locFileFolder + lang.GetLanguageFileName(language);
        }

        private bool LocalLangFileExist(Languages.Language language)
        {
            return File.Exists(LocalLangFilePath(language));
        }

        private string TempLangFilePath(Languages.Language language)
        {
            return tempFolder + lang.GetLanguageFileName(language);
        }

        private bool findAndDeleteTempLocFile(Languages.Language language)
        {
            if (!File.Exists(TempLangFilePath(language)))
                return false;
            File.Delete(TempLangFilePath(language));
            return true;
        }

        private void Form1_HandleCreated(object sender, EventArgs e)
        {
            refreshLanguageVersion_Click(null, null);
            processCheck.Enabled = true;
        }

        private void updateLangVersion()
        {
            Action safeSetZeroBar = delegate { languageVersionBar.Value = 0; };
            languageVersionBar.Invoke(safeSetZeroBar);
            lang.UpdateVersions();
            Action safeSetHalfBar = delegate { languageVersionBar.Value = 50; };
            languageVersionBar.Invoke(safeSetHalfBar);
            for (int i = 1; i < (int)Languages.Language.MAX; i++)
            {
                string langName = lang.GetLanguageName((Languages.Language)i);
                string version = lang.versions[i] >= 0 ? lang.versions[i].ToString() : 
                    loc.localize(Localization.FormComponent.Tab1LangVersionInvalid);
                Action safeAdd = delegate { langList.Items.Add(langName + " ---- " + version); };
                langList.Invoke(safeAdd);
                Action safeSetBar = delegate { languageVersionBar.Value = 50 + (50 / (int)Languages.Language.MAX) * i; };
                languageVersionBar.Invoke(safeSetBar);
            }
            Action safeSetFullBar = delegate { languageVersionBar.Value = 100; };
            languageVersionBar.Invoke(safeSetFullBar);
            Action safeEnableRefresh = delegate { refreshLanguageVersion.Enabled = true; };
            refreshLanguageVersion.Invoke(safeEnableRefresh);
            if(lang.log.Length > 0)
            {
                MessageBox.Show(loc.localize(Localization.FormComponent.Tab1RefreshLog1) + lang.log + 
                    loc.localize(Localization.FormComponent.Tab1RefreshLog2), loc.localize(Localization.FormComponent.Tab1RefreshLogTitle),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (conf.defaultReplacementLanguage != Languages.Language.UNKNOWN &&
                lang.versions[(int)conf.defaultReplacementLanguage] >= 0 &&
                MessageBox.Show(loc.localize(Localization.FormComponent.Tab1DefaultReplacement1) + lang.GetLanguageName(conf.defaultReplacementLanguage) +
                loc.localize(Localization.FormComponent.Tab1DefaultReplacement2), loc.localize(Localization.FormComponent.Tab1DefaultReplacementTitle),
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Action changeTgtName = delegate { tgtLangName.Text = lang.GetLanguageName(conf.defaultReplacementLanguage); };
                tgtLangName.Invoke(changeTgtName);
                Action changeTab = delegate { controlTab.SelectedIndex = 1; };
                controlTab.Invoke(changeTab);
            }
        }

        private void refreshLanguageVersion_Click(object sender, EventArgs e)
        {
            langList.ClearSelected();
            langList.Items.Clear();
            Thread thread = new Thread(updateLangVersion);
            refreshLanguageVersion.Enabled = false;
            thread.Start();
        }

        private void langList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (langList.Items.Count > 1 && langList.SelectedIndex >= 0)
            {
                if (lang.versions[langList.SelectedIndex + 1] < 0)
                {
                    MessageBox.Show(loc.localize(Localization.FormComponent.Tab1LangUnavailableDialogText), 
                        loc.localize(Localization.FormComponent.Tab1LangUnavailableDialogTitle), MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                }
                else
                {
                    conf.defaultReplacementLanguage = (Languages.Language) (langList.SelectedIndex + 1);
                    conf.write(ConfigFilePath());
                    tgtLangName.Text = lang.GetLanguageName(conf.defaultReplacementLanguage);
                    controlTab.SelectedIndex = 1;
                }
            }
        }

        private void srcLangBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcLangBox.SelectedIndex < 0)
                return;
            if (!LocalLangFileExist((Languages.Language)(srcLangBox.SelectedIndex + 1)))
            {
                MessageBox.Show("The selected localization file seems not exist. Please double check your language!", 
                    "Cannot find source language", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conf.defaultLanguage = Languages.Language.UNKNOWN;
                srcLangBox.SelectedIndex = -1;
            }
            conf.defaultLanguage = (Languages.Language)(srcLangBox.SelectedIndex + 1);
            conf.write(ConfigFilePath());
        }

        private void fromSteam_CheckedChanged(object sender, EventArgs e)
        {
            conf.isSteam = fromSteam.Checked;
            conf.write(ConfigFilePath());
        }

        private void processCheck_Tick(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("BlackDesertPatcher32.pae");
            if (processList.Length > 0)
            {
                processStatus.Text = loc.localize(Localization.FormComponent.BDOLauncherFound);
                bdoLauncherFound = true;
                if (!replacementInProgress)
                {
                    if (lang.versions[(int)conf.defaultReplacementLanguage] >= 0 && conf.defaultLanguage != conf.defaultReplacementLanguage)
                    {
                        Replace.Enabled = true;
                    }
                    else
                    {
                        Replace.Enabled = false;
                    }
                    if (lang.versions[(int)conf.defaultLanguage] >= 0 )
                    {
                        Restore.Enabled = true;
                    }
                    else
                    {
                        Restore.Enabled = false;
                    }
                }
                else
                {
                    Replace.Enabled = false;
                    Restore.Enabled = false;
                }
            }
            else
            {
                processStatus.Text = loc.localize(Localization.FormComponent.BDOLauncherNotFound);
                bdoLauncherFound = false;
                Replace.Enabled = false;
                Restore.Enabled = false;
            }
        }

        private void startLauncher_Click(object sender, EventArgs e)
        {
            if (conf.isSteam)
            {
                Process.Start("steam://run/582660");
            }
            else
            {
                Process launcher = new Process();
                launcher.StartInfo.FileName = "BlackDesertLauncher.exe";
                launcher.StartInfo.WorkingDirectory = conf.BDOFolder;
                try
                {
                    launcher.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to start the launcher");
                }
            }
        }

        private void replace()
        {
            Action deleteTempLocFile = delegate
            {
                replacementLog.AppendText("Removing temp localization file... ");
            };
            replacementLog.Invoke(deleteTempLocFile);
            if (findAndDeleteTempLocFile(conf.defaultReplacementLanguage))
            {
                Action removeDone = delegate
                {
                    replacementLog.AppendText("[DONE]" + Environment.NewLine);
                };
                replacementLog.Invoke(removeDone);
            }
            else
            {
                Action removeOK = delegate
                {
                    replacementLog.AppendText("[OK]" + Environment.NewLine);
                };
                replacementLog.Invoke(removeOK);
            }
            Action setBarVal10 = delegate { replaceBar.Value = 10; };
            replaceBar.Invoke(setBarVal10);
            Action downloadLocFile = delegate
            {
                replacementLog.AppendText("Download localization file from BDO official server..." + Environment.NewLine);
            };
            replacementLog.Invoke(downloadLocFile);
            lang.DownloadLanguageFile(conf.defaultReplacementLanguage, TempLangFilePath(conf.defaultReplacementLanguage),
            (object sender, DownloadProgressChangedEventArgs e) => {
                if (downloadLog)
                {
                    Action updateBar = delegate
                    {
                        replaceBar.Value = 10 + (int)(e.ProgressPercentage * 0.8f);
                    };
                    replaceBar.Invoke(updateBar);
                    Action appendDownloadLog = delegate
                    {
                        replacementLog.AppendText("Download progress [" + e.ProgressPercentage + "%]: " + e.BytesReceived +
                            " / " + e.TotalBytesToReceive + Environment.NewLine);
                    };
                    replacementLog.Invoke(appendDownloadLog);
                    downloadLog = false;
                }
            });
            Action downloadLocFileCompleted = delegate
            {
                replacementLog.AppendText("Location file download succeed. " + Environment.NewLine + "Replacing the localization file...");
            };
            replacementLog.Invoke(downloadLocFileCompleted);
            File.Replace(TempLangFilePath(conf.defaultReplacementLanguage), LocalLangFilePath(conf.defaultLanguage), LocalLangFilePath(conf.defaultLanguage) + ".bak");
            Action updateBar100 = delegate
            {
                replaceBar.Value = 100;
            };
            replaceBar.Invoke(updateBar100);
            Action completed = delegate
            {
                replacementLog.AppendText("  [DONE]" + Environment.NewLine + "Replacement Completed.");
            };
            replacementLog.Invoke(completed);
            replacementInProgress = false;
        }

        private void restore()
        {
            replacementInProgress = false;
            Action deleteTempLocFile = delegate
            {
                replacementLog.AppendText("Removing temp localization file... ");
            };
            replacementLog.Invoke(deleteTempLocFile);
            if (findAndDeleteTempLocFile(conf.defaultLanguage))
            {
                Action removeDone = delegate
                {
                    replacementLog.AppendText("[DONE]" + Environment.NewLine);
                };
                replacementLog.Invoke(removeDone);
            }
            else
            {
                Action removeOK = delegate
                {
                    replacementLog.AppendText("[OK]" + Environment.NewLine);
                };
                replacementLog.Invoke(removeOK);
            }
            Action setBarVal10 = delegate { replaceBar.Value = 10; };
            replaceBar.Invoke(setBarVal10);
            Action downloadLocFile = delegate
            {
                replacementLog.AppendText("Download localization file from BDO official server..." + Environment.NewLine);
            };
            replacementLog.Invoke(downloadLocFile);
            lang.DownloadLanguageFile(conf.defaultLanguage, TempLangFilePath(conf.defaultLanguage),
            (object sender, DownloadProgressChangedEventArgs e) => {
                if (downloadLog)
                {
                    Action updateBar = delegate
                    {
                        replaceBar.Value = 10 + (int)(e.ProgressPercentage * 0.8f);
                    };
                    replaceBar.Invoke(updateBar);
                    Action appendDownloadLog = delegate
                    {
                        replacementLog.AppendText("Download progress [" + e.ProgressPercentage + "%]: " + e.BytesReceived +
                            " / " + e.TotalBytesToReceive + Environment.NewLine);
                    };
                    replacementLog.Invoke(appendDownloadLog);
                    downloadLog = false;
                }
            });
            Action downloadLocFileCompleted = delegate
            {
                replacementLog.AppendText("Location file download succeed. " + Environment.NewLine + "Replacing the localization file...");
            };
            replacementLog.Invoke(downloadLocFileCompleted);
            File.Replace(TempLangFilePath(conf.defaultLanguage), LocalLangFilePath(conf.defaultLanguage), LocalLangFilePath(conf.defaultLanguage) + ".bak");
            Action updateBar100 = delegate
            {
                replaceBar.Value = 100;
            };
            replaceBar.Invoke(updateBar100);
            Action completed = delegate
            {
                replacementLog.AppendText("  [DONE]" + Environment.NewLine + "Restore Completed.");
            };
            replacementLog.Invoke(completed);
            replacementInProgress = false;
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            replacementLog.Text = "";
            replaceBar.Value = 0;
            replacementInProgress = true;
            Thread thread = new Thread(replace);
            thread.Start();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            replacementLog.Text = "";
            replaceBar.Value = 0;
            replacementInProgress = true;
            Thread thread = new Thread(restore);
            thread.Start();
        }

        private void downloadUpdate_Tick(object sender, EventArgs e)
        {
            downloadLog = true;
        }

        private string LocalFontFilePath()
        {
            return LocalFontDirPath() + "pearl.ttf";
        }

        private string LocalFontDirPath()
        {
            return conf.BDOFolder + @"\prestringtable\font\";
        }

        private void fontCheck_Tick(object sender, EventArgs e)
        {
            if(File.Exists(LocalFontFilePath()))
            {
                CNFont.Text = loc.localize(Localization.FormComponent.Tab3FontInstalled);
                CNFont.ForeColor = Color.Green;
                cnFontInstalled = true;
            }
            else
            {
                CNFont.Text = loc.localize(Localization.FormComponent.Tab3FontMissing);
                CNFont.ForeColor = Color.Red;
                cnFontInstalled = false;
            }
        }

        private void SetupCNFont_Click(object sender, EventArgs e)
        {
            if (cnFontInstalled)
            {
                File.Delete(LocalFontFilePath());
            }
            else
            {
                var assembly = Assembly.GetExecutingAssembly();
                
                // First create the folder
                if (!Directory.Exists(LocalFontDirPath()))
                {
                    Directory.CreateDirectory(LocalFontDirPath());
                }
                FileStream fs = null;
                try
                {
                    fs = new FileStream(LocalFontFilePath(), FileMode.Create);
                    Stream font = assembly.GetManifestResourceStream(FontResWorkPlace);
                    ResourceReader rr = new ResourceReader(font);
                    string resourceType;
                    byte[] resourceData;
                    if (TwcnFontSwitchButton.Checked)
                    {
                        rr.GetResourceData("TW_CN_Font.ttf", out resourceType, out resourceData);
                    }
                    else
                    {
                        rr.GetResourceData("ZH_CN_Font.ttf", out resourceType, out resourceData);
                    }
                    rr.Close();
                    font.Close();
                    // First 4 bytes are size
                    fs.Write(resourceData, 4, resourceData.Length - 4);
                    fs.Flush();
                    fs.Close();
                    font.Close();
                    // Write the font config
                    string fontConfig = File.ReadAllText(BDOConfigPath);
                    fontConfig = Regex.Replace(fontConfig, @"UIFontType = (\d{1})", "UIFontType = 0");
                    File.WriteAllText(BDOConfigPath + ".test", fontConfig);
                }
                catch (Exception)
                {
                    if (fs != null)
                    {
                        fs.Close();
                        File.Delete(LocalFontFilePath());
                    }

                    MessageBox.Show(loc.localize(Localization.FormComponent.FailedToInstallCNFont), 
                        loc.localize(Localization.FormComponent.FailedToInstallCNFontTitle), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void appLangBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appLangBox.SelectedIndex == 1)
            {
                loc = new LocalizationZHCN();
                conf.appLang = "zh_cn";
            }
            else
            {
                loc = new LocalizationENUS();
                conf.appLang = "en_us";
            }

            localizeComponents();
            conf.write(ConfigFilePath());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kroulis/BDOLanguageReplacementTool");
        }
    }
}
