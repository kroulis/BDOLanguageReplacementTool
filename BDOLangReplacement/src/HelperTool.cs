using BDOLangReplacement.Internals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDOLangReplacement
{
    public class HelperTool
    {
        private const string VERSION_FILE_URL = "https://raw.githubusercontent.com/kroulis/BDOLangReplacementToolHelper/master/BDOLangReplacementToolHelper/header/version.h";
        private const string LATEST_RELEASE_URL = "https://raw.githubusercontent.com/kroulis/BDOLangReplacementToolHelper/master/LatestRelease";
        public const string HELPERTOOL_EXE_NAME = "BDOLangReplacementToolHelper.exe";
        public static string getOnlineVersion()
        {
            WebClient webClient = new WebClient();
            try
            {
                string asmInfoCode = webClient.DownloadString(VERSION_FILE_URL);
                Regex filter = new Regex("BDOLANGREPLTOOLHELPERVER\\s\\\"(\\d+.\\d+.\\d+.\\d+)\\\"");
                Match match = filter.Match(asmInfoCode);
                return match.Groups[1].Value;
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        public static string getLocalVersion(string filePath)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    Arguments = new HelperToolArgument(null, null, -1).generateCmdString(),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                Regex filter = new Regex("Version:\\s(\\d+.\\d+.\\d+.\\d+)");
                Match match = filter.Match(line);
                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
            }

            return "";
        }

        public static bool installHelperTool(string directoryPath)
        {
            WebClient webClient = new WebClient();
            try
            {
                string releaseUrl = webClient.DownloadString(LATEST_RELEASE_URL);
                string helperToolZipPath = directoryPath + "helperTool.zip";
                string helperToolLstPath = directoryPath + "helperTool.lst";
                if (File.Exists(helperToolZipPath))
                {
                    File.Delete(helperToolZipPath);
                }
                webClient.DownloadFile(releaseUrl, helperToolZipPath);
                using (var unzip = new Unzip(helperToolZipPath))
                {
                    if (File.Exists(helperToolLstPath))
                    {
                        File.Delete(helperToolLstPath);
                    }
                    StreamWriter lstWriter = new StreamWriter(helperToolLstPath);
                    foreach (var fileName in unzip.FileNames)
                    {
                        lstWriter.WriteLine(fileName);
                    }
                    lstWriter.Flush();
                    lstWriter.Close();
                    unzip.ExtractToDirectory(directoryPath);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool uninstallHelperTool(string directoryPath)
        {
            string helperToolLstPath = directoryPath + "helperTool.lst";
            string helperToolExePath = directoryPath + HELPERTOOL_EXE_NAME;

            if (File.Exists(helperToolLstPath))
            {
                string[] filenames = File.ReadAllLines(helperToolLstPath);
                foreach (string filename in filenames)
                {
                    if (File.Exists(directoryPath + filename))
                    {
                        try
                        {
                            File.Delete(directoryPath + filename);
                        }
                        catch (Exception) { }
                    }
                }
                return !File.Exists(helperToolExePath);
            }
            else if (File.Exists(helperToolExePath))
            {
                try
                {
                    File.Delete(helperToolExePath);
                }
                catch (Exception) { }
                return !File.Exists(helperToolExePath);
            }

            return false;
        }

        public static void executeAndUpdateProgressBarAndTreeView(string directoryPath, HelperToolArgument arg, ProgressBar progressBar, TreeView treeView)
        {
            Action clearTreeViewAction = delegate { treeView.Nodes.Clear(); };
            Action resetProgressBarAction = delegate { progressBar.Value = 0; progressBar.ForeColor = System.Drawing.Color.Blue; };
            treeView.Invoke(clearTreeViewAction);
            progressBar.Invoke(resetProgressBarAction);

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = directoryPath,
                    FileName = directoryPath + HELPERTOOL_EXE_NAME,
                    Arguments = arg.generateCmdString(),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            TreeNode currentNode = null;
            TreeNode parentNode = null;
            Stopwatch sw = Stopwatch.StartNew();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                if (line.Equals(string.Empty) || line.Equals("\n"))
                    continue;
                Regex filter = new Regex("\\((\\d+)/(\\d+)\\)");
                Match match = filter.Match(line);
                if (match.Success)
                {
                    if (sw.Elapsed.TotalMilliseconds < 500)
                    {
                        continue;
                    }
                    sw.Restart();
                    double progress = double.Parse(match.Groups[1].Value) * 100.0 / double.Parse(match.Groups[2].Value);
                    if (currentNode == null)
                    {
                        currentNode = new TreeNode();
                        currentNode.Text = "[" + progress.ToString("0.##") + "%/";
                        Action addNodeAction = delegate { 
                            if (parentNode != null)
                                parentNode.Nodes.Add(currentNode); 
                            else
                            {
                                parentNode = new TreeNode();
                                parentNode.Text = "Working...";
                                parentNode.ForeColor = System.Drawing.Color.Blue;
                                treeView.Nodes.Add(parentNode);
                                parentNode.Nodes.Add(currentNode);
                            }
                        };
                        treeView.Invoke(addNodeAction);
                    }
                    else
                    {
                        Action changeTextAction = delegate
                        {
                            currentNode.Text = "[" + progress.ToString("0.##") + "%]";
                        };
                        treeView.Invoke(changeTextAction);
                    }                        
                }
                else
                {
                    if (parentNode != null)
                    {
                        Action changeParentNodeAction = delegate
                        {
                            parentNode.ForeColor = System.Drawing.Color.Green;
                            parentNode.Nodes.Clear();
                        };
                        treeView.Invoke(changeParentNodeAction);
                    }
                    parentNode = new TreeNode();
                    parentNode.Text = line;
                    parentNode.ForeColor = System.Drawing.Color.Blue;
                    currentNode = null;
                    Action addToTreeView = delegate { treeView.Nodes.Add(parentNode); };
                    treeView.Invoke(addToTreeView);
                }
            }

            if (proc.ExitCode != 0)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = "Operation failed with error code " + proc.ExitCode.ToString();
                treeNode.ForeColor = System.Drawing.Color.Red;
                Action addToTreeView = delegate { treeView.Nodes.Add(treeNode); };
                treeView.Invoke(addToTreeView);
                Action progressBarErrorAction = delegate
                {
                    progressBar.Value = 100;
                    progressBar.ForeColor = System.Drawing.Color.Red;
                };
                progressBar.Invoke(progressBarErrorAction);
            }
            else
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = "Operation completed";
                treeNode.ForeColor = System.Drawing.Color.Green;
                Action addToTreeView = delegate { treeView.Nodes.Add(treeNode); };
                treeView.Invoke(addToTreeView);
                Action progressBarCompleteAction = delegate
                {
                    progressBar.Value = 100;
                    progressBar.ForeColor = System.Drawing.Color.Green;
                };
                progressBar.Invoke(progressBarCompleteAction);
            }
            sw.Stop();
        }

        public static int execute(string directoryPath, HelperToolArgument arg)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = directoryPath,
                    FileName = directoryPath + HELPERTOOL_EXE_NAME,
                    Arguments = arg.generateCmdString(),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                //Do nothing
            }

            return proc.ExitCode;
        }
    }


    public class HelperToolArgument
    {
        string srcFile;
        string outputFile;
        public enum HelperToolOpCode
        {
            None = -1,
            Decrypt = 0,
            Encrtpy = 1,
            Diff = 2,
            Merge = 3,
            Translate_ZHCN = 4,
            Licences = 5
        };
        HelperToolOpCode opcode;
        List<string> additionalFiles;

        public HelperToolArgument(string srcFileName, string outputFileName, int opCode)
        {
            srcFile = srcFileName;
            outputFile = outputFileName;
            opcode = (HelperToolOpCode)opCode;
            additionalFiles = new List<string>();
        }

        private string opCodeToArgument(HelperToolOpCode opCode)
        {
            switch(opCode)
            {
                case HelperToolOpCode.None:
                    return "";
                case HelperToolOpCode.Decrypt:
                    return "-d";
                case HelperToolOpCode.Encrtpy:
                    return "-e";
                case HelperToolOpCode.Diff:
                    return "-f";
                case HelperToolOpCode.Merge:
                    return "-m";
                case HelperToolOpCode.Translate_ZHCN:
                    return "-zh_cn";
                case HelperToolOpCode.Licences:
                    return "-lic";
            }
            return "";
        }

        public void addAdditionalFile(string additionalFile)
        {
            additionalFiles.Add(additionalFile);
        }

        public string generateCmdString()
        {
            if (opcode == HelperToolOpCode.None)
                return "";
            if (opcode == HelperToolOpCode.Licences)
                return opCodeToArgument(opcode);
            string baseArg = opCodeToArgument(opcode) + " \"" + srcFile + "\" \"" + outputFile + "\"";
            foreach (string addtionalFile in additionalFiles)
            {
                baseArg += " \"" + addtionalFile + "\"";
            }
            return baseArg;
        }
    }
}
