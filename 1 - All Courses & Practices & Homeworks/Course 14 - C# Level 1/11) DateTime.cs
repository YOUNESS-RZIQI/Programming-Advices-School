using System;



namespace MyProgram
{
    internal class Base
    {
        static void Main()
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            DateTime dt1 = new DateTime(2026, 05, 13);

            Console.WriteLine(dt1);

            DateTime dt2 = new DateTime(2026, 05, 13, 18, 51, 00);

            Console.WriteLine(dt2);

            DateTime dt3 = new DateTime(2004, 09, 09, 9, 9, 9, DateTimeKind.Utc);

            Console.WriteLine(dt3);

        }
    }
}