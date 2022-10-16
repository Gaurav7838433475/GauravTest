using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{
     class CreateNewOrganisation
    {
        [FindsBy(How=How.Name,Using = "accountname")]
        private IWebElement organisationNameTextField { get; }

        [FindsBy(How=How.Name,Using = "button")]
        private IWebElement saveButton { get; }

        public void organisationNameTextFieldMethod(String text)
        {
            organisationNameTextField.SendKeys(text);
        }

        public void saveButtonMethod()
        {
            saveButton.Click();
        }
    }
}
