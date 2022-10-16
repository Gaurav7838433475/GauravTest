using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{
     class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Leads']")]
        private IWebElement leadsButton { get; }

        [FindsBy(How=How.XPath,Using = "//a[text()='Organizations']")]
        private IWebElement organisationButton { get; }

        [FindsBy(How=How.XPath,Using = "//a[text()='Contacts']")]
        private IWebElement contactButton { get; }

        [FindsBy(How=How.XPath,Using= "//a[text()='More']")]
        private IWebElement moreButton { get; }

        public void leads()
        {
            leadsButton.Click();
        }

        public void organisation()
        {
            organisationButton.Click();
        }

        public void contacts()
        {
            contactButton.Click();
        }
        public void more()
        {
            moreButton.Click();
        }
    }
}
