using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public static class StaticClassDemo : Object
    {
        private static int _Id;
        private const float _pi = 3.14f;
        public static int Id { get { return _Id; } set { _Id = value; } }

        static StaticClassDemo()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public static void Method1()
        {
            Console.WriteLine("Static Method Called! ---- " + _Id + " ----- " + _pi);
        }
    }

    public class StaticClassDemoCheck
    {

    }
}
