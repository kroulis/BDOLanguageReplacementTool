using System;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BDOLangReplacement
{
    class Updater
    {
        private const string VERSION_FILE_URL = "https://raw.githubusercontent.com/kroulis/BDOLanguageReplacementTool/master/BDOLangReplacement/Properties/AssemblyInfo.cs";

        public static string getAssemblyVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static string getOnlineVersion()
        {
            WebClient webClient = new WebClient();
            try
            {
                string asmInfoCode = webClient.DownloadString(VERSION_FILE_URL);
                Regex filter = new Regex("\\[assembly: AssemblyFileVersion\\(\\\"(\\d+.\\d+.\\d+.\\d+)");
                Match match = filter.Match(asmInfoCode);
                return match.Groups[1].Value;
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        public static bool isVersionMatch(string targetVersion)
        {
            // If targetVersion is unavailable, we consider it as a match
            if (targetVersion == String.Empty)
                return true;

            return getAssemblyVersion().Equals(targetVersion);
        }
    }
}