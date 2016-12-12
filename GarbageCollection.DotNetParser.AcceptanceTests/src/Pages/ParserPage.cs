using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src.Pages
{
    class ParserPage : AbstractPage, IParserPage
    {
        // This should be a property which we can specify somewhere
        private const String MyUrl = @"http://localhost:8080/parser";

        [FindsBy(How = How.Id, Using = "form:expression")]
        IWebElement formExpression;

        [FindsBy(How = How.Id, Using = "form:submit")]
        IWebElement submitButton;

        public ParserPage(IWebDriver webDriver) : base(webDriver, MyUrl)
        {

        }

        void IParserPage.Calculate(string expression)
        {
            throw new NotImplementedException();
        }

        double IParserPage.GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
