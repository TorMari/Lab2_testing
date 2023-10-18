using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class BaseSteps
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeFeauture()
        {
            //ChromeConfig chromeConfig = new ChromeConfig();
            //new WebDriverManager.DriverManager().SetUpDriver(chromeConfig);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }

}