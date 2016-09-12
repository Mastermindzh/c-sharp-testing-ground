using Classes;
using System;

namespace calc
{
    class Program
    {
        static void Main()
        {
            var c = new Calculator();
            Console.WriteLine(c.Add(3, 5));
            Console.ReadKey();
        }
    }
}
