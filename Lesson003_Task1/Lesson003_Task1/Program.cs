using System;
using System.Linq.Expressions;

namespace Lesson003_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число від 1 до 5");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    {
                        string goods = "Товар 1";
                        var price = 213.4;
                        Console.WriteLine($"Назва товару: {goods} \nЦіна: {price}");
                        break;
                    }
                case "2":
                    {
                        string goods = "Товар 2";
                        var price = 21;
                        Console.WriteLine($"Назва товару: {goods} \nЦіна: {price}");
                        break;
                    }
                case "3":
                    {
                        string goods = "Товар 3";
                        var price = 324;
                        Console.WriteLine($"Назва товару: {goods} \nЦіна: {price}");
                        break;
                    }
                case "4":
                    {
                        string goods = "Товар 4";
                        var price = 13.7;
                        Console.WriteLine($"Назва товару: {goods} \nЦіна: {price}");
                        break;
                    }
                case "5":
                    {
                        string goods = "Товар 5";
                        var price = 85.2;
                        Console.WriteLine($"Назва товару: {goods} \nЦіна: {price}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ви ввели невірний номер товару!");
                        break;
                    }

            }                

        }
    }
}
