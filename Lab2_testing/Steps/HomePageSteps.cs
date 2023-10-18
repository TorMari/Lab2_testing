using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PageObject;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Lab2_testing.Steps
{
    [Binding]
    public sealed class HomePageSteps: BaseSteps
    {
        private HomePage HomePage;

        [Given(@"go to home page")]
        public void GivenOpenSearchPage()
        {
            HomePage = new HomePage(driver);
        }

        [Given(@"click on the button 'Bank Manager Login'")]
        public void GoToBankManagerLoginPage()
        {
            HomePage.ClickBankManagerLoginBtn();
        }

    }
}
