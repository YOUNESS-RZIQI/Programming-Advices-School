using System;

namespace MyProram
{
    internal class Base
    {
        static void Main()
        {
            dynamic val1;
            val1 = 100;

            Console.WriteLine("daynamic val1 = {0} , val1 type: {1}\n", val1, val1.GetType());


            dynamic val2 = "youness";
            Console.WriteLine("daynamic va2 = {0} , val2 type: {1}\n", val2, val2.GetType());


            dynamic val3 = 'm';
            Console.WriteLine("daynamic va3 = {0} , val3 type: {1}\n", val3, val3.GetType());

            dynamic val4 = true;
            Console.WriteLine("daynamic va4 = {0} , val4 type: {1}\n", val4, val4.GetType());

        }
    }
}