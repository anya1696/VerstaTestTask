using System.Collections.Generic;
using System.Linq;

namespace SampleMVCApps.Models
{
    public class OrderStorage
    {
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            using (var db = new OrderContext())
            {
                orders = db.Orders.ToList();
            }
            return orders;
        }

        public void SaveOrder(Order order)
        {
            using (var db = new OrderContext())
            {
                db.Add(order);
                db.SaveChanges();
            }
        }
    }
}
