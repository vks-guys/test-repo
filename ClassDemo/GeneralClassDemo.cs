using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class GeneralClassDemo
    {
        static readonly int _Count = 0;
        private GeneralClassDemo()
        {
            Console.WriteLine("General Class Private Constructor Called");
        }
        public GeneralClassDemo(int Id)
        {
            Console.WriteLine("General Class Public Constructor Called");
        }
        static GeneralClassDemo()
        {
            _Count++;
            Console.WriteLine("General Class Static Constructor Called -- " + _Count);
        }

        public static void GetTestMethod()
        {
            Console.WriteLine("General Class Static Method Called");
        }
    }

    public static class GeneralClassDemoCheck
    {
        public static void TestMethod()
        {
            GeneralClassDemo generalClassDemo = new GeneralClassDemo(1);
        }
    }
}
