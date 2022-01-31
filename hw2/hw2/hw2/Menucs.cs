using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2hw2
{
    public class Menucs
    {
         public Product[] Catalog = new Product[]
         {
                new Product { Price = 27510, Name = "Iphone 13" },
                new Product { Price = 40000, Name = "Iphone 13 Pro" },
                new Product { Price = 45000, Name = "Iphone 13 Pro Max" },
                new Product { Price = 20000, Name = "Iphone 12" },
                new Product { Price = 25000, Name = "Iphone 12 Pro" },
                new Product { Price = 30000, Name = "Iphone 12 Pro Max" },
                new Product { Price = 15000, Name = "Iphone 11" },
                new Product { Price = 17000, Name = "Iphone 11 Pro" },
                new Product { Price = 20000, Name = "Iphone 11 Pro Max" },
                new Product { Price = 12000, Name = "Iphone X" },
                new Product { Price = 14000, Name = "Iphone XS" },
                new Product { Price = 13000, Name = "Iphone Xr" },
                new Product { Price = 8000, Name = "Iphone 8" },
                new Product { Price = 9000, Name = "Iphone 8 Plus" },
                new Product { Price = 12000, Name = "Iphone SE 2" },
                new Product { Price = 5000, Name = "Iphone SE" },
                new Product { Price = 5000, Name = "Iphone 7" },
                new Product { Price = 6000, Name = "Iphone 7 Plus" },
                new Product { Price = 7000, Name = "IPad Pro 1" },
                new Product { Price = 8000, Name = "IPad Pr0 2" },
                new Product { Price = 16000, Name = "IPad Pro 3" },
                new Product { Price = 30000, Name = "IPad Pro 4" },
                new Product { Price = 40000, Name = "IPad mini 2" },
                new Product { Price = 10000, Name = "IPad mini 3" },
                new Product { Price = 11000, Name = "IPaad mini 4" },
                new Product { Price = 3000, Name = "Air Pods" },
                new Product { Price = 4000, Name = "Air Pods 2 " },
                new Product { Price = 6000, Name = "Air Pods Pro" },
                new Product { Price = 2000, Name = "Apple Watch 1" },
                new Product { Price = 3000, Name = "Apple Watch 2" },
                new Product { Price = 4000, Name = "Apple Watch 3" },
                new Product { Price = 5000, Name = "Apple Watch 4" },
                new Product { Price = 10000, Name = "Apple Watch 5" },
                new Product { Price = 15000, Name = "Apple Watch 6" },
                new Product { Price = 10000, Name = "Apple Watch SE" },
                new Product { Price = 10000, Name = "MacBook Air 1" },
                new Product { Price = 12000, Name = "MacBook Air 2" },
                new Product { Price = 15000, Name = "MacBook Air 4" },
                new Product { Price = 20000, Name = "MacBook Air 3" },
                new Product { Price = 13000, Name = "MacBook Pro" },
                new Product { Price = 20000, Name = "MacBook Pro 2" },
                new Product { Price = 25000, Name = "MacBook Pro 3" },
                new Product { Price = 30000, Name = "MacBook Pro 4" },
                new Product { Price = 60000, Name = "MacBook Pro 5" },
         };

         private int _j = 0;
         public void Print()
        {
            foreach (var item in Catalog)
            {
                Console.WriteLine($"{_j++})Name-{item.Name}, Price-{item.Price} UAH");
            }
        }
    }
}
