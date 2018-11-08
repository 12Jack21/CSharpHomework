using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSpace
{
    public class Order
    {
        List<OrderDetail> orderDatas;
        private string orderID;
        private string customer;
        private readonly double totPrice;
        public string OrderID { get => orderID; set => orderID = value; }
        public string Customer { get => customer; set => customer = value; }
        public List<OrderDetail> OrderDatas { get => orderDatas; set => orderDatas = value; }
        public double TotPrice
        {
            get
            {
                double sum = 0;
                foreach (var n in OrderDatas)
                {
                    sum += n.Amount * n.Price;
                }
                return sum;
            }

        }
        private static int num = 0;

        public Order()
        {
            OrderDatas = new List<OrderDetail>();
        }

        public Order(string customer)
        {
            OrderDatas = new List<OrderDetail>();
            //将当前时间转化成订单号
            DateTime date = DateTime.Today;
            orderID = date.Month + "-" + date.Day + "-" + (++num);
            this.customer = customer;
        }

        //增加订单明细项
        public void addDetail(OrderDetail detail)
        {
            if (!orderDatas.Contains(detail))
            {
                OrderDatas.Add(detail);
            }
            else
            {
                throw new Exception("The detail is already Sexist!!!");
            }
        }
        //移除订单明细
        public void removeDetail(OrderDetail detail)
        {
            if (orderDatas.Contains(detail))
            {
                OrderDatas.Remove(detail);
            }
            else
            {
                throw new Exception("The detail is not exist!!!");
            }
        }
        //更新订单
        public void update(string customer)
        {
            this.customer = customer;
        }
        //根据商品名查找明细项
        public OrderDetail searchDetail(string goodName)
        {
            try
            {
                var query = orderDatas.Where(d => d.Name == goodName).First();
                return query;
            }
            catch
            {
                throw new Exception("No such detail !!!");
            }

        }

        public void showOrder()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("OrderID\t\t" + orderID);
            Console.WriteLine("Customer\t" + customer + "\n");
            Console.WriteLine("Total Price: " + TotPrice);
            Console.WriteLine("Goods:");
            Console.WriteLine("--                                 --");
            Console.WriteLine("Name\t\t" + "Amount\t\t" + "Price\t\t");
            foreach (OrderDetail detail in OrderDatas)
            {
                Console.WriteLine(detail);
            }
            Console.WriteLine("-------------------------------------\n");
        }

    }
}
