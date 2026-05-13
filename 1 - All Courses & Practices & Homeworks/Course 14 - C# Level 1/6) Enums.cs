using System;

namespace Program
{
    internal class Base
    {
        enum eColors { Blue = 1, Red = 2, Green = 3 }

        static void Main()
        {
            Console.WriteLine("Which Color do you like:\n");
            Console.WriteLine("\t1) Blue");
            Console.WriteLine("\t2) Red");
            Console.WriteLine("\t3) Green");

            Console.Write("\nChoose your color: ");

            int choice = int.Parse(Console.ReadLine());


            Console.WriteLine("\nYou choosed {0}", (eColors)choice);

        }

    }
}