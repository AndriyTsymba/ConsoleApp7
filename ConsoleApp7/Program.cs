using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {

        public class CreditCard
        {
            private string cardNumber;
            private string ownerName;
            private string cvc;
            private DateTime expirationDate;

            public CreditCard(string cardNumber, string ownerName, string cvc, DateTime expirationDate)
            {
                SetCardNumber(cardNumber);
                SetOwnerName(ownerName);
                SetCVC(cvc);
                SetExpirationDate(expirationDate);
            }

            public void SetCardNumber(string number)
            {
                if (string.IsNullOrEmpty(number) || number.Length != 16 || !IsDigitsOnly(number))
                {
                    throw new Exception("Номер картки повинен містити 16 цифр");
                }
                cardNumber = number;
            }

            public void SetOwnerName(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("ПІБ власника не може бути пустим");
                }
                ownerName = name;
            }

            public void SetCVC(string cvcNumber)
            {
                if (string.IsNullOrEmpty(cvcNumber) || cvcNumber.Length != 3 || !IsDigitsOnly(cvcNumber))
                {
                    throw new Exception("CVC код повинен містити 3 цифри");
                }
                cvc = cvcNumber;
            }

            public void SetExpirationDate(DateTime date)
            {
                if (date < DateTime.Now)
                {
                    throw new Exception("Дата закінчення терміну дії не може бути в минулому");
                }
                expirationDate = date;
            }

            private bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            public void PrintCardInfo()
            {
                Console.WriteLine($"Номер картки: ****{cardNumber.Substring(12)}");
                Console.WriteLine($"Власник: {ownerName}");
                Console.WriteLine($"Термін дії: {expirationDate:MM/yy}");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                {
                    try
                    {
                        CreditCard card = new CreditCard(
                            "1234567890123456",     
                            "Іванов Іван",           
                            "123",                   
                            new DateTime(2025, 12, 1) 
                        );

                        card.PrintCardInfo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка: {ex.Message}");
                    }
                }
            }
        }
    }
}
