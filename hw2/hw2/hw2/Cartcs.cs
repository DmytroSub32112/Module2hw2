using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2hw2
{
    public class Cartcs
    {
        private Product[] _products;
        private int _value = 0;
        public Cartcs()
        {
            _products = new Product[1];
        }

        public Product[] Add(ref Product[] produkt, ref int[] arr)
        {
            _products = new Product[arr.Length];
            foreach (var item in arr)
            {
                for (var i = 0; i < produkt.Length; i++)
                {
                    if (item == i)
                    {
                        _products[_value++] = produkt[i];
                    }
                }
            }

            return _products;
        }
    }
}
