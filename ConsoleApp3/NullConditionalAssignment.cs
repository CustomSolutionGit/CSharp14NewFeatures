using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class NullConditionalAssignment
    {
        public string? SomeStringNullableValue { get; set; }

        
        public void AssignSomeStringNullableValue(string? value)
        {
            // Now it is allowed to use null-conditional operator in assignment
            SomeStringNullableValue = value?.ToString();

            // Old way is to check if null before assignment

            if (value != null)
            {
                SomeStringNullableValue = value.ToString();
            }
            else
            {
                SomeStringNullableValue = string.Empty;
            }
        }

    }
}
