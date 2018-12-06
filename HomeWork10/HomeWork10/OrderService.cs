using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFStruc
{
    public class OrderService
    {
        public void Add(Order order)
        {
            using (var db = new OrderDB())
            {
                
                db.Order.Add(order);
                //db.Order.Attach(order);
                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(String orderId)
        {
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("OrderDetails").SingleOrDefault(o => o.Id == orderId);
                db.OrderDetail.RemoveRange(order.OrderDetails);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }
        //在数据库里存在的内容上进行修改
        public void Update(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.OrderDetails.ForEach(
                    detail => db.Entry(detail).State = EntityState.Modified);
                db.SaveChanges();
            }
        }
        public void UpdateOr(Order order)
        {
            using (var db = new OrderDB())
            {
                db.OrderDetail.RemoveRange(order.OrderDetails);
                db.Order.Remove(order);
                db.Order.Add(order);
                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public Order GetOrder(String Id)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderDetails").
                  SingleOrDefault(o => o.Id == Id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderDetails").ToList<Order>();
            }
        }


        public List<Order> QueryByCustormer(String cusName)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderDetails")
                  .Where(o => o.Cus.Name == cusName).ToList<Order>();
            }
        }

        public List<Order> QueryByGoods(String productName)
        {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("OrderDetails")
                  .Where(o => o.OrderDetails.Where(
                    detail => detail.Name.Equals(productName)).Count() > 0);
                return query.ToList<Order>();
            }
        }

        public List<Order> QueryAbovePrice(double price)
        {
            using(var db = new OrderDB())
            {
                var query = db.Order.Include("OrderDetails")
                    .Where(o => o.TotPrice >= price);
                return query.ToList<Order>();
            }
        }
    }
}
