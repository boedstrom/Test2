using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morsning Github!");
            Console.WriteLine("and Goodbye");
            Greeter.Friday();
        }
    }

    static class Greeter
    {
        public static void Friday()
        {
            Console.WriteLine("TGIF!!!");
        }
    }
}
