using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class UnboundGenericTypesAndNameof
    {
        // In earlier versions of C#, only closed generic types, such as List<int>,
        // could be used to return the List name:
        public void OldWayToGetTypeName()
        {
            Console.WriteLine(typeof(List<int>).Name); // Outputs "List`1"
            Console.WriteLine(typeof(Dictionary<string, int>).Name); // Outputs "Dictionary`2"
        }

        // Beginning with C# 14, the argument to nameof can be an unbound generic type:
        public void NewWayToGetTypeName()
        {
            Console.WriteLine(typeof(List<>).Name); // Outputs "List`1"
            Console.WriteLine(typeof(Dictionary<,>).Name); // Outputs "Dictionary`2"
        }
    }
}
