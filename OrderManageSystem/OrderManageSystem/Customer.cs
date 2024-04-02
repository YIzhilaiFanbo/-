using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManageSystem
{
    internal class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Customer(string name,string phonenumber,string address) { 
            this.Name = name;
            this.PhoneNumber = phonenumber;
            this.Address = address;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Phone Number: {PhoneNumber}, Address: {Address}";
        }
    }
}
