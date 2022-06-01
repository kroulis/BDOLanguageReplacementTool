using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BDOLangReplacement
{
    public class Config
    {
        public string BDOFolder;
        public Languages.Language defaultLanguage;
        public Languages.Language defaultReplacementLanguage;
        public string appLang = "en_us";
        public bool isSteam;

        public void load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                init(filePath);
                return;
            }

            IniFile config = new IniFile(filePath);
            if (config.KeyExists("RootFolder"))
            {
                BDOFolder = config.Read("RootFolder");
            }
            else
            {
                BDOFolder = @".\";
            }

            if (config.KeyExists("srcLang"))
            {
                try
                {
                    defaultLanguage = (Languages.Language)int.Parse(config.Read("srcLang"));
                }
                catch (Exception)
                {
                    defaultLanguage = Languages.Language.NAEU_EN;
                }
            }
            else
            {
                defaultLanguage = Languages.Language.NAEU_EN;
            }

            if (config.KeyExists("tgtLang"))
            {
                try
                {
                    defaultReplacementLanguage = (Languages.Language)int.Parse(config.Read("tgtLang"));
                }
                catch (Exception)
                {
                    defaultReplacementLanguage = Languages.Language.UNKNOWN;
                }
            }
            else
            {
                defaultReplacementLanguage = Languages.Language.UNKNOWN;
            }

            if (!config.KeyExists("isSteam") || !bool.TryParse(config.Read("isSteam"), out isSteam))
            {
                isSteam = true;
            }

            if (config.KeyExists("appLang"))
            {
                appLang = config.Read("appLang");
            }
            else
            {
                appLang = "en_us";
            }

            write(filePath);
        }

        public void init(string filePath)
        {
            BDOFolder = @".\";
            defaultLanguage = Languages.Language.NAEU_EN;
            defaultReplacementLanguage = Languages.Language.UNKNOWN;
            isSteam = true;
            appLang = "en_us";
            write(filePath);
        }

        public void write(string filePath)
        {
            IniFile config = new IniFile(filePath);
            config.Write("RootFolder", BDOFolder);
            config.Write("srcLang", ((int)defaultLanguage).ToString());
            config.Write("tgtLang", ((int)defaultReplacementLanguage).ToString());
            config.Write("isSteam", isSteam.ToString());
            config.Write("appLang", appLang);
        }

        public override bool Equals(object obj)
        {
            if (obj is Config)
            {
                Config other = (Config)obj;
                if (!other.appLang.Equals(appLang) ||
                    other.defaultLanguage != defaultLanguage ||
                    other.defaultReplacementLanguage != defaultReplacementLanguage ||
                    !other.BDOFolder.Equals(BDOFolder) ||
                    other.isSteam != isSteam)
                {
                    return false;
                }
                return true;
            }
            return base.Equals(obj);
        }
    }
}
