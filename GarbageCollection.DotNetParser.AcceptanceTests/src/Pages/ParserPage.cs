using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src.Pages
{
    class ParserPage : AbstractPage, IParserPage
    {
        // This should be a property which we can specify somewhere
        private const String MyUrl = @"http://localhost:5135/";

        [FindsBy(How = How.Id, Using = "form:expression")]
        IWebElement formExpression;

        [FindsBy(How = How.Id, Using = "form:submit")]
        IWebElement submitButton;

        [FindsBy(How = How.Id, Using = "form:result")]
        IWebElement resultField;

        public ParserPage(IWebDriver webDriver) : base(webDriver, MyUrl)
        {

        }

        void IParserPage.Calculate(string expression)
        {
            formExpression.Clear();
            formExpression.SendKeys(expression);
            submitButton.Submit();

        }

        double IParserPage.GetResult()
        {
            return Double.Parse(resultField.Text);
        }
    }
}
