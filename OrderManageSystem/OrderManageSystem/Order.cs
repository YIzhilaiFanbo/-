using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManageSystem
{
    internal class Order
    {
        public int OrderId { get; set; }

        public static int OrderCount = 0;
        public List<OrderDetails> Details { get; }

        public Customer Customer { get; set; }

        public Order(List<OrderDetails> details,Customer customer) {
            this.Details = details;
            this.Customer = customer;
            this.OrderId=OrderCount+1;
            OrderCount++;
        }
        public void AddOrderDetail(OrderDetails detail)
        {
            Details.Add(detail);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Order otherOrder = (Order)obj;
            return OrderId == otherOrder.OrderId;
        }
        public override string ToString()
        {
            string orderDetailsString = "";
            foreach (var detail in Details)
            {
                orderDetailsString += detail.ToString() + "\n";
            }
            return $"Order ID: {OrderId}, Customer: {Customer.Name}, Details:\n{orderDetailsString}";
        }
    }
}
