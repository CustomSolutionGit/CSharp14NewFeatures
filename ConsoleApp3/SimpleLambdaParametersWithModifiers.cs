using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class SimpleLambdaParametersWithModifiers
    {

        delegate bool TryParseNew<T>(string text, out T result);
        // ...
        TryParseNew<int> parse1 = (text, out result) => Int32.TryParse(text, out result);

        delegate bool TryParseOld<T>(string text, out T result);

        TryParseOld<int> parse2 = (string text, out int result) => Int32.TryParse(text, out result);
    }
}
