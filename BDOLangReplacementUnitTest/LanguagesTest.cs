using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDOLangReplacement;
using System.IO;

namespace BDOLangReplacementUnitTest
{
    [TestClass]
    public class LanguagesTest
    {
        [TestMethod]
        public void TestUpdateVersions()
        {
            Languages languages = new Languages();
            Assert.IsTrue(languages.UpdateVersions());
            Assert.AreEqual("", languages.log);
        }

        [TestMethod]
        public void TestGrabNALangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.NAEU_EN; i < (int)Languages.Language.TW_TW_CN; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabTWLangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.TW_TW_CN; i < (int)Languages.Language.SEA_ID; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabSEALangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.SEA_ID; i < (int)Languages.Language.JP_JP; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabJPLangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.JP_JP; i < (int)Languages.Language.TH_TH; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabTHLangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.TH_TH; i < (int)Languages.Language.RU_RU; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabRULangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.RU_RU; i < (int)Languages.Language.TR_TR; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }
        
        [TestMethod]
        public void TestGrabTRLangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.TR_TR; i < (int)Languages.Language.SA_PT; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabSALangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.SA_PT; i < (int)Languages.Language.GL_EN; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestGrabGLLangVersions()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            for (int i = (int)Languages.Language.GL_EN; i < (int)Languages.Language.MAX; i++)
            {
                Assert.AreNotEqual(-1, languages.versions[i]);
            }
        }

        [TestMethod]
        public void TestDownloadLanguageFile()
        {
            Languages languages = new Languages();
            languages.UpdateVersions();
            try
            {
                Directory.CreateDirectory("test");
            }
            catch (IOException)
            {
                // PASS
            }
            for (int i = (int)Languages.Language.NAEU_EN; i < (int)Languages.Language.MAX; i++)
            {
                if (languages.versions[i] == -1)
                    continue;
                
                try
                {
                    File.Delete("test/lan.loc");
                }
                catch (IOException)
                {
                    // PASS
                }

                Assert.IsTrue(languages.DownloadLanguageFile((Languages.Language)i, "test/lan.loc"));
                Assert.IsTrue(File.Exists("test/lan.loc"));
            }
        }
    }
}
