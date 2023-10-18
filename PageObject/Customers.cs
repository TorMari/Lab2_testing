using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObject
{
    public class Customers: BasePage
    {
        private static WebDriverWait wait;
        public Customers(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        private IWebElement LastNameBtn => driver.FindElement(By.XPath("//tr/td[2]"));

        //private List<IWebElement> LastNameElements => driver.FindElements(By.XPath("//tr/td[2][@class='ng-binding']"));
        private List<IWebElement> LastNameElements => driver.FindElements(By.XPath("//tr/td[2][@class='ng-binding']")).ToList();

        

        public void ClickLastNameBtn() => LastNameBtn.Click();
        public List<string> GetLastNameList() => LastNameElements.Select(element => element.Text).ToList<string>();
       
    }
}
