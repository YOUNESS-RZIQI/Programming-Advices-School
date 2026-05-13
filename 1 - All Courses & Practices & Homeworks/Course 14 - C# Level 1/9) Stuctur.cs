using System;


namespace MyProgram
{
    internal class Base
    {
        struct sPersong
        {
            public string Name;
            public int Age;
        }

        static void Main()
        {
            sPersong P1;

            P1.Name = "Youness";
            P1.Age = 22;

            Console.WriteLine("P1 Name : {0},  P1 Age : {1}\n", P1.Name, P1.Age);


            sPersong P2 = new sPersong();


            P2.Name = "Youness";
            P2.Age = 35;

            Console.WriteLine("P2 Name : {0},  P2 Age : {1}\n", P2.Name, P2.Age);

        }
    }
}