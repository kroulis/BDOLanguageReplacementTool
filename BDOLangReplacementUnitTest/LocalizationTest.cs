using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDOLangReplacement.Localizations;

namespace BDOLangReplacementUnitTest
{
    [TestClass]
    public class LocalizationTest
    {
        [TestMethod]
        public void TestENUSLocalization()
        {
            Localization enus = new LocalizationENUS();
            for (int i = 0; i < (int)Localization.FormComponent.MAX; i++)
            {
                Assert.AreNotEqual("", enus.localize((Localization.FormComponent)i));
            }
        }

        [TestMethod]
        public void TestZHCNLocalization()
        {
            Localization enus = new LocalizationZHCN();
            for (int i = 0; i < (int)Localization.FormComponent.MAX; i++)
            {
                Assert.AreNotEqual("", enus.localize((Localization.FormComponent)i));
            }
        }
    }
}
