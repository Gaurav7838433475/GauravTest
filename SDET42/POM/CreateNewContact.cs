using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{
     class CreateNewContact
    {
        [FindsBy(How=How.Name,Using = "firstname")]
        private IWebElement firstNameTextField { get; }

        [FindsBy(How=How.Name,Using = "lastname")]
        private IWebElement lastNameTextField { get; }
        [FindsBy(How = How.Name, Using = "button")]
        private IWebElement saveButton { get; }

        public void fistnameTextField(string text)
        {
            firstNameTextField.SendKeys(text);
        }
        public void lastNameTextFieldm(string text)
        {
            lastNameTextField.SendKeys(text);
        }
        public void saveButtonmethod()
        {
            saveButton.Click();
        }
    }
}
