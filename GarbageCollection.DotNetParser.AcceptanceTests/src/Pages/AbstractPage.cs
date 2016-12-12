using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src.Pages
{
    abstract class AbstractPage: IPage
    {
        protected IWebDriver WebDriver
        { get; set; }

        private String URL
        { get; set; }


        public AbstractPage(IWebDriver webDriver, String url)
        {
            this.WebDriver = webDriver;
            URL = url;
            PageFactory.InitElements(webDriver, this);
        }

        public void Visit()
        {
             WebDriver.Navigate().GoToUrl(URL);
        }

        public void ShutDown()
        {
            WebDriver.Dispose();
        }
    }
}
