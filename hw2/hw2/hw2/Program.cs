using System;
using Modul2hw2;

namespace Hw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var menu = new Modul2hw2.Menucs();
            var appleMenu = menu.Catalog;
            menu.Print();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("How many positions will you buy goods?");
            var index = Console.ReadLine();
            var result = int.TryParse(index, out var number);
            if (result == false)
            {
                Console.WriteLine("The program will not start executing until a number is entered.Incorrect data entry.");
            }

            var newArr = new int[number];
            try
            {
                for (var i = 0; i < newArr.Length; i++)
                {
                    Console.WriteLine("Choose the product number");
                    newArr[i] = int.Parse(Console.ReadLine());
                }

                var cart = new Cartcs();
                var prodOrd = cart.Add(ref appleMenu, ref newArr);
                var name = string.Empty;
                var secondName = string.Empty;
                Console.WriteLine("Would you like to place an order?");
                var ord = Console.ReadLine();
                if (ord == "yes" || ord == "Yes" || ord == "да" || ord == "Да")
                {
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your lastname");
                    secondName = Console.ReadLine();
                    var orderProdukt = new ProductOrder();
                    orderProdukt.Order(prodOrd, name, secondName);
                }
                else
                {
                    Console.WriteLine("The order was not issued");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The program will not start executing until a number is entered.");
            }
        }
    }
}
