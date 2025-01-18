using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            ForeignPassport passport = new ForeignPassport("2384637rt", "Andriy", "28.09");
            Console.WriteLine(passport.ToString());
        }
    }
}