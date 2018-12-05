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

        private static int num = 0;
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
