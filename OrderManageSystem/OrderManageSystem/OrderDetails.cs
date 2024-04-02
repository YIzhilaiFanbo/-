using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManageSystem
{
    internal class OrderDetails
    {
        public Good good;
        public int number;
        public double Amount;
        public OrderDetails(Good good, int number) { 
            this.good = good;
            this.number = number;
            this.Amount = good.price*number;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            OrderDetails otherDetail = (OrderDetails)obj;
            return good.name == otherDetail.good.name && number == otherDetail.number;
        }

        public override string ToString()
        {
            return $"Good: {good.name}, Quantity: {number}, Amount: {Amount}";
        }
    }
}
