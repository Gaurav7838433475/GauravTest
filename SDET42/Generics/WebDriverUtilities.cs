using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.Generics
{
    class WebDriverUtilities
    {
        public void implicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void explicitlyWait(IWebDriver driver)
        {
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void alertPopupsAccept(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        public void alertPopupsDismiss(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }
        public void switchToFrame(IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);
        }
        public void switchBackFromFrame(IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
        }
        public void handleDropdownByIndex(IWebElement ele, int index)
        {
            SelectElement s = new SelectElement(ele);
            s.SelectByIndex(index);
        }
        public void handleDropdownByText(IWebElement ele, string str)
        {
            SelectElement s = new SelectElement(ele);
            s.SelectByText(str);
        }
        public void handleDropdownByIndexDeselect(IWebElement ele, int index)
        {
            SelectElement s = new SelectElement(ele);
            s.DeselectByIndex(index);
        }
        public void handleDropdownByTextdeselect(IWebElement ele, string str)
        {
            SelectElement s = new SelectElement(ele);
            s.DeselectByText(str);
        }
        public void mousehover(IWebDriver driver, IWebElement ele)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(ele).Perform();
        }
        public void rightClick(IWebDriver driver, IWebElement ele)
        {
            Actions a = new Actions(driver);
            a.ContextClick(ele).Perform();
        }
        public void dragAndDrop(IWebDriver driver, IWebElement src, IWebElement des)
        {
            Actions a = new Actions(driver);
            a.DragAndDrop(src, des).Perform();
        }
        public void doubleClick(IWebDriver driver, IWebElement ele)
        {
            Actions a = new Actions(driver);
            a.DoubleClick(ele).Perform();
        }
        public void clickByJavascript(IWebDriver driver, string value, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string elementvalue = value;
            js.ExecuteScript("arguments[0].value='" + elementvalue + "', element");
        }
        public void javascriptToClick(IWebDriver driver, IWebElement ele)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].clcik()", ele);



        }
       

       
    }
}
