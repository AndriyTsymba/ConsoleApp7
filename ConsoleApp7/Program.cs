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
                Console.WriteLine("Введіть математичний вираз (тільки цілі числа та оператор *):");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("Введення не може бути порожнім.");
                }
                string[] parts = input.Split('*');

                int result = 1;
                foreach (string part in parts)
                {
                    // Перетворюємо кожну частину на ціле число
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        result *= number;
                    }
                    else
                    {
                        throw new FormatException($"Не вдалося перетворити '{part}' на ціле число.");
                    }
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Помилка формату: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Помилка введення: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Невідома помилка: " + ex.Message);
            }
        }
    }
}