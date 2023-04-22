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
using System.Drawing.Text;
using System.Runtime.InteropServices;

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
        private bool fontInstalled = false;
        const string FontResWorkPlace = "BDOLangReplacement.FontResource.resources";
        private string BDOConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Black Desert\GameOption.txt";
        private const string helperToolPath = tempFolder + HelperTool.HELPERTOOL_EXE_NAME;

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
            ToolVersion.Text = Updater.getAssemblyVersion();
        }

        private void localizeComponents()
        {
            this.Text = loc.localize(Localization.FormComponent.APPTitle);
            controlTab.TabPages[0].Text = loc.localize(Localization.FormComponent.Tab1Name);
            controlTab.TabPages[1].Text = loc.localize(Localization.FormComponent.Tab2Name);
            controlTab.TabPages[2].Text = loc.localize(Localization.FormComponent.Tab3Name);
            controlTab.TabPages[3].Text = loc.localize(Localization.FormComponent.Tab4Name);
            controlTab.TabPages[4].Text = loc.localize(Localization.FormComponent.Tab5Name);
            label1.Text = loc.localize(Localization.FormComponent.Tab1LabelText);
            refreshLanguageVersion.Text = loc.localize(Localization.FormComponent.Tab1RefreshBtnText);
            label2.Text = loc.localize(Localization.FormComponent.Tab2GameLanguage);
            label3.Text = loc.localize(Localization.FormComponent.Tab2ReplacementLanguage);
            label5.Text = loc.localize(Localization.FormComponent.Tab2IsSteam);
            fromSteam.Text = loc.localize(Localization.FormComponent.Tab2SteamCheckBox);
            startLauncher.Text = loc.localize(Localization.FormComponent.Tab2StartLaunchBtnText);
            Replace.Text = loc.localize(Localization.FormComponent.Tab2ReplaceBtnText);
            Restore.Text = loc.localize(Localization.FormComponent.Tab2RecoverBtnText);
            advancedText.Text = loc.localize(Localization.FormComponent.Tab2AdvancedText);
            MergeBtn.Text = loc.localize(Localization.FormComponent.Tab2MergeBtnText);
            ScriptsBtn.Text = loc.localize(Localization.FormComponent.Tab2ScriptBtnText);
            helperToolCompTab.Text = loc.localize(Localization.FormComponent.Tab3HelperToolStatusText);
            helperToolLocalText.Text = loc.localize(Localization.FormComponent.Tab3HelperToolLocalVersionText);
            helperToolOnlineText.Text = loc.localize(Localization.FormComponent.Tab3HelperToolOnlineVersionText);
            helperToolStatusLabel.Text = loc.localize(Localization.FormComponent.Tab3HelperToolVersionUnavailable);
            helperToolOnlineVerLabel.Text = loc.localize(Localization.FormComponent.Tab3HelperToolVersionUnavailable);
            InstallUpdateHelperToolBtn.Text = loc.localize(Localization.FormComponent.Tab3InstallUpdateHelperToolBtnText);
            uninstallHelperToolBtn.Text = loc.localize(Localization.FormComponent.Tab3UninstallHelperToolBtnText);
            advOpGroup.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOperationGroupText);
            advOpCodeLabel.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpCodeLabelText);
            advOpSourceLabel.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpSrcFileLabelText);
            advOpOutputLabel.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpOutFileLabelText);
            advOpAdditionalFile1Label.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpAddtionalFile1Text);
            advOpAdditionalFile2Label.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpAddtionalFile2Text);
            executeHelperBtn.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpExecuteBtnText);
            advOpSourceBrowseBtn.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpBrowseBtnText);
            advOpOutputBrowseBtn.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpBrowseBtnText);
            advOpAdditionalFile1BrowseBtn.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpBrowseBtnText);
            advOpAdditionalFile2BrowseBtn.Text = loc.localize(Localization.FormComponent.Tab3AdvancedOpBrowseBtnText);
            {
                int opCodeSelect = advOpCodeBox.SelectedIndex;
                string[] items = loc.localize(Localization.FormComponent.Tab3AdvancedOpCodeSelectBoxItems).Split('\n');
                advOpCodeBox.Items.Clear();
                foreach (string item in items)
                {
                    advOpCodeBox.Items.Add(item);
                }
                advOpCodeBox.SelectedIndex = opCodeSelect;
            }
            SetupCNFont.Text = loc.localize(Localization.FormComponent.Tab4CNFontBtnText);
            label7.Text = loc.localize(Localization.FormComponent.Tab4FontStatus);
            embFontBox.Text = loc.localize(Localization.FormComponent.Tab4EmbeddedFontText);
            ZhcnFontSwitchButton.Text = loc.localize(Localization.FormComponent.Tab4FontTypeSimplifiedChinese);
            TwcnFontSwitchButton.Text = loc.localize(Localization.FormComponent.Tab4FontTypeTraditionalChinese);
            customRadioBtn.Text = loc.localize(Localization.FormComponent.Tab4CustomFontText);
            customFontBox.Text = loc.localize(Localization.FormComponent.Tab4CustomFontBoxText);
            fontBrowse.Text = loc.localize(Localization.FormComponent.Tab4BrowseFontBtnText);
            fontFileBrowse.Text = loc.localize(Localization.FormComponent.Tab4BrowseFontFileBtnText);
            AboutTextBox.Text = loc.localize(Localization.FormComponent.Tab5AboutText);
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
            string onlineVersion = Updater.getOnlineVersion();
            if (!Updater.isVersionMatch(onlineVersion))
            {
                if (MessageBox.Show(String.Format(loc.localize(Localization.FormComponent.NewVersionAvailable), Updater.getAssemblyVersion(), onlineVersion),
                    "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    linkLabel1_LinkClicked(null, null);
                }
            }
            refreshLanguageVersion_Click(null, null);
            processCheck.Enabled = true;
            if (File.Exists(helperToolPath))
            {
                Thread th = new Thread(new ThreadStart(updateHelperToolVersion));
                th.Start();
            }
            else
            {
                InstallUpdateHelperToolBtn.Enabled = true;
            }
            string helperToolOnlineVersion = HelperTool.getOnlineVersion();
            if (!helperToolOnlineVersion.Equals(""))
            {
                helperToolOnlineVerLabel.Text = helperToolOnlineVersion;
                helperToolOnlineVerLabel.ForeColor = Color.Green;
            }
        }

        private void updateHelperToolVersion()
        {
            string version = HelperTool.getLocalVersion(helperToolPath);
            Action setUninstallBtnAvailable = delegate { uninstallHelperToolBtn.Enabled = true; };
            Action disableUninstallBtn = delegate { uninstallHelperToolBtn.Enabled = false; };
            if (!version.Equals(""))
            {
                Action setHelperToolVersion = delegate { 
                    helperToolStatusLabel.Text = version;
                    helperToolStatusLabel.ForeColor = Color.Green;
                };

                helperToolStatusLabel.Invoke(setHelperToolVersion);
                uninstallHelperToolBtn.Invoke(setUninstallBtnAvailable);
            }
            else
            {
                Action setHelperToolVersionNotFound = delegate {
                    helperToolStatusLabel.Text = loc.localize(Localization.FormComponent.Tab4FontMissing);
                    helperToolStatusLabel.ForeColor = Color.Red;
                };
                uninstallHelperToolBtn.Invoke(disableUninstallBtn);
            }
            Action setInstallBtnAvailable = delegate { InstallUpdateHelperToolBtn.Enabled = true; };
            InstallUpdateHelperToolBtn.Invoke(setInstallBtnAvailable);
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
                    if (Replace.Enabled && Restore.Enabled && helperToolStatusLabel.ForeColor == Color.Green)
                    {
                        MergeBtn.Enabled = true;
                    }
                    else
                    {
                        MergeBtn.Enabled = false;
                    }
                }
                else
                {
                    Replace.Enabled = false;
                    Restore.Enabled = false;
                    MergeBtn.Enabled = false;
                }
            }
            else
            {
                processStatus.Text = loc.localize(Localization.FormComponent.BDOLauncherNotFound);
                bdoLauncherFound = false;
                Replace.Enabled = false;
                Restore.Enabled = false;
                MergeBtn.Enabled = false;
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

        private void merge()
        {
            Action deleteTempLocFile = delegate
            {
                replacementLog.AppendText("Removing temp localization file... ");
            };
            replacementLog.Invoke(deleteTempLocFile);
            if (findAndDeleteTempLocFile(conf.defaultReplacementLanguage) && findAndDeleteTempLocFile(conf.defaultLanguage))
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
                replacementLog.AppendText("Download replacement localization file from BDO official server..." + Environment.NewLine);
            };
            replacementLog.Invoke(downloadLocFile);
            lang.DownloadLanguageFile(conf.defaultReplacementLanguage, TempLangFilePath(conf.defaultReplacementLanguage),
            (object sender, DownloadProgressChangedEventArgs e) => {
                if (downloadLog)
                {
                    Action updateBar = delegate
                    {
                        replaceBar.Value = 10 + (int)(e.ProgressPercentage * 0.2f);
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
                replacementLog.AppendText("Replacement Location file download succeed. " + Environment.NewLine);
            };
            replacementLog.Invoke(downloadLocFileCompleted);
            Action downloadLocFile2 = delegate
            {
                replacementLog.AppendText("Download original localization file from BDO official server..." + Environment.NewLine);
            };
            replacementLog.Invoke(downloadLocFile2);
            lang.DownloadLanguageFile(conf.defaultLanguage, TempLangFilePath(conf.defaultLanguage),
            (object sender, DownloadProgressChangedEventArgs e) => {
                if (downloadLog)
                {
                    Action updateBar = delegate
                    {
                        replaceBar.Value = 30 + (int)(e.ProgressPercentage * 0.2f);
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
            Action downloadLocFileCompleted2 = delegate
            {
                replacementLog.AppendText("Original location file download succeed. " + Environment.NewLine);
            };
            replacementLog.Invoke(downloadLocFileCompleted2);

            // Start invoking the helper tool
            HelperToolArgument argD1 = new HelperToolArgument(Path.GetFullPath(TempLangFilePath(conf.defaultReplacementLanguage)), 
                Path.GetFullPath(tempFolder + "loc_rep.txt"), (int)HelperToolArgument.HelperToolOpCode.Decrypt);
            Action decryptReplacement = delegate
            {
                replacementLog.AppendText("Decrypting replacement localization file");
            };
            replacementLog.Invoke(decryptReplacement);
            HelperTool.execute(tempFolder, argD1);
            Action operationCompleted = delegate
            {
                replacementLog.AppendText(" [DONE]" + Environment.NewLine);
            };
            replacementLog.Invoke(operationCompleted);
            Action updateBar60 = delegate
            {
                replaceBar.Value = 60;
            };
            replaceBar.Invoke(updateBar60);
            Action decryptOriginal = delegate
            {
                replacementLog.AppendText("Decrypting original localization file");
            };
            replacementLog.Invoke(decryptOriginal);
            HelperToolArgument argD2 = new HelperToolArgument(Path.GetFullPath(TempLangFilePath(conf.defaultLanguage)), 
                Path.GetFullPath(tempFolder + "loc_base.txt"), (int)HelperToolArgument.HelperToolOpCode.Decrypt);
            HelperTool.execute(tempFolder, argD2);
            replacementLog.Invoke(operationCompleted);
            Action updateBar70 = delegate
            {
                replaceBar.Value = 70;
            };
            replaceBar.Invoke(updateBar70);
            Action MergeStart = delegate
            {
                replacementLog.AppendText("Merging Localization files (This may take a long time)");
            };
            replacementLog.Invoke(MergeStart);
            HelperToolArgument argM = new HelperToolArgument(Path.GetFullPath(tempFolder + "loc_base.txt"),
                Path.GetFullPath(tempFolder + "loc_merge.txt"), (int)HelperToolArgument.HelperToolOpCode.Merge);
            argM.addAdditionalFile(Path.GetFullPath(tempFolder + "loc_rep.txt"));
            HelperTool.execute(tempFolder, argM);
            replacementLog.Invoke(operationCompleted);
            Action updateBar90 = delegate
            {
                replaceBar.Value = 90;
            };
            replaceBar.Invoke(updateBar90);
            Action EncryptStart = delegate
            {
                replacementLog.AppendText("Encrypting merged localization file");
            };
            replacementLog.Invoke(EncryptStart);
            HelperToolArgument argE = new HelperToolArgument(Path.GetFullPath(tempFolder + "loc_merge.txt"),
                Path.GetFullPath(tempFolder + "languagedata_merge.loc"), (int)HelperToolArgument.HelperToolOpCode.Encrtpy);
            HelperTool.execute(tempFolder, argE);
            Action updateBar95 = delegate
            {
                replaceBar.Value = 95;
            };
            replacementLog.Invoke(operationCompleted);
            replaceBar.Invoke(updateBar95);

            Action StartReplacing = delegate
            {
                replacementLog.AppendText("Replacing localization file...");
            };
            replacementLog.Invoke(StartReplacing);
            File.Replace(tempFolder + "languagedata_merge.loc", LocalLangFilePath(conf.defaultLanguage), LocalLangFilePath(conf.defaultLanguage) + ".bak");
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

            if (File.Exists(tempFolder + "loc_base.txt"))
            {
                File.Delete(tempFolder + "loc_base.txt");
            }
            if (File.Exists(tempFolder + "loc_rep.txt"))
            {
                File.Delete(tempFolder + "loc_rep.txt");
            }
            if (File.Exists(tempFolder + "loc_merge.txt"))
            {
                File.Delete(tempFolder + "loc_merge.txt");
            }
            if (File.Exists(tempFolder + "languagedata_merge.loc"))
            {
                File.Delete(tempFolder + "languagedata_merge.loc");
            }    
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
                CNFont.Text = loc.localize(Localization.FormComponent.Tab4FontInstalled);
                CNFont.ForeColor = Color.Green;
                fontInstalled = true;
            }
            else
            {
                CNFont.Text = loc.localize(Localization.FormComponent.Tab4FontMissing);
                CNFont.ForeColor = Color.Red;
                fontInstalled = false;
            }
        }

        private void SetupCNFont_Click(object sender, EventArgs e)
        {
            if (fontInstalled)
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
                    else if(ZhcnFontSwitchButton.Checked)
                    {
                        rr.GetResourceData("ZH_CN_Font.ttf", out resourceType, out resourceData);
                    }
                    else // Custom font
                    {
                        font.Close();
                        fs.Close();
                        if (File.Exists(fontInput.Text) && fontInput.Text.EndsWith(".ttf"))
                        {
                            if (File.Exists(LocalFontFilePath()))
                                File.Delete(LocalFontFilePath());
                            File.Copy(fontInput.Text, LocalFontFilePath());
                        }
                        return;
                    }
                    rr.Close();
                    font.Close();
                    // First 4 bytes are size
                    fs.Write(resourceData, 4, resourceData.Length - 4);
                    fs.Flush();
                    fs.Close();
                    font.Close();
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
                finally
                {
                    // Write the font config
                    string fontConfig = File.ReadAllText(BDOConfigPath);
                    fontConfig = Regex.Replace(fontConfig, @"UIFontType = (\d{1})", "UIFontType = 0");
                    File.WriteAllText(BDOConfigPath, fontConfig);
                }
            }
        }

        private void appLangBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool rerender = false;
            if (appLangBox.SelectedIndex != -1 &&
                ((conf.appLang.Equals("zh_cn") && appLangBox.SelectedIndex != 1) ||
                (conf.appLang.Equals("en_us") && appLangBox.SelectedIndex != 0)))
            {
                rerender = true;
            }

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

            if (rerender)
            {
                ReRenderHelperToolVer();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kroulis/BDOLanguageReplacementTool");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReRenderHelperToolVer()
        {
            string helperToolOnlineVersion = HelperTool.getOnlineVersion();
            if (!helperToolOnlineVersion.Equals(""))
            {
                helperToolOnlineVerLabel.Text = helperToolOnlineVersion;
                helperToolOnlineVerLabel.ForeColor = Color.Green;
            }
            else
            {
                helperToolOnlineVerLabel.Text = loc.localize(Localization.FormComponent.Tab3HelperToolVersionUnavailable);
                helperToolOnlineVerLabel.ForeColor = Color.Red;
            }
            updateHelperToolVersion();
        }

        private void InstallUpdateHelperToolBtn_Click(object sender, EventArgs e)
        {
            if (!helperToolStatusLabel.Text.Equals(helperToolOnlineVerLabel.Text) && 
                helperToolOnlineVerLabel.ForeColor == Color.Green)
            {
                InstallUpdateHelperToolBtn.Enabled = false;
                if (HelperTool.installHelperTool(tempFolder))
                {
                    Thread th = new Thread(new ThreadStart(updateHelperToolVersion));
                    th.Start();
                }
            }
            else
            {
                if (File.Exists(helperToolPath))
                {
                    Thread th = new Thread(new ThreadStart(updateHelperToolVersion));
                    th.Start();
                }
                string helperToolOnlineVersion = HelperTool.getOnlineVersion();
                if (!helperToolOnlineVersion.Equals(""))
                {
                    helperToolOnlineVerLabel.Text = helperToolOnlineVersion;
                    helperToolOnlineVerLabel.ForeColor = Color.Green;
                }
                else
                {
                    helperToolOnlineVerLabel.Text = loc.localize(Localization.FormComponent.Tab3HelperToolVersionUnavailable);
                    helperToolOnlineVerLabel.ForeColor = Color.Red;
                }
            }
        }

        private void uninstallHelperToolBtn_Click(object sender, EventArgs e)
        {
            if (HelperTool.uninstallHelperTool(tempFolder))
            {
                helperToolStatusLabel.Text = loc.localize(Localization.FormComponent.Tab3HelperToolVersionUnavailable);
                helperToolStatusLabel.ForeColor = Color.Red;
                InstallUpdateHelperToolBtn.Enabled = true;
            }
        }

        private void advOpSourceBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Plaintext files (*.txt)|*.txt|Localization files (*.loc)|*.loc|All files (*.*)|*.*",
                Title = "Advance Operation Source File",
                CheckFileExists = true,
                CheckPathExists = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                advOpSourceInput.Text = openFileDialog.FileName;
            }
        }

        private void advOpOutputBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Plaintext files (*.txt)|*.txt|Localization files (*.loc)|*.loc|All files (*.*)|*.*",
                Title = "Advance Operation Output File",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                advOpOutputInput.Text = openFileDialog.FileName;
            }
        }

        private void exectuteHelperTool(HelperToolArgument arg)
        {
            HelperTool.executeAndUpdateProgressBarAndTreeView(tempFolder, arg, advOpProgressBar, advOpExecTreeView);
            Action enableExecBtnAction = delegate { executeHelperBtn.Enabled = true;
                advOpSourceBrowseBtn.Enabled = true;
                advOpOutputBrowseBtn.Enabled = true;
                advOpAdditionalFile1BrowseBtn.Enabled = true;
                advOpAdditionalFile2BrowseBtn.Enabled = true;
                advOpCodeBox.Enabled = true;
                advOpSourceInput.ReadOnly = false;
                advOpOutputInput.ReadOnly = false;
                advOpAdditionalFile1Input.ReadOnly = false;
                advOpAdditionalFile2Input.ReadOnly = false;
            };
            executeHelperBtn.Invoke(enableExecBtnAction);
        }

        private void executeHelperBtn_Click(object sender, EventArgs e)
        {
            if (helperToolStatusLabel.ForeColor != Color.Green)
            {
                MessageBox.Show(loc.localize(Localization.FormComponent.Tab3InstallHelperToolFirstText));
                return;
            }

            if (advOpCodeBox.SelectedIndex == -1 ||
                !File.Exists(advOpSourceInput.Text) ||
                advOpOutputInput.Text.Equals(string.Empty) ||
                (!advOpAdditionalFile1Input.Text.Equals(string.Empty) &&
                 !File.Exists(advOpAdditionalFile1Input.Text)) ||
                (!advOpAdditionalFile2Input.Text.Equals(string.Empty) &&
                 !File.Exists(advOpAdditionalFile2Input.Text)))
            {
                return;
            }

            HelperToolArgument arg = new HelperToolArgument(advOpSourceInput.Text, advOpOutputInput.Text, advOpCodeBox.SelectedIndex);
            if (!advOpAdditionalFile1Input.Text.Equals(string.Empty))
            {
                arg.addAdditionalFile(advOpAdditionalFile1Input.Text);
            }
            if (!advOpAdditionalFile2Input.Text.Equals(string.Empty))
            {
                arg.addAdditionalFile(advOpAdditionalFile2Input.Text);
            }

            executeHelperBtn.Enabled = false;
            advOpSourceBrowseBtn.Enabled = false;
            advOpOutputBrowseBtn.Enabled = false;
            advOpAdditionalFile1BrowseBtn.Enabled = false;
            advOpAdditionalFile2BrowseBtn.Enabled = false;
            advOpCodeBox.Enabled = false;
            advOpSourceInput.ReadOnly = true;
            advOpOutputInput.ReadOnly = true;
            advOpAdditionalFile1Input.ReadOnly = true;
            advOpAdditionalFile2Input.ReadOnly = true;

            Thread th = new Thread(() => exectuteHelperTool(arg));
            th.Start();
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            replacementLog.Text = "";
            replaceBar.Value = 0;
            replacementInProgress = true;
            Thread thread = new Thread(merge);
            thread.Start();
        }

        private void advOpAdditionalFile2BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Plaintext files (*.txt)|*.txt|Localization files (*.loc)|*.loc|All files (*.*)|*.*",
                Title = "Advance Operation Additional File",
                CheckPathExists = true,
                CheckFileExists = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                advOpAdditionalFile2Input.Text = openFileDialog.FileName;
            }
        }

        private void advOpAdditionalFile1BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Plaintext files (*.txt)|*.txt|Localization files (*.loc)|*.loc|All files (*.*)|*.*",
                Title = "Advance Operation Additional File",
                CheckPathExists = true,
                CheckFileExists = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                advOpAdditionalFile1Input.Text = openFileDialog.FileName;
            }
        }

        private List<string> GetFilesForFont(string fontName)
        {
            var fontNameToFiles = new Dictionary<string, List<string>>();

            foreach (var fontFile in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Fonts)))
            {
                var fc = new PrivateFontCollection();

                if (File.Exists(fontFile))
                    fc.AddFontFile(fontFile);

                if ((!fc.Families.Any()))
                    continue;

                var name = fc.Families[0].Name;

                // If you care about bold, italic, etc, you can filter here.
                if (!fontNameToFiles.TryGetValue(name, out var files))
                {
                    files = new List<string>();
                    fontNameToFiles[name] = files;
                }

                files.Add(fontFile);
            }

            if (!fontNameToFiles.TryGetValue(fontName, out var result))
                return null;

            return result;
        }

        private void fontBrowse_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> ft = GetFilesForFont(fontDialog.Font.Name);
                if (ft != null && ft.Count() > 0 && ft[0].EndsWith(".ttf"))
                {
                    fontInput.Text = ft[0];
                    exampleBox.Font = fontDialog.Font;
                }
                else
                {
                    fontInput.Text = "";
                    MessageBox.Show(loc.localize(Localization.FormComponent.Tab4CannotReadFontFilePathText));
                }
            }
        }

        private void fontFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "TTF Font File (*.ttf)|*.ttf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "ttf"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PrivateFontCollection collection = new PrivateFontCollection();
                byte[] fontBin = File.ReadAllBytes(ofd.FileName);
                var handle = GCHandle.Alloc(fontBin, GCHandleType.Pinned);
                IntPtr pointer = handle.AddrOfPinnedObject();
                try
                {
                    collection.AddMemoryFont(pointer, fontBin.Length);
                }
                finally
                {
                    handle.Free();
                }
                FontFamily fontFamily = collection.Families.LastOrDefault();
                Font customFont = new Font(fontFamily, 16);
                exampleBox.Font = customFont;
                fontInput.Text = ofd.FileName;
            }
        }

        private void ScriptsBtn_Click(object sender, EventArgs e)
        {
            InsiderProgram ip = new InsiderProgram(loc);
            ip.ShowDialog(this);
        }
    }
}
