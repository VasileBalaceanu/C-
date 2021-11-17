using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDBConfirmOrdNoTerms.Base
{
    [TestClass]
    public class TestBase
    {
        public ChromeDriver browser;
        public string baseURL;

        [TestInitialize]
        public void Setup()
        {
            browser = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("window-size = 1368, 768");

            baseURL = "https://www.badabum.ro/";
            browser.Navigate().GoToUrl(baseURL);
        }

        [TestCleanup]
        public void CleanUp()
        {
            browser.Quit();
        }
    }
}
