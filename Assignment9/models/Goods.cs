using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class Goods
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        private int Price {  get; set; }
        public Goods() { }
        public Goods(int id, string name, int price)
        {
            Id = id;
            Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return "商品ID为" + Id + "，商品名称为" + Name + "，商品价格为" + Price;
        }
        public override bool Equals(object obj)
        {
            Goods gd = obj as Goods;
            return Id == gd.Id && Name == gd.Name && Price == gd.Price;
        }
    }
}
