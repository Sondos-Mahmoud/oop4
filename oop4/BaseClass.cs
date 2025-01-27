using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
    internal class DerivedClass1: BaseClass
    {
        // Overriding the base class method
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }
    internal class DerivedClass2 : BaseClass
    {
        // Hiding the base class method using the 'new' keyword
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }


}
