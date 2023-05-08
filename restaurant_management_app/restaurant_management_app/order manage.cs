using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class order_manage
    {
        private static List<order> ordersList = new List<order>();
        private static int lastID;
        public void createOrder(table table, food food, int amount)
        {
            if(food != null)
            {
                int newID = ordersList.Any() ? ordersList.Max(o => o.ID) + 1 : lastID + 1;
                lastID = newID;
                order order = new order(newID, table, food, amount);
                ordersList.Add(order);
            }
            else
            {
                Console.WriteLine("the food id you've input don't exist, please try again");
            }
        }
        public void deleteOrder(order order)
        {
            ordersList.Remove(order);
        }
        public order getFirstOrder()
        {
            return ordersList.FirstOrDefault();
        }
        public void showOrder()
        {
            Console.WriteLine("all order available");
            ordersList.ForEach(order => Console.WriteLine(order.toString()));
        }
    }
}
