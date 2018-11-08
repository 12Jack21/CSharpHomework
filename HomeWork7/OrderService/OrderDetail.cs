using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSpace
{
    public class OrderDetail
    {
        private string name;
        private int amount;
        private double price;
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public double Price { get => price; set => price = value; }

        public OrderDetail() { }
        public OrderDetail(string name, int amount, double price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
        }
        //更新明细数据
        public void updateDetail(int amount, double price)
        {
            this.amount = amount;
            this.price = price;
        }

        public override string ToString()
        {
            return name + "  " + amount + "  " + price;
        }
    }
}
