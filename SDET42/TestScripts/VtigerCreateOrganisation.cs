using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.TestScripts
{
     class VtigerCreateOrganisation
    {
        [Test]
        public void valification()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("http://localhost:8888/index.php?action=index&module=Home");
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
            driver.FindElement(By.Id("submitButton")).Click();

            driver.FindElement(By.XPath("//a[text()='Organizations']")).Click();
            driver.FindElement(By.XPath("//img[@title=\"Create Organization...\"]")).Click();
            driver.FindElement(By.Name("accountname")).SendKeys("gauravbhaiya");
            driver.FindElement(By.Name("website")).SendKeys("gaurav@gmail.com");
            driver.FindElement(By.Name("button")).Click();
            IWebElement ele = driver.FindElement(By.Id("dtlview_Organization Name"));
            string t=ele.Text;
            string s = "gauravbhaiya";
            Assert.That(t, Is.EqualTo(s));
            Console.WriteLine("pass");
            IWebElement ele2 = driver.FindElement(By.Id("mouseArea_Website"));
            string t2=ele2.Text;
            Assert.That(t2, Is.EqualTo("gaurav@gmail.com"));
            Console.WriteLine("pass");
        }
    }
}
