using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2hw2
{
   public class ProductOrder
    {
        public void Order(Product[] products, string name, string secondName)
        {
            Console.WriteLine("----------------------------------------");
            var random = new Random();
            var price = 0;
            Console.Write($"{name} {secondName},Your order: ");

            foreach (var item in products)
            {
                Console.Write($"{item.Name},");
            }

            Console.WriteLine("In total:");
            for (var i = 0; i < products.Length; i++)
            {
                price += products[i].Price;
            }

            Console.WriteLine(price);
            Console.WriteLine($"Order number:{random.Next(1, 100)}");
        }
    }
}
