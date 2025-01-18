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
                Console.WriteLine("Введіть двійкове число (використовуйте тільки 0 та 1):");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentException("Рядок не може бути пустим.");
                }
                if (!input.All(c => c == '0' || c == '1'))
                {
                    throw new FormatException("Рядок містить символи відмінні від 0 та 1.");
                }
                if (input.Length > 31)
                {
                    throw new OverflowException("Двійкове число занадто велике для типу int.");
                }
                checked
                {
                    int result = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        result = (result << 1) + (input[i] - '0');
                    }
                    Console.WriteLine($"Двійкове число {input} в десятковій системі: {result}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка введення: {ex.Message}");
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


 