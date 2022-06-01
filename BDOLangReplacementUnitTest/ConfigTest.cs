using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDOLangReplacement;
using System.IO;

namespace BDOLangReplacementUnitTest
{
    [TestClass]
    public class ConfigTest
    {
        [TestMethod]
        public void TestInitConfig()
        {
            Config config = new Config();
            try
            {
                Directory.CreateDirectory("test/");
            }
            catch (IOException)
            {
                // PASS
            }

            try
            {
                File.Delete("test/test.ini");
            }
            catch (IOException)
            {
                //PASS
            }

            Assert.IsFalse(File.Exists("test/test.ini"));
            config.init("test/test.ini");
            Assert.IsTrue(File.Exists("test/test.ini"));
            Config config2 = new Config();
            config2.load("test/test.ini");
            Assert.IsTrue(config.Equals(config2));
        }

        [TestMethod]
        public void TestReadWrite()
        {
            Config config = new Config();
            try
            {
                Directory.CreateDirectory("test/");
            }
            catch (IOException)
            {
                // PASS
            }

            try
            {
                File.Delete("test/test2.ini");
            }
            catch (IOException)
            {
                //PASS
            }

            Assert.IsFalse(File.Exists("test/test2.ini"));
            config.defaultLanguage = Languages.Language.MAX;
            config.defaultReplacementLanguage = Languages.Language.MAX;
            config.appLang = "zh_cn";
            config.isSteam = false;
            config.BDOFolder = "test/";
            config.write("test/test2.ini");
            Assert.IsTrue(File.Exists("test/test2.ini"));
            Config config2 = new Config();
            config2.load("test/test2.ini");
            Assert.IsTrue(config.Equals(config2));
        }
    }
}
