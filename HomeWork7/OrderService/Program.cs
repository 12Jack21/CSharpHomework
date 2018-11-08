using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSpace
{

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
                        catch (Exception e)
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
