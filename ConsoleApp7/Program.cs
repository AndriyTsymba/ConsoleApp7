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

            while (true)
            {
                Console.WriteLine("Калькулятор систем числення");
                Console.WriteLine("1. Двійкова");
                Console.WriteLine("2. Вісімкова");
                Console.WriteLine("3. Шістнадцяткова");
                Console.WriteLine("4. Вихід");
                Console.Write("Виберіть систему числення: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    break;
                }

                Console.Write("Введіть число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Convertor convertor = new Convertor();
                convertor.SetAndDispay(num, choice);
                Console.WriteLine();
            }
        }
    }
}