using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ImplicitSpanConversions
    {
        public ImplicitSpanConversions()
        {
           
        }

        public void DisplayImplicitConversions()
        {
            // string is implicitly converted into ReadOnlySpan<char>
            ReadOnlySpan<char> spanFromString = "Hello, World!";
            Console.WriteLine(spanFromString);

            // int[] is implicitly converted into Span<int>
            int[] numbers = { 1, 2, 3, 4, 5 };
            Span<int> spanFromArray = numbers;

            // It allowes to wirk with array elements without creating a copy
            spanFromArray[0] = 42;
            Console.WriteLine(string.Join(", ", numbers)); // 42, 2, 3, 4, 5
        }
    }
}
