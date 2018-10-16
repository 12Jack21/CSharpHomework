using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//作业要求：1、对上次作业的订单程序，使用LINQ语句，（1）实现按照商品名称、客户等字段查询订单的功能;（2） 查询订单金额大于1万元的订单。

//第(2)个要求放在查询订单（searchOrder）中
 

namespace Program1
{
    class Order
    {
        List<OrderDetail> orderDatas;
        private string orderID;
        private string customer;
        public string OrderID { get => orderID; set => orderID = value; }
        public string Customer { get => customer; set => customer = value; }

        public Order(string customer)
        {
            orderDatas = new List<OrderDetail>();
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
            foreach(var n in orderDatas)
            {
                sum += n.Amount * n.Price;
            }
            return sum;
        }
        public void addDetail(OrderDetail detail)
        {
            orderDatas.Add(detail);
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
            foreach (OrderDetail detail in orderDatas)
            {
                Console.WriteLine(detail.Name + "\t\t" + detail.Amount + "\t\t" + detail.Price);
            }
            Console.WriteLine("-------------------------------------\n\n");
        }
        public void modifyOrder()
        {
            Console.WriteLine("input the good's name you want to modify");
            try
            {
                string goodName = Console.ReadLine();
                //Linq查询
                var findDetail = orderDatas.Where(n => n.Name == goodName).First();
                Console.WriteLine("input the new detail (Name,Amount,Price)");
                string _name = Console.ReadLine();
                int _amount = Convert.ToInt32(Console.ReadLine());
                double _price = Convert.ToDouble(Console.ReadLine());
                findDetail.Name = _name;
                findDetail.Amount = _amount;
                findDetail.Price = _price;
                Console.WriteLine("modeify succeed!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class OrderDetail
    {
        private string name;
        private int amount;
        private double price;
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public double Price { get => price; set => price = value; }

        public OrderDetail(string name, int amount, double price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
        }
    }

    class OrderService
    {
        List<Order> orders;
        public OrderService()
        {
            orders = new List<Order>();
        }
        //添加订单
        public void addOrder()
        {
            Console.WriteLine("input the customer's name");
            string customer = Console.ReadLine();
            Order newOrder = new Order(customer);
            try
            {
                orders.Add(newOrder);
                //Console.WriteLine("the Order has been added");
            }
            catch (Exception e)
            {
                Console.WriteLine("Add failed, exception message: " + e.Message);
            }

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
            Console.WriteLine("input the OrderDetails (GoodName,Amount,Price)\n");
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
        }

        //删除订单
        public void deleteOrder()
        {
            Console.WriteLine("input the customer's name of the Order you want to delete");
            try
            {
                string customerName = Console.ReadLine();
                try
                {
                    //orders.Remove(findCustomer(customerName));
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

        //查询订单
        public void searchOrder()
        {
            int tag = 0;
            string value = null;
            IEnumerable<Order> findOrder = null;
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
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    findOrder = from n in orders where n.OrderID == value select n;
                    break;
                case 2:
                    Console.WriteLine("input the customer's name");
                    try
                    {
                        value = Console.ReadLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    findOrder = from n in orders where n.Customer == value select n;
                    break;
                case 3:
                    //查找订单总额大于10000元的所有订单
                    findOrder = from n in orders where n.totalPrice() > 10000 select n;
                    break;
            }
            Console.WriteLine("The order you want :\n");
            foreach(var n in findOrder)
            {
                n.showOrder();
            }
        }


        //显示订单
        public void showOrders()
        {
            foreach (Order order in orders)
            {
                order.showOrder();
            }
        }
        //修改订单
        public void modifyOrder()
        {
            Console.WriteLine("input the customer's name of the Order you want to modify");
            try
            {
                string customersName = Console.ReadLine();
                //Linq查询
                var findOrder_ = orders.Where(n=>n.Customer == customersName).First();
                findOrder_.modifyOrder();
            }
            catch (Exception e)
            {
                Console.WriteLine("modify failed!!!");
                Console.WriteLine("exception message :" + e.Message);
            }
        }

    }

    class Program1
    {
        static void Main(string[] args)
        {
            bool run = true;
            OrderService myService = new OrderService();
            while (run)
            {
                int tag = 0;
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("OrderService (1.addOrder   2.deleteOrder   3.modifyOrder   4.searchOrder   5.exit)");
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
                        myService.addOrder();
                        break;
                    case 2:
                        myService.deleteOrder();
                        break;
                    case 3:
                        myService.modifyOrder();
                        break;
                    case 4:
                        myService.searchOrder();
                        break;
                    case 5:
                        run = false;
                        break;

                }
            }
        }
    }


}
