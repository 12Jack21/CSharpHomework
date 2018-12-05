using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml.Serialization;

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
        public List<Order> searchOrderByCus(string cusName)
        {
            var query = orders.Where(o => o.Customer.Name == cusName);
            return query.ToList();
        }
        public List<Order> searchOrderByID(string id)
        {
            var query = orders.Where(o => o.OrderID == id);
            return query.ToList();
        }
        public List<Order> searchOrderHtPrice(double price)
        {
            var query = orders.Where(o => o.TotPrice >= price);
            return query.ToList();
        }
        //更新订单
        public void updateOrder(string oldcCusName,string newCusName,string phoneNum)
        {
            List<Order> orders = searchOrderByCus(oldcCusName);
            if(orders.Count != 0)
            {
                orders[0].update(newCusName,phoneNum);
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

        //使用 XSLT 将 XML文件转化成HTML文件
        public void xsltTran(string XMLfile,string XSlTfile,string HTMLfilename)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(XMLfile);
                XPathNavigator xpn = doc.CreateNavigator();
                xpn.MoveToRoot();
                XslCompiledTransform xsl = new XslCompiledTransform();
                xsl.Load(XSlTfile);
                FileStream fs = File.OpenWrite(HTMLfilename);

                XmlTextWriter xw = new XmlTextWriter(fs, Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                XmlWriter xw1 = XmlWriter.Create(fs, xsl.OutputSettings);
                
                xsl.Transform(xpn, null, xw);
                fs.Close();
                //xsl.Transform(xpn, null, xw1);
                Console.WriteLine("Tranform  to HTML succeed!!!");
            }
            catch(XmlException e)
            {
                Console.WriteLine("XmlException: " + e.ToString());
            }
            catch(XsltException e)
            {
                Console.WriteLine("XsltException: " + e.ToString());
            }
        }
    }

}
