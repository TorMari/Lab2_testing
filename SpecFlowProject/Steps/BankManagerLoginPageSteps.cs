using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PageObject;
using System.Threading;


namespace SpecFlowProject.Steps
{
    [Binding]
    public sealed class BankManagerLoginPageSteps: BaseSteps
    {
        private BankManagerLoginPage BankManagerLoginPage;

        [Given(@"click on the button 'Customers'")]
        public void GoToCustomers()
        {
            BankManagerLoginPage = new BankManagerLoginPage(driver);
            BankManagerLoginPage.ClickCustomersBtn();
            Thread.Sleep(5000);
        }

    }
}
