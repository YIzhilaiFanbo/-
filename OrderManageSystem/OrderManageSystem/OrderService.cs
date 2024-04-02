using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManageSystem
{
    internal class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void CreateOrder(Customer customer, List<OrderDetails> orderDetails)
        {
            Order order = new Order(orderDetails, customer);
            orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            if (!orders.Contains(order))
            {
                throw new InvalidOperationException("Order does not exist.");
            }
            orders.Remove(order);
        }

        public void ChangeOrder(Order order, List<OrderDetails> newDetails)
        {
            if (!orders.Contains(order))
            {
                throw new InvalidOperationException("Order does not exist.");
            }
            order.Details.Clear();
            foreach (var detail in newDetails)
            {
                order.AddOrderDetail(detail);
            }
        }

        public List<Order> SearchOrderByOrderId(int orderId)
        {
            return orders.Where(o => o.OrderId == orderId).ToList();
        }

        public List<Order> SearchOrderByGoodName(string goodName)
        {
            return orders.Where(o => o.Details.Any(d => d.good.name == goodName)).ToList();
        }

        public List<Order> SearchOrderByCustomer(string customerName)
        {
            return orders.Where(o => o.Customer.Name == customerName).ToList();
        }

        public List<Order> SearchOrderByAmountRange(double minAmount, double maxAmount)
        {
            return orders.Where(o => o.Details.Sum(d => d.Amount) >= minAmount && o.Details.Sum(d => d.Amount) <= maxAmount).ToList();
        }
        public List<Order> SortOrderByOrderId()
        {
            return orders.OrderBy(o => o.OrderId).ToList();
        }

        public List<Order> CustomSortOrders(Func<Order, Order, int> comparer)
        {
            return orders.OrderBy(o => o, new ComparisonComparer<Order>(comparer)).ToList();
        }

        private class ComparisonComparer<T> : IComparer<T>
        {
            private readonly Func<T, T, int> _comparison;

            public ComparisonComparer(Func<T, T, int> comparison)
            {
                _comparison = comparison;
            }

            public int Compare(T x, T y)
            {
                return _comparison(x, y);
            }
        }
    }
}
