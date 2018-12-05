using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFStruc
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public OrderDetail()
        {
            //自动累加主键
            //Id = Guid.NewGuid().ToString();
        }

        public static int num;
        //public OrderDetail(string id,string name,double unitPrice,int quantity)
        //{
        //    Id = id;
        //    Name = name;
        //    Quantity = quantity;
        //    UnitPrice = unitPrice;
        //}
        public OrderDetail(string name, double unitPrice, int quantity)
        {
            Id = (++num);
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
