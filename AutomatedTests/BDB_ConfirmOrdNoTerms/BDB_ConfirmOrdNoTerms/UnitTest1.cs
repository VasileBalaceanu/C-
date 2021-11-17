using System;
//using BDBConfirmOrdNoTerms.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace BadabumConfirmOrderNoTerms
{
    [TestClass]
    public class UnitTest1 //: TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.badabum.ro/");
            try
            {
                IWebElement acceptcookiesBtn = browser.FindElement(By.CssSelector("[class='accept-cookies col-xs-offset-4 col-xs-4 col-sm-offset-0 col-sm-3  pull-right col-lg-2 text-right']"));
                acceptcookiesBtn.Click();

                IWebElement searchbox = browser.FindElement(By.CssSelector("[placeholder='Cauta']"));
                searchbox.SendKeys("alcatel");

                IList<IWebElement> searchBtn = browser.FindElements(By.CssSelector("[class='btn btn-primary']"));
                searchBtn[0].Click();

                browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                IWebElement productname = browser.FindElement(By.CssSelector("[href='/resigilate/alcatel/165473-resigilat-telefon-mobil-alcatel-2003-dual-sim-dark-grey/']"));
                productname.Click();


                IWebElement addcartBtn = browser.FindElement(By.Id("addtocart_button"));
                addcartBtn.Click();

                IWebElement cartIcon = browser.FindElement(By.CssSelector("[class='img-responsive inline-block header-cart-icon']"));
                cartIcon.Click();

                IWebElement GiveOrderBtnFromMenu = browser.FindElement(By.CssSelector("[href='https://www.badabum.ro/shopping/checkout/?do_checkout=true#checkout-wrapper']"));
                GiveOrderBtnFromMenu.Click();

                IWebElement gender = browser.FindElement(By.Id("new_genderm"));
                gender.Click();

                IWebElement firstname = browser.FindElement(By.Id("new_firstname"));
                firstname.SendKeys("Vasi");

                IWebElement lastname = browser.FindElement(By.Id("new_lastname"));
                lastname.SendKeys("Bala");

                IWebElement telefon = browser.FindElement(By.Id("new_telephone"));
                telefon.SendKeys("0755555555");

                IWebElement email = browser.FindElement(By.Id("new_email"));
                email.SendKeys("scoobi98@yahoo.com");

                IWebElement myadress = browser.FindElement(By.Id("buyer_address"));
                myadress.SendKeys("Adresa mea");

                SelectElement states = new SelectElement(browser.FindElement(By.Id("state_new_buyer")));
                foreach (IWebElement mystate in states.Options)
                {
                    if (mystate.Text == "Iasi")
                    { mystate.Click(); }
                }

                SelectElement cities = new SelectElement(browser.FindElement(By.Id("city_new_buyer")));
                foreach (IWebElement mycity in cities.Options)
                {
                    if (mycity.Text == "Alexeni")
                    { mycity.Click(); }
                }

                IWebElement Paymentmethod = browser.FindElement(By.Id("payment_method_3"));
                Paymentmethod.Click();

                IWebElement ConfirmOrderBtnFinally = browser.FindElement(By.CssSelector("[class='fa fa-check']"));
                ConfirmOrderBtnFinally.Click();

                IAlert alert = browser.SwitchTo().Alert();
                string alertmsg = alert.Text;
                Assert.IsTrue(alertmsg.Contains("Pentru a trimite comanda trebuie sa fiti de acord cu conditiile de utilizare"));
                browser.Quit();
            }
            catch
            {
                browser.Quit();
                TestMethod1();
            }
        }
    }
}
