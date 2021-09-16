using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public interface IinterfaceDemo
    {
        static int i;
        static IinterfaceDemo()
        {
            Console.WriteLine("Iinterface Demo Static Constructor Called");
        }
        static void InterfaceDemo()
        {
            Console.WriteLine("Iinterface Demo Static Method Called -- " + i);
        }

        abstract void Sum();
    }

    public class InterfaceDemoCheck : IinterfaceDemo
    {
        public virtual void Sum()
        {
            Console.WriteLine("Sum Method Called");
        }
    }
}
