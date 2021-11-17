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
                searchbox.SendKeys("jucarie");

                IList<IWebElement> searchBtn = browser.FindElements(By.CssSelector("[class='btn btn-primary']"));
                searchBtn[0].Click();

                browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);//asteapta 30 secunde daca nu gaseste ce a cautat
                IWebElement productname = browser.FindElement(By.CssSelector("[title='U-Grow Jucarie textila inghetata UG-AF10, 20 x 8 cm']"));
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
                firstname.SendKeys("Vi");

                IWebElement lastname = browser.FindElement(By.Id("new_lastname"));
                lastname.SendKeys("Ba");

                IWebElement telefon = browser.FindElement(By.Id("new_telephone"));
                telefon.SendKeys("07");

                IWebElement email = browser.FindElement(By.Id("new_email"));
                email.SendKeys("scooobi98@yahoo.com");

                IWebElement myadress = browser.FindElement(By.Id("buyer_address"));
                myadress.SendKeys("Adresa mea");

                SelectElement states = new SelectElement(browser.FindElement(By.Id("state_new_buyer")));
                foreach (IWebElement mystate in states.Options)
                {
                    if (mystate.Text == "Iasi") // dropdown alegere oras
                    { mystate.Click(); }
                }

                SelectElement cities = new SelectElement(browser.FindElement(By.Id("city_new_buyer")));
                foreach (IWebElement mycity in cities.Options)
                {
                    if (mycity.Text == "Alexeni") // dropdown alegere localitate
                    { mycity.Click(); }
                }

               
                IWebElement Paymentmethod = browser.FindElement(By.Id("payment_method_3"));
                Paymentmethod.Click();

                IWebElement AgreeTermandCond = browser.FindElement(By.Id("option_agree"));
                AgreeTermandCond.Click();

                IWebElement ConfirmOrderBtnFinally = browser.FindElement(By.CssSelector("[class='fa fa-check']"));
                ConfirmOrderBtnFinally.Click();

            }
             catch
             {
                 browser.Quit();
                  TestMethod1();
           }

            
            IWebElement TYpagedisplayed = browser.FindElement(By.Id("thank_you_page"));
            //desi bifez modalitatea de plata Numerar, mai nou vad ca nu o mai recunoaste ca si BIFAT, pana acum mergea
            // deci va fi un nou BUG
            Assert.IsTrue(TYpagedisplayed.Displayed);
            browser.Quit();
        }
    }
}
