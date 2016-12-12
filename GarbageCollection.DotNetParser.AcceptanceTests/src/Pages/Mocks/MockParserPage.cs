using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src.Pages.Mocks
{
    class MockParserPage : IParserPage
    {
        private Double Result;

        void IParserPage.Calculate(string expression)
        {
            Result = Double.Parse(expression);
        }

        Double IParserPage.GetResult()
        {
            return Result;
        }

        void IPage.Visit()
        {
            // Do nothing here - mock implementation
        }
    }
}
