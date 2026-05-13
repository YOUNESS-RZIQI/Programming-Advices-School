using System;

namespace Program
{
    internal class Base
    {
        static void Main()
        {
            Nullable<int> a = null;

            Console.WriteLine("A Nullable Data type can have Null or the Tamplate data Type also \nFor example :\n");
            Console.WriteLine("\t\ta = {0}", a);

            a = 1337;

            Console.WriteLine("\n\t\ta = {0}", a);

            Console.ReadKey();

        }
    }
}