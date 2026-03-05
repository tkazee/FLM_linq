using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLM_linq
{
    public class Product
    {
        private static int _pcodeCounter = 1001;
        public int Pcode { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Product(string pname, int price, int quantity)
        {
            Pcode=_pcodeCounter++;
            Pname = pname;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return "Product Id : "+ Pcode+", Product Name: "+ Pname+", Product cost: "+ Price + ", Available Quntity: "+Quantity;
        }
    }
}
