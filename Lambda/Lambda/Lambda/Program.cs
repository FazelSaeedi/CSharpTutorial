using System;
using System.Collections;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            Action action = () => { } ;


            i.ToString();

            actionInt(99);
            string s = func("Hi");

        }

        static Action<int> actionInt = myInt =>
        {
            var i = 0;
            Console.WriteLine(myInt.ToString());
        };

        static Func<string, string> func = (x) =>
        {
            Console.WriteLine(x.ToString());
            return x;
        };
    }
}
