using System;

namespace Project
{
    class Program
    {
        static void Main() 
        {
            // Задача 1
            /* 
            Програма, яка розподіляє обов'язки членів сім'ї.
            Є батько, мама, син, дочка. Кожним  з них присвоєнна змінна, в якій сховане їхнє ім'я.
            Перевірте, чи працюють всі case-мітки, міняючи значення змінної.
            */
            string fatherName = "David";
            string motherName = "Emma";
            string sonName = "Jhonatan";
            string daughtername = "Thelicia";

            switch (sonName)
            {
                case "David":
                    System.Console.WriteLine("Батько має йти на роботу");
                    break;
                case "Emma":
                    System.Console.WriteLine("Матір має йти за покупками");
                    break;
                case "Jhonatan":
                    System.Console.WriteLine("Син має йти в школу");
                    break;
                case "Thelicia":
                    System.Console.WriteLine("Целісія має лягати спати");
                    break;
            }

            // Задача 2
            /*
            Створіть змінну цілочисельного типу. Якщо її значення рівне 1 - виведіть любе повідомлення. 
            Якщо 2 - виведіть любе повідомлення. Якщо 3 - виведіть любе повідомлення.
            Якщо 4 - виведіть любе повідомленняю
            Якщо любе інше значення - виведіть "Некоректне число".
            */
            int number = 0;

            switch (number)
            {
                case 1:
                System.Console.WriteLine("Number = 1");
                    break;
                case 2:
                    System.Console.WriteLine("Number = 2");
                    break;
                case 3:
                    System.Console.WriteLine("Number = 3");
                    break;
                case 4:
                    System.Console.WriteLine("Number = 4");
                    break;
                default:
                System.Console.WriteLine("Некоректне число");
                    break;
            }
        }
    }
}