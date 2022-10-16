using FakeItEasy.Sdk;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{
    class CreateNewProduct
    {
        [FindsBy(How = How.XPath, Using = "//img[@title=\"Create Product...\"]")]
        private IWebElement addBtn { get; }
        [FindsBy(How =How.Name, Using = "productname")]
        private IWebElement productNameTxtField { get; }
        [FindsBy(How =How.Name,Using = "assigntype")]
        private IWebElement userRadioBtn { get; }
        [FindsBy(How =How.Name,Using = "button")]
        private IWebElement saveBtn { get; }

        public void clickOnAddBtn()
        {
            addBtn.Click();
        }
        public 
    }
}
