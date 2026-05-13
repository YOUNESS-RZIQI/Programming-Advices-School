using System;
using System.Runtime.InteropServices;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = default;
            sbyte sb = default;

            Console.WriteLine("byte b = {0}", b);
            Console.WriteLine("sbyte sb = {0}\n", sb);

            short sh = default;
            ushort ush = default;

            Console.WriteLine("short sh = {0}", sh);
            Console.WriteLine("ushort ush = {0}\n", ush);

            int i = default;
            uint ui = default;

            Console.WriteLine("int i = {0}", i);
            Console.WriteLine("uint i = {0}\n", ui);

            long l = default;
            ulong ul = default;

            Console.WriteLine("long l = {0}", l);
            Console.WriteLine("ulong l = {0}\n", ul);

            float f = default;

            Console.WriteLine("float f = {0}\n", f);

            double d = default;

            Console.WriteLine("double d = {0}\n", d);

            decimal de = default;

            Console.WriteLine("decimal de = {0}\n", de);

            char c = default;

            Console.WriteLine("char c = {0}\n", c);

            string s = default;

            Console.WriteLine("string s = {0}", s);

        }
    }
}