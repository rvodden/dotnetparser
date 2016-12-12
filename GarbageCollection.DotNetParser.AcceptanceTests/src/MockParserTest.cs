using BoDi;
using GarbageCollection.DotNetParser.AcceptanceTests.src.Pages;
using GarbageCollection.DotNetParser.AcceptanceTests.src.Pages.Mocks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src
{
    [Binding]
    class MockParserTest
    {
        public IWebDriver WebDriver { get; set; }
        public IParserPage ParserPage { get; set; }


        private readonly IObjectContainer ObjectContainer;

        public MockParserTest(IObjectContainer objectContainer)
        {
            ObjectContainer = objectContainer;
        }

        [BeforeScenario]
        public void setupTestEnvironment()
        {
            // do setup activities here
            WebDriver = new ChromeDriver();
            ObjectContainer.RegisterInstanceAs<IWebDriver>(WebDriver);

            ParserPage = new MockParserPage();
            ObjectContainer.RegisterInstanceAs<IParserPage>(ParserPage);

        }

        [AfterScenario]
        public void teardownTestEnvironment()
        {
            this.WebDriver.Close();
            this.WebDriver.Dispose();
        }

    }
}
