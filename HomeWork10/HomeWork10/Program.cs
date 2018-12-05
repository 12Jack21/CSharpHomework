using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStruc
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService myService = new OrderService();
            //orderService.Delete("001");

            Customer xiaoming = new Customer("Xiaoming", "13457783400");
            Customer lihua = new Customer("Lihua", "18790025482");
            Customer sam = new Customer("Sam", "15989970031");

            List<OrderDetail> details1 = new List<OrderDetail>() {
                new OrderDetail("apple", 10.0, 20),
                new OrderDetail("egg", 2.0, 100),
                new OrderDetail("water",3.2,10),
                new OrderDetail("milk",4.76,100)
            };
            List<OrderDetail> details2 = new List<OrderDetail>() {
                new OrderDetail("ball", 29.0, 1),
                new OrderDetail("book", 54.7, 2)
            };
            List<OrderDetail> details3 = new List<OrderDetail>() {
                new OrderDetail("bag", 100.3, 2),
                new OrderDetail("shoe", 1423.5, 4),
                new OrderDetail("chair",45.1,10),
                new OrderDetail("telephone",1020,34)
            };

            Order order1 = new Order(xiaoming, details1);
            Order order2 = new Order(lihua, details2);
            Order order3 = new Order(sam, details3);

            myService.Add(order1);
            myService.Add(order2);
            myService.Add(order3);
        }
    }
}
