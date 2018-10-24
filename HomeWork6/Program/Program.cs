using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//作业要求：1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
//          2、为OrderService类的各个Public方法，编写测试用例，使用合法和非法的输出数据进行测试。


namespace Program
{
    public class Order
    {
        List<OrderDetail> orderDatas;
        private string orderID;
        private string customer;
        public string OrderID { get => orderID; set => orderID = value; }
        public string Customer { get => customer; set => customer = value; }
        public List<OrderDetail> OrderDatas { get => orderDatas; set => orderDatas = value; }

        public Order()
        {
            OrderDatas = new List<OrderDetail>();
        }

        public Order(string customer)
        {
            OrderDatas = new List<OrderDetail>();
            //将当前时间转化成订单号
            DateTime dateTime = DateTime.Now;
            this.orderID = dateTime.DayOfYear.ToString() + dateTime.Hour.ToString() +
                dateTime.Minute.ToString() + dateTime.Second.ToString() + dateTime.Millisecond.ToString();
            this.customer = customer;
        }

        //计算订单总额
        public double totalPrice()
        {
            double sum = 0;
            foreach (var n in OrderDatas)
            {
                sum += n.Amount * n.Price;
            }
            return sum;
        }
        //增加订单明细项
        public void addDetail(OrderDetail detail)
        {
            if(!orderDatas.Contains(detail))
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
            if(orderDatas.Contains(detail))
            {
                OrderDatas.Remove(detail);
            }
            else
            {
                throw new Exception("The detail is not exist!!!");
            }
        }
        //根据商品名查找明细项
        public OrderDetail searchDetail(string goodName)
        {
            var query = orderDatas.Where(d => d.Name == goodName).First();
            if(query == null)
            {
                Console.WriteLine("there is no such detail !!!");
                return null;
            }
            else
            {
                return query;
            }
        }

        public void showOrder()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("OrderID\t\t" + orderID);
            Console.WriteLine("Customer\t" + customer + "\n");
            Console.WriteLine("Total Price: " + totalPrice());
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
        public void updateDetail(int amount,double price)
        {
            this.amount = amount;
            this.price = price;
        }

        public override string ToString()
        {
            return name + "  " + amount + "  " + price;
        }
    }

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
            if(!orders.Contains(order))
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
            if(orders.Contains(delOrder))
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
            var query = orders.Where(o => o.totalPrice() > price);
            return query.ToList();
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
            catch(Exception e)
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
            catch(Exception e)
            {
                Console.WriteLine("Import failed, exception: " + e.Message);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            startService();
        }

        private static void addOrder(OrderService ser)
        {
            Console.WriteLine("input the customer's name");
            string customer = Console.ReadLine();
            Order newOrder = new Order(customer);          
            //添加订单明细
            Console.WriteLine("input the amount of the Orderdetails");
            int amountOfDetails = 0;
            try
            {
                amountOfDetails = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("input the OrderDetails (GoodName,Amount,Price)");
            for (int i = 0; i < amountOfDetails; i++)
            {
                try
                {
                    string name = Console.ReadLine();
                    int amount = Convert.ToInt32(Console.ReadLine());
                    double price = Convert.ToDouble(Console.ReadLine());
                    newOrder.addDetail(new OrderDetail(name, amount, price));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            ser.addOrder(newOrder);
        }

        private static void deleteOrder(OrderService ser)
        {
            Console.WriteLine("input the customer's name of the Order you want to delete");
            try
            {
                string customerName = Console.ReadLine();
                try
                {
                    ser.removeOrder(ser.searchOrderByCus(customerName));
                    Console.WriteLine("the Order has been deleted");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Delete failed!!!");
                    Console.WriteLine("exception message: " + e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void searchOrder(OrderService ser)
        {
            int tag = 0;
            string value = null;
            List<Order> findOrder = null;
            Console.WriteLine("1.searchByID   2.searchByCustomer 3.searchOrder(Excess10000yuan)");
            try
            {
                tag = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            switch (tag)
            {
                case 1:
                    Console.WriteLine("input the OrderID");
                    try
                    {
                        value = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    findOrder = ser.searchOrderByID(value);  
                    break;
                case 2:
                    Console.WriteLine("input the customer's name");
                    try
                    {
                        value = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    findOrder = ser.searchOrderByCus(value).ToList();
                    break;
                case 3:
                    //查找订单总额大于10000元的所有订单
                    findOrder = ser.searchOrderHtPrice(10000);
                    break;
            }
            Console.WriteLine("The order you want :");
            foreach (var n in findOrder)
            {
                n.showOrder();
            }
        }

        private static void modifyOrder(OrderService ser)
        {
            Console.WriteLine("input the customer's name of the order and the good's name of the OrderDetail you want to modify");
            try
            {
                string customer = Console.ReadLine();
                string goodName = Console.ReadLine();

                OrderDetail detail = ser.searchOrderByCus(customer).First().searchDetail(goodName);

                Console.WriteLine("input the new detail (Amount,Price)");
                int _amount = Convert.ToInt32(Console.ReadLine());
                double _price = Convert.ToDouble(Console.ReadLine());
                //更新订单明细
                detail.updateDetail(_amount, _price);
                Console.WriteLine("modeify succeed!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void startService()
        {
            bool run = true;
            OrderService myService = new OrderService();
            while (run)
            {
                int tag = 0;
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("OrderService (1.addOrder 2.deleteOrder 3.modifyOrder 4.searchOrder 5.Export 6.Import 7.Exit)");
                try
                {
                    tag = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("exception:" + e.Message);
                    Console.WriteLine("Please enter number range from 1 to 5");
                }
                switch (tag)
                {
                    case 1:
                        addOrder(myService);
                        break;
                    case 2:
                        deleteOrder(myService);
                        break;
                    case 3:
                        modifyOrder(myService);
                        break;
                    case 4:
                        searchOrder(myService);
                        break;
                    case 5:
                        Console.WriteLine("Input the name of the XML file (Without extension):");
                        try
                        {
                            string filename = Console.ReadLine();
                            myService.Export(filename + ".xml");
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 6:
                        myService.Import("Order.xml");
                        break;
                    case 7:
                        run = false;
                        break;

                }
            }
        }
    }
}
