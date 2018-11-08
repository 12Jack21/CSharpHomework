using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单等功能。
//要求：
//（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
//（2）主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
//（3）尽量通过数据绑定来实现功能。 注：订单明细可以设置DataMember来绑定


namespace OrderSpace
{
    public class OrderService
    {
        List<Order> orders;

        public List<Order> Orders { get => orders; set => orders = value; }

        public OrderService()
        {
            orders = new List<Order>();
        }

        //添加订单
        public void addOrder(Order order)
        {
            if (!orders.Contains(order))
            {
                orders.Add(order);
            }
            else
            {
                throw new Exception("The order is already exist!!!");
            }
        }

        //删除订单
        public void removeOrder(List<Order> delOrders)
        {
            Order delOrder = delOrders[0];
            if (orders.Contains(delOrder))
            {
                orders.Remove(delOrder);
            }
            else
            {
                throw new Exception("The order is not exist!!!");
            }
        }
        //查询订单
        public List<Order> searchOrderByCus(string customer)
        {
            var query = orders.Where(o => o.Customer == customer);
            return query.ToList();
        }
        public List<Order> searchOrderByID(string id)
        {
            var query = orders.Where(o => o.OrderID == id);
            return query.ToList();
        }
        public List<Order> searchOrderHtPrice(double price)
        {
            var query = orders.Where(o => o.TotPrice > price);
            return query.ToList();
        }
        //更新订单
        public void updateOrder(string oldcCus,string newCus)
        {
            List<Order> orders = searchOrderByCus(oldcCus);
            if(orders.Count != 0)
            {
                orders[0].update(newCus);
            }
            else
            {
                throw new Exception("update failed!!!");
            }
        }
        //显示所有订单
        public void showAllOrders()
        {
            foreach (Order order in Orders)
            {
                order.showOrder();
            }
        }

        //将订单导入XML文件
        public void Export(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                xmlSerializer.Serialize(fs, Orders);
                fs.Close();
                Console.WriteLine("Export to XML file succeed!!!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Export failed, exception: " + e.Message);
            }
        }

        //从XML文件载入订单
        public void Import(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                Orders = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("Import succeed!!!\n");
                showAllOrders();
            }
            catch (Exception e)
            {
                Console.WriteLine("Import failed, exception: " + e.Message);
            }
        }

    }

}
