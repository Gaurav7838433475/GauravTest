using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET42.TestScripts
{
     class VerifyVtigerLogin
    {
        public TestContext TestContext { get; set; }

        [Test]
        public void Print()
        {
            String url = TestContext.Parameters.Get("url");
            Console.WriteLine(url);
        }
    }
}
