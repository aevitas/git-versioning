using System;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var n in Enumerable.Range(0, 100))
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
