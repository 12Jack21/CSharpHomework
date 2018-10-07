using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


/*2、写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、
  查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
提示：需要写Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，
订单数据可以保存在OrderService中一个List中。

 订单中有很多条目，每个订单明细就是一个条目，一个条目包括商品名称，数量和价格
     */

namespace OrderManage
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
        public void addDetail(OrderDetail detail)
        {
            orderDatas.Add(detail);
        }
        public void showOrder()
        {
            Console.WriteLine("OrderID\t" + orderID);
            Console.WriteLine("Customer\t" + customer);
            foreach (OrderDetail detail in orderDatas)
            {
                Console.WriteLine("Name\t" + detail.Name + "\t" + " Amount\t" + detail.Amount + "\t" + " Price\t" + detail.Price);
            }
            Console.WriteLine("\t\t");
        }
        public void modifyOrder()
        {
            Console.WriteLine("input the good's name you want to modify");
            try
            {
                string goodName = Console.ReadLine();
                //int index = orderDatas.FindIndex((new DetailsPredicate()).FindName);

                OrderDetail findDetail = orderDatas.Find((new DetailsPredicate(goodName)).FindName);
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
    class DetailsPredicate
    {
        private string name;
        private int amount;
        private double price;

        public DetailsPredicate(string name)
        {
            this.name = name;
        }
        public bool FindName(OrderDetail detail)
        {
            return this.name == detail.Name;
        }
        public bool FindAmount(OrderDetail detail)
        {
            return this.amount == detail.Amount;
        }
        public bool FindPrice(OrderDetail detail)
        {
            return this.price == detail.Price;
        }
    }
    //查找的谓词类
    class OrderPredicate
    {
        private string orderID;
        private string customer;

        public OrderPredicate(string orderID, string customer)
        {
            this.orderID = orderID;
            this.customer = customer;
        }
        public bool FindOrderID(Order order)
        {
            return this.orderID == order.OrderID;
        }
        public bool FindCustomer(Order order)
        {
            return this.customer == order.Customer;
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
                    orders.Remove(findCustomer(customerName));
                    Console.WriteLine("the Order has been deleted");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Delete failed, exception message: " + e.Message);
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
            Console.WriteLine("1.searchByID  2.searchByCustomer ");
            Order findOrder = null;
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
                    findOrder = findOrderByID(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("input the customer's name");
                    findOrder = findCustomer(Console.ReadLine());
                    break;
            }
            Console.WriteLine("The order you want is :\n");
            findOrder.showOrder();
        }
        public Order findOrderByID(string orderID)
        {
            Predicate<Order> predicate = new OrderPredicate(orderID, "").FindCustomer;
            return orders.Find((new OrderPredicate(orderID, "")).FindOrderID);
        }
        public Order findCustomer(string customer)
        {
            Predicate<Order> predicate = new OrderPredicate("", customer).FindCustomer;
            return orders.Find(predicate);
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
        public  void modifyOrder()
        {
            Console.WriteLine("input the customer's name of the Order you want to modify");
            try
            {
                string customersName = Console.ReadLine();
                Order findOrder_ = findCustomer(customersName);
                findOrder_.modifyOrder();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception message :" + e.Message);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
           bool run = true;
           OrderService myService = new OrderService();
           while(run)
            {
                int tag = 0;
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("OrderService (1.addOrder   2.deleteOrder   3.modifyOrder   4.searchOrder   5.exit)");
                try
                {
                    tag = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("input wrong, exception:" + e.Message);
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
