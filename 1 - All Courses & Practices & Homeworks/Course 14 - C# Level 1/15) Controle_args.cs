
using System;


namespace Main
{
    internal class Program
    {

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child2);
        }

        static void Main()
        {

            //see the order of sending parameters is not important.

            MyMethod(child3: "Omar", child1: "Saqer", child2: "youness");

            Console.ReadKey();

        }
    }
}
