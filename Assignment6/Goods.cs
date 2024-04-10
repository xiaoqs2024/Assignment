using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Goods
    {
        public string Id;
        public string Name;
        public int Price;
        public Goods() { }
        public Goods(string id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "ID:" + Id + "，名称:" + Name + "，价格:" + Price;
        }
        public override bool Equals(object obj)
        {
            Goods gd = obj as Goods;
            return Id == gd.Id && Name == gd.Name && Price == gd.Price;
        }
    }
}
