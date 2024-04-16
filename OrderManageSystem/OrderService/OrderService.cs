using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class OrderService
    {
        private OrderDbContext dbContext;

        public OrderService()
        {
            dbContext = new OrderDbContext();
        }

        public List<Order> GetAllOrders()
        {
            return dbContext.Orders.ToList();
        }

        public Order GetOrder(int id)
        {
            return dbContext.Orders.Find(id);
        }

        public void AddOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public void RemoveOrder(int orderId)
        {
            var order = dbContext.Orders.Find(orderId);
            if (order != null)
            {
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            return dbContext.Orders
                .Where(order => order.Details.Any(item => item.GoodsName == goodsName))
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return dbContext.Orders
                .Where(order => order.Customer.Name == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public void UpdateOrder(Order newOrder)
        {
            var oldOrder = dbContext.Orders.Find(newOrder.OrderId);
            if (oldOrder == null)
                throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");

            // 更新订单属性
            oldOrder.Customer = newOrder.Customer;
            oldOrder.CreateTime = newOrder.CreateTime;
            dbContext.SaveChanges();
        }


        public void Export(string fileName)
        {
            var orders = dbContext.Orders.ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> importedOrders = (List<Order>)serializer.Deserialize(fs);
                importedOrders.ForEach(order =>
                {
                    if (!dbContext.Orders.Any(o => o.OrderId == order.OrderId))
                    {
                        dbContext.Orders.Add(order);
                    }
                });
                dbContext.SaveChanges();
            }
        }

        public object QueryByTotalAmount(float amount)
        {
            return dbContext.Orders
               .Where(order => order.TotalPrice >= amount)
               .OrderByDescending(o => o.TotalPrice)
               .ToList();
        }
    }
}
