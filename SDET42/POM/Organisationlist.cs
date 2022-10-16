using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.POM
{
     class Organisationlist
    {
        [FindsBy(How = How.XPath, Using = "//img[@title=\"Create Organization...\"]")]
        private IWebElement plusButtom { get; }


    }
}
