using System.Collections.Generic;
using System.Linq;

namespace SampleMVCApps.Models
{
    public class OrderHandlerModel
    {
        public List<Order> DataBase
        {
            get
            {
                List<Order> dataBase = new List<Order>();
                using (var db = new OrderingContext())
                {
                    dataBase = db.Orders.ToList();
                }
                return dataBase;
            }
        }
        public void SaveDataToDB(Order data)
        {
            using (var db = new OrderingContext())
            {
                db.Add(data);
                db.SaveChanges();
            }
        }
    }
}
