using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.TestScripts
{
    class VtigerCreateContact
    {
        [Test]
        public void createContact()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("http://localhost:8888/index.php?action=index&module=Home");
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
            driver.FindElement(By.Id("submitButton")).Click();
            driver.FindElement(By.XPath("//a[text()='Contacts']")).Click();
            driver.FindElement(By.XPath("//img[@title=\"Create Contact...\"]")).Click();
            driver.FindElement(By.Name("lastname")).SendKeys("Mehta");
            driver.FindElement(By.Name("button")).Click();
        }
    }
}
