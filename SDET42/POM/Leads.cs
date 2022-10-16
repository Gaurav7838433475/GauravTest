using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{
     class Leads
    {
        [FindsBy(How=How.XPath,Using = "//img[@title=\"Create Lead...\"]")]
        private IWebElement plusButton { get; }

        [FindsBy(How=How.XPath,Using = "//img[@title=\"Search in Leads...\"]")]
        private IWebElement leadSearch { get; }

        [FindsBy(How=How.XPath,Using = "//img[@title=\"Open Calendar...\"]")]
        private IWebElement calender { get; }
        [FindsBy(How=How.XPath,Using = "//img[@title=\"Show World Clock...\"]")]
        private IWebElement clock { get; }
        [FindsBy(How=How.XPath,Using = "//img[@title=\"Open Calculator...\"]")]
        private IWebElement calculator { get; }

        public void plusButtonmethod()
        {
            plusButton.Click();
        }
        public void leadSearchButton()
        {
            leadSearch.Click();
        }
        public void calenderMethod()
        {
            calender.Click();
        }
        public void clockMethod()
        {
            clock.Click();
        }
        public void calculatorMethod()
        {
            calculator.Click();
        }
    }
}
