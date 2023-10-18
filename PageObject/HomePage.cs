using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObject
{
    public class HomePage: BasePage
    {
        private static WebDriverWait wait;
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5000));
        }

        protected IWebElement LoginBtn => driver.FindElement(By.XPath("//button[@ng-click='manager()']"));

        public void ClickBankManagerLoginBtn() => LoginBtn.Click();
       

    }
}
