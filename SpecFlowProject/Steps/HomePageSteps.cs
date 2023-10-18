using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PageObject;
using OpenQA.Selenium;
using System.Threading;

namespace SpecFlowProject.Steps
{
    [Binding]
    public sealed class HomePageSteps: BaseSteps
    {
        private HomePage HomePage;

        [Given(@"go to home page")]
        public void GivenOpenSearchPage()
        {
            HomePage = new HomePage(driver);
            Thread.Sleep(5000);
        }

        [Given(@"click on the button 'Bank Manager Login'")]
        public void GoToBankManagerLoginPage()
        {
            HomePage.ClickBankManagerLoginBtn();
            Thread.Sleep(5000);
        }

    }
}
