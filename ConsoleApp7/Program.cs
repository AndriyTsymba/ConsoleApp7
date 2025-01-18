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
            try
            {
                Console.WriteLine("Введіть число (тільки цифри 0-9):");
                string input = Console.ReadLine();
                if (!input.All(char.IsDigit))
                {
                    throw new FormatException("Рядок містить неприпустимі символи. Дозволені тільки цифри 0-9.");
                }
                checked
                {
                    int result = Convert.ToInt32(input);
                    Console.WriteLine($"Успішно конвертовано в число: {result}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Помилка формату: {ex.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Помилка: число виходить за межі допустимого діапазону int ({int.MinValue} до {int.MaxValue})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла непередбачена помилка: {ex.Message}");
            }
        }
    }
}



 