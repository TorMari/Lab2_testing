using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SpecFlowProject.Steps
{
    [Binding]
    public sealed class CustomersSteps: BaseSteps
    {
        private Customers Customers;
        List<string> expectedList = new List<string>();
        List<string> resultList = new List<string>();

        [When(@"click on the button 'Last Name' in table")]
        public void WhenClickLastName()
        {
            Customers = new Customers(driver);
            expectedList = Customers.GetLastNameList();
            expectedList.Sort((a, b) => b.CompareTo(a));
            Customers.ClickLastNameBtn();
            resultList = Customers.GetLastNameList();
            Thread.Sleep(5000);
        }

        [Then(@"customers list is sorted in descending order of last name")]
        public void ThenTheResultShouldBe()
        {
            CollectionAssert.AreEqual(expectedList, resultList);
        }
    }
}
