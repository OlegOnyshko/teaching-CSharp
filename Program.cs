using System;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    class Program
    {
        static void Main() 
        {
            System.Console.WriteLine("введіть число 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("введіть число 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Виберіть операцію");
            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                System.Console.WriteLine("Результат: " + (number1 + number2));
                    break;
                case '-':
                    System.Console.WriteLine("Результат: " + (number1 - number2));
                    break;
                case '*':
                    System.Console.WriteLine("Результат: " + (number1 * number2));
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        Console.WriteLine("Результат: " + (number1 / number2));
                    }
                    else
                    {
                        Console.WriteLine("Ділення на нуль неможливе.");
                    }
                    break;
                default:
                System.Console.WriteLine("Невідома операція");
                    break;
            }

            
        }
    }
}