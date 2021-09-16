using System;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //StaticClassDemo.Id = 10;
            //StaticClassDemo.Method1();
            //Console.WriteLine("Hello World!");

            //Parallel.Invoke(() =>
            //{
            //    GeneralClassDemo.GetTestMethod();
            //    GeneralClassDemo.GetTestMethod();
            //});
            //GeneralClassDemoCheck.TestMethod();

            //IinterfaceDemo.i = 5;
            //IinterfaceDemo.InterfaceDemo();

            //IinterfaceDemo iinterfaceDemo = new InterfaceDemoCheck();
            //iinterfaceDemo.Sum();

            PolymorphismClassDemoCheck polymorphismClassDemoCheck = new PolymorphismClassDemoCheck();
            polymorphismClassDemoCheck.GetName();

            Console.WriteLine("-----------------------------------------------");

            PolymorphismClassDemo polymorphismClassDemo = new PolymorphismClassDemoCheck();
            polymorphismClassDemo.GetName();

            Console.ReadKey();
        }
    }
}
