using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Customer
    {
        public string Id;
        public string Name;
         Customer() { }
        public Customer(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return "客户ID为" + Id + "，客户名为" + Name;
        }
        public override bool Equals(object obj)
        {
            Customer cs = obj as Customer;
            return this.Id == cs.Id && this.Name == cs.Name;
        }
    }
}
