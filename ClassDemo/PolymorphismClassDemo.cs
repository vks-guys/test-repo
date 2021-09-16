using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class PolymorphismClassDemo
    {
        public virtual void GetName()
        {
            Console.WriteLine("Name from Base Class");
        }
    }

    public class PolymorphismClassDemoCheck : PolymorphismClassDemo
    {
        public new void GetName()
        {
            Console.WriteLine("Name from Derieved Class");
        }
    }
}
