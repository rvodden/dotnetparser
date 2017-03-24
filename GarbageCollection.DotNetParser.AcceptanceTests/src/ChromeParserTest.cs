using BoDi;
using GarbageCollection.DotNetParser.AcceptanceTests.src.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src
{
    [Binding]
    class ChromeParserTest
    {
        public IWebDriver WebDriver { get; set; }
        public IParserPage ParserPage { get; set; }


        private readonly IObjectContainer ObjectContainer;

        public ChromeParserTest(IObjectContainer objectContainer)
        {
            ObjectContainer = objectContainer;
        }

        [BeforeScenario]
        public void setupTestEnvironment()
        {
            // do setup activities here
            WebDriver = new ChromeDriver();
            ObjectContainer.RegisterInstanceAs<IWebDriver>(WebDriver);

            ParserPage = new ParserPage(WebDriver);
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

