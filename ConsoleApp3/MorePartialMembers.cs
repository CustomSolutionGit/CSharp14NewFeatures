using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp3
{
    //    You can now declare instance constructors and events as partial members.

    //Partial constructors and partial events must include exactly one defining declaration and one implementing declaration.

    //Only the implementing declaration of a partial constructor can include a constructor initializer: this() or base(). Only one partial type declaration can include the primary constructor syntax.

    //The implementing declaration of a partial event must include add and remove accessors. The defining declaration declares a field-like event.

    public partial class Person
    {
        private string name;

        // Event definition with no logic
        public partial event EventHandler? Clicked;

        // Constructor definition with no logic
        public partial Person(string name);
    }

    public partial class Person
    {
        // Constructor definition with logic implemented
        public partial Person(string name)
        {
            this.name = name;
            Console.WriteLine($"Person создан: {name}");
        }

        // Event definition with the logic implemented
        public partial event EventHandler? Clicked
        {
            add { Console.WriteLine("Подписка на Clicked"); }
            remove { Console.WriteLine("Отписка от Clicked"); }
        }

        public void OnClick()
        {
            // Compiler error: The event 'Person.Clicked' can only appear on the left hand side of += or -=
            // Most probably is not fully supported yet
            // Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
