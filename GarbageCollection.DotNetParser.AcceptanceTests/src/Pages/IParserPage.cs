using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection.DotNetParser.AcceptanceTests.src.Pages
{
    public interface IParserPage: IPage
    {
        void Calculate(String expression);

        Double GetResult();
    }

}
