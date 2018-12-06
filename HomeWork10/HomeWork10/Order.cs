using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFStruc
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
        public Customer Cus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public double TotPrice
        {
            get
            {
                double sum = 0;
                foreach (var n in OrderDetails)
                {
                    sum += n.Quantity * n.UnitPrice;
                }
                return sum;
            }
            set { }
        }

        public static int num = 0;
        //”年月日+三位流水号”的格式
        public Order(Customer customer,List<OrderDetail> orderDetails)
        {
            //将当前时间转化成订单号
            DateTime date = DateTime.Today;
            //控制流水号格式
            string a = String.Format("{0:d3}", (++num));
            Id = date.Year + "-" + date.Month + "-" + date.Day + "-" + a;
            Cus = customer;
            OrderDetails = orderDetails;
        }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //增加订单明细项
        public void addDetail(OrderDetail detail)
        {
            if (!OrderDetails.Contains(detail))
            {
                OrderDetails.Add(detail);
            }
            else
            {
                throw new Exception("The detail is already Sexist!!!");
            }
        }
        //移除订单明细
        public void removeDetail(OrderDetail detail)
        {
            if (OrderDetails.Contains(detail))
            {
                OrderDetails.Remove(detail);
            }
            else
            {
                throw new Exception("The detail is not exist!!!");
            }
        }
        //更新订单
        public void update(string name, string phoneNum)
        {
            Cus.update(name, phoneNum);
        }
        //根据商品名查找明细项
        public OrderDetail searchDetail(string goodName)
        {
            try
            {
                var query = OrderDetails.Where(d => d.Name == goodName).First();
                return query;
            }
            catch
            {
                throw new Exception("No such detail !!!");
            }

        }
    }
}
