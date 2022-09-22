using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace BDOLangReplacement
{
    public class Languages
    {
        private const string NAEU_LANG_VERSION_URL = "http://naeu-o-dn.playblackdesert.com/UploadData/ads_files";
        private const string TW_LANG_VERSION_URL = "https://dn.blackdesert.com.tw/UploadData/ads_files";
        private const string SEA_LANG_VERSION_URL = "https://dn.sea.playblackdesert.com/UploadData/ads_files";
        private const string JP_LANG_VERSION_URL = "https://jpo-o-dn.playblackdesert.com/UploadData/ads_files";
        private const string TH_LANG_VERSION_URL = "https://dn.th.playblackdesert.com/UploadData/ads_files";
        private const string RU_LANG_VERSION_URL = "https://nez-o-dn.playblackdesert.com/UploadData/ads_files";
        private const string TR_LANG_VERSION_URL = "https://dn.tr.playblackdesert.com/UploadData/ads_files";
        private const string SA_LANG_VERSION_URL = "https://sa-o-dn.playblackdesert.com/UploadData/ads_files";
        private const string GL_LANG_VERSION_URL = "http://dn.global-lab.playblackdesert.com/UploadData/ads_files";

        // Delimiters
        private const string AES_VERSION_DELIMITER = " \t";

        public enum Language
        {
            UNKNOWN = 0,
            NAEU_EN = 1,
            NAEU_DE = 2,
            NAEU_FR = 3,
            NAEU_SP = 4,
            TW_TW_CN = 5,
            SEA_ID = 6,
            SEA_EN = 7,
            SEA_ID_EN = 8,
            JP_JP = 9,
            TH_TH = 10,
            TH_EN = 11,
            RU_RU = 12,
            TR_TR = 13,
            TR_EN = 14,
            TR_TR_EN = 15,
            SA_PT = 16,
            SA_ES = 17,
            GL_EN = 18,
            GL_TW = 19,
            GL_JP = 20,
            MAX = 21
        }

        public int[] versions;
        public string log;

        public Languages()
        {
            versions = new int[((int)Language.MAX)];
            for(int i = 0; i < versions.Length; i++)
            {
                versions[i] = -1;
            }
            log = "";
        }

        public string GetLanguageName(Language lang)
        {
            switch (lang)
            {
                case Language.NAEU_EN:
                    return "[NA] English";
                case Language.NAEU_DE:
                    return "[EU] German (Deutsch)";
                case Language.NAEU_FR:
                    return "[EU] French (Français)";
                case Language.NAEU_SP:
                    return "[NA] Spanish (Español)";
                case Language.TW_TW_CN:
                    return "[TW] Traditional Chinese (繁體中文)";
                case Language.SEA_ID:
                    return "[SEA] Indonesian (Indonesia)";
                case Language.SEA_EN:
                    return "[SEA] English";
                case Language.SEA_ID_EN:
                    return "[SEA] Indonesian + English";
                case Language.JP_JP:
                    return "[JP] Japanese (日本語)";
                case Language.TH_TH:
                    return "[TH] Thai (ไทย)";
                case Language.TH_EN:
                    return "[TH] English";
                case Language.RU_RU:
                    return "[RU] Russian (русский язык)";
                case Language.TR_TR:
                    return "[TR] Turkish (Türkçe)";
                case Language.TR_EN:
                    return "[TR] English";
                case Language.TR_TR_EN:
                    return "[TR] Turkish + English";
                case Language.SA_PT:
                    return "[SA] Portuguese (Português)";
                case Language.SA_ES:
                    return "[SA] Spanish (Español)";
                case Language.GL_EN:
                    return "[Global Lab] English";
                case Language.GL_TW:
                    return "[Global Lab] Traditional Chinese (繁體中文)";
                case Language.GL_JP:
                    return "[Global Lab] Japanese (日本語)";
                case Language.UNKNOWN:
                case Language.MAX:
                default:
                    return "Unavailable";
            }
        }

        public string GetLanguageFileName(Language lang)
        {
            switch (lang)
            {
                case Language.NAEU_EN:
                case Language.SEA_EN:
                case Language.TH_EN:
                case Language.TR_EN:
                case Language.GL_EN:
                    return "languagedata_en.loc";
                case Language.NAEU_DE:
                    return "languagedata_de.loc";
                case Language.NAEU_FR:
                    return "languagedata_fr.loc";
                case Language.NAEU_SP:
                    return "languagedata_sp.loc";
                case Language.TW_TW_CN:
                case Language.GL_TW:
                    return "languagedata_tw.loc";
                case Language.JP_JP:
                case Language.GL_JP:
                    return "languagedata_jp.loc";
                case Language.TH_TH:
                    return "languagedata_th.loc";
                case Language.RU_RU:
                    return "languagedata_ru.loc";
                case Language.TR_TR:
                    return "languagedata_tr.loc";
                case Language.TR_TR_EN:
                    return "languagedata_tr_en.loc";
                case Language.SA_PT:
                    return "languagedata_pt.loc";
                case Language.SA_ES:
                    return "languagedata_es.loc";
                case Language.SEA_ID:
                    return "languagedata_id.loc";
                case Language.SEA_ID_EN:
                    return "languagedata_id_en.loc";
                default:
                    return "languagedata_unknown.loc";
            }
        }

        private string GetLanguageFileURL(Language lang)
        {
            string baseUrl = "";
            switch (lang)
            {
                case Language.NAEU_EN:
                case Language.NAEU_DE:
                case Language.NAEU_FR:
                case Language.NAEU_SP:
                    baseUrl = "http://naeu-o-dn.playblackdesert.com/UploadData/ads/";
                    break;
                case Language.TW_TW_CN:
                    baseUrl = "https://dn.blackdesert.com.tw/UploadData/ads/";
                    break;
                case Language.SEA_ID:
                case Language.SEA_EN:
                case Language.SEA_ID_EN:
                    baseUrl = "http://dn.sea.playblackdesert.com/UploadData/ads/";
                    break;
                case Language.JP_JP:
                    baseUrl = "https://jpo-o-dn.playblackdesert.com/UploadData/ads/";
                    break;
                case Language.TH_TH:
                case Language.TH_EN:
                    baseUrl = "https://dn.th.playblackdesert.com/UploadData/ads/";
                    break;
                case Language.RU_RU:
                    baseUrl = "https://nez-o-dn.playblackdesert.com/UploadData/ads";
                    break;
                case Language.TR_TR:
                case Language.TR_EN:
                case Language.TR_TR_EN:
                    baseUrl = "https://dn.tr.playblackdesert.com/UploadData/ads/";
                    break;
                case Language.SA_PT:
                    return "https://sa-o-dn.playblackdesert.com/UploadData/ads/languagedata_pt.loc";
                case Language.SA_ES:
                    return "https://sa-o-dn.playblackdesert.com/UploadData/ads/languagedata_es.loc";
                case Language.GL_EN:
                case Language.GL_TW:
                case Language.GL_JP:
                    baseUrl = "https://dn.global-lab.playblackdesert.com/UploadData/ads/";
                    break;
                default:
                    throw new WebException("Download Failed: Invalid BDO Server");
            }

            return baseUrl + GetLanguageFileName(lang).Substring(0, GetLanguageFileName(lang).IndexOf('.')) + @"/" +
                versions[(int)lang] + "/" + GetLanguageFileName(lang);
        }

        public bool DownloadLanguageFile(Language lang, string filePath, DownloadProgressChangedEventHandler hdl = null)
        {
            log = "";
            bool downloadFinished = false;
            WebClient client = new WebClient();
            if (hdl != null)
            {
                client.DownloadProgressChanged += hdl;
            }
            
            client.DownloadFileCompleted += (object sender, System.ComponentModel.AsyncCompletedEventArgs e) => { downloadFinished = true; };
            try
            {
                client.DownloadFileAsync(new Uri(GetLanguageFileURL(lang)), filePath);

                while(!downloadFinished)
                {
                    Thread.Sleep(100);
                }
            }
            catch(WebException e)
            {
                log += e.Message;
                return false;
            }
            return true;
        }

        public bool UpdateVersions()
        {
            WebClient webClient = new WebClient();

            // Update NA/EU server languages
            string versionsStr = webClient.DownloadString(NAEU_LANG_VERSION_URL);
            string[] versionLine = versionsStr.Split('\n');
            foreach(string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.NAEU_EN)))
                {
                    lang_type = ((int)Language.NAEU_EN);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.NAEU_DE)))
                {
                    lang_type = ((int)Language.NAEU_DE);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.NAEU_FR)))
                {
                    lang_type = ((int)Language.NAEU_FR);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.NAEU_SP)))
                {
                    lang_type = ((int)Language.NAEU_SP);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log += "Found unsupported new language type " + lan_ver[0] + " from NA/EU.\n";
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update TW server languages
            versionsStr = webClient.DownloadString(TW_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.TW_TW_CN)))
                {
                    lang_type = ((int)Language.TW_TW_CN);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log += "Found unsupported new language type " + lan_ver[0] + " from TW.\n";
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update SEA server languages
            versionsStr = webClient.DownloadString(SEA_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.SEA_ID)))
                {
                    lang_type = ((int)Language.SEA_ID);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.SEA_EN)))
                {
                    lang_type = ((int)Language.SEA_EN);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.SEA_ID_EN)))
                {
                    lang_type = ((int)Language.SEA_ID_EN);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log.Concat("Found unsupported new language type " + lan_ver[0] + " from NA/EU.\n");
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update JP server languages
            versionsStr = webClient.DownloadString(JP_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.JP_JP)))
                {
                    lang_type = ((int)Language.JP_JP);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log += "Found unsupported new language type " + lan_ver[0] + " from JP.\n";
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update TH server languages
            versionsStr = webClient.DownloadString(TH_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.TH_TH)))
                {
                    lang_type = ((int)Language.TH_TH);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.TH_EN)))
                {
                    lang_type = ((int)Language.TH_EN);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log += "Found unsupported new language type " + lan_ver[0] + " from TH.\n";
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update RU server languages
            versionsStr = webClient.DownloadString(RU_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.RU_RU)))
                {
                    lang_type = ((int)Language.RU_RU);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log += "Found unsupported new language type " + lan_ver[0] + " from RU.\n";
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update TR server languages
            versionsStr = webClient.DownloadString(TR_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.TR_TR)))
                {
                    lang_type = ((int)Language.TR_TR);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.TR_EN)))
                {
                    lang_type = ((int)Language.TR_EN);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.TR_TR_EN)))
                {
                    lang_type = ((int)Language.TR_TR_EN);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log.Concat("Found unsupported new language type " + lan_ver[0] + " from TR.\n");
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update SA server languages
            versionsStr = webClient.DownloadString(SA_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.SA_ES)))
                {
                    lang_type = ((int)Language.SA_ES);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.SA_PT)))
                {
                    lang_type = ((int)Language.SA_PT);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log.Concat("Found unsupported new language type " + lan_ver[0] + " from SA.\n");
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            // Update Global Lab server languages
            versionsStr = webClient.DownloadString(GL_LANG_VERSION_URL);
            versionLine = versionsStr.Split('\n');
            foreach (string version in versionLine)
            {
                string[] lan_ver = version.Split(AES_VERSION_DELIMITER.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (lan_ver.Length != 2)
                {
                    continue;
                }

                int lang_type = ((int)Language.UNKNOWN);
                if (lan_ver[0].Equals(GetLanguageFileName(Language.GL_EN)))
                {
                    lang_type = ((int)Language.GL_EN);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.GL_JP)))
                {
                    lang_type = ((int)Language.GL_JP);
                }
                else if (lan_ver[0].Equals(GetLanguageFileName(Language.GL_TW)))
                {
                    lang_type = ((int)Language.GL_TW);
                }
                else if (lan_ver[0].StartsWith("languagedata_"))
                {
                    log.Concat("Found unsupported new language type " + lan_ver[0] + " from Global Lab.\n");
                }
                versions[lang_type] = int.Parse(lan_ver[1]);
            }

            return true;
        }
    }
}
