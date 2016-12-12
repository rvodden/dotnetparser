using GarbageCollection.DotNetParser.AcceptanceTests.src.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src
{
    [Binding]
    public class LiteralsStorySteps
    {
        IParserPage ParserPage { get; set; }

        public LiteralsStorySteps( IParserPage parserPage )
        {
            ParserPage = parserPage;
        }

        [Given(@"I visit the webpage")]
        public void GivenIVisitTheWebpage()
        {
            ParserPage.Visit();
        }
        
        [When(@"I submit the expression (.*)")]
        public void WhenISubmitTheExpression(String expression)
        {
            ParserPage.Calculate(expression);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(Double result)
        {
            Double ObservedResult = ParserPage.GetResult();
            Assert.AreEqual(result, ObservedResult, 0.01, "Parser returned the wrong result!");
        }
    }
}
