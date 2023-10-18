using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObject
{
    public class BankManagerLoginPage: BasePage
    {
        private static WebDriverWait wait;
        public BankManagerLoginPage(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        private IWebElement CustBtn => driver.FindElement(By.XPath("//button[@ng-click='showCust()']"));

        public void ClickCustomersBtn() => CustBtn.Click();
    }
}
