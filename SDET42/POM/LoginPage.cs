using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{

    class LoginPage
    {
        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement usernameTextField { get; }

        [FindsBy(How = How.Name, Using = "user_password")]
        private IWebElement passwordTextField { get; }

        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement loginButton { get;  }

       public void LoginToVtiger(String username,String Password)
        {
            this.usernameTextField.SendKeys(username);
            this.passwordTextField.SendKeys(Password);
            this.loginButton.Click();
        }
    }
}
