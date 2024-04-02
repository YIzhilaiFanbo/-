using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManageSystem
{
    internal class Good
    {
        public string name;
        public int price;
        public Good(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Name: {name}, Price: {price}";
        }
    }
}
