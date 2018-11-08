using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Program;

namespace OrderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addTestMethod()
        {
            Order order = new Order();
            order.addDetail(new OrderDetail("wahahha", 24, 5.76));
            List<Order> orderList = new List<Order>();
            orderList.Add(order);

            OrderService ser = new OrderService();
            //添加订单
            ser.addOrder(order);

            CollectionAssert.AreEquivalent(orderList, ser.Orders);
        }

        [TestMethod]
        public void removeTestMethod()
        {
            Order order1 = new Order("xiaoming");
            Order order2 = new Order("lihua");
            order1.addDetail(new OrderDetail("fish", 45, 10.4));
            order2.addDetail(new OrderDetail("bottle", 2, 99.9));
            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);

            OrderService ser = new OrderService();
            ser.Orders = orders;
            List<Order> delOrder = new List<Order>();
            delOrder.Add(order1);
            ser.removeOrder(delOrder);

            Assert.IsTrue(!ser.Orders.Contains(order1) && ser.Orders.Contains(order2));
        }

        [TestMethod]
        public void searchTestMethod()
        {
            Order order1 = new Order("xiaoming");
            Order order2 = new Order("lihua");
            order1.addDetail(new OrderDetail("fish", 45, 10.4));
            order2.addDetail(new OrderDetail("bottle", 2, 99.9));
            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);

            OrderService ser = new OrderService();
            ser.Orders = orders;

            Assert.IsTrue(ser.searchOrderByCus("xiaoming").Contains(order1));
            Assert.IsTrue(ser.searchOrderByID(order2.OrderID).Contains(order2));
            Assert.IsTrue(ser.searchOrderHtPrice(180).Contains(order2) && ser.searchOrderHtPrice(450).Contains(order1));
        }

        //[TestMethod]
        //public void ExportTestMethod()
        //{
        //    Order order1 = new Order("xiaoming");
        //    Order order2 = new Order("lihua");
        //    order1.addDetail(new OrderDetail("cat", 1, 500.6));
        //    order1.addDetail(new OrderDetail("bottle", 23, 3.6));
        //    order2.addDetail(new OrderDetail("sweet", 400, 1.23));
        //    List<Order> orders = new List<Order>();
        //    orders.Add(order1);
        //    orders.Add(order2);

        //    OrderService ser = new OrderService();
        //    ser.Orders = orders;


        //}
    }
}
