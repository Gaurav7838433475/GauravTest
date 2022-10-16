using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SDET42.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.TestScripts
{
    [TestFixture]
     class login
    {
        [Test]
        public void loginpage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8888/");//url
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
            driver.FindElement(By.Id("submitButton")).Click();
            driver.FindElement(By.XPath("//a[text()='Organizations']")).Click();
            driver.FindElement(By.Name("accountname")).SendKeys("gaurav kumar");
            driver.FindElement(By.Name("website")).SendKeys("gaurav@gmail.com");
            driver.FindElement(By.Name("tickersymbol")).SendKeys("mehta");
            driver.FindElement(By.Name("account_name")).SendKeys("4");
            driver.FindElement(By.Id("employees")).SendKeys("400");
            driver.FindElement(By.Id("email2")).SendKeys("gauravkumar92.badal@gmail.com");

            WebDriverUtilities utilities = new WebDriverUtilities();
            IWebElement ele = driver.FindElement(By.Name("industry"));
            utilities.handleDropdownByIndex(ele, 8);
            IWebElement ele2 = driver.FindElement(By.Name("accounttype"));
            utilities.handleDropdownByIndex(ele2, 3);//fgf
            driver.FindElement(By.Name("emailoptout")).Click();
            driver.FindElement(By.Name("assigntype")).Click();
            IWebElement ele3 = driver.FindElement(By.Name("assigned_group_id"));
            utilities.handleDropdownByIndex(ele3, 2);
            driver.FindElement(By.Id("phone")).SendKeys("7838433475");
            driver.FindElement(By.Id("fax")).SendKeys("78384334751654545"); 
            driver.FindElement(By.Id("otherphone")).SendKeys("7838433454");
            driver.FindElement(By.Id("email1")).SendKeys("gaurav@gmail.com");
            driver.FindElement(By.Name("button")).Click();//gaga
        }

    }
}
