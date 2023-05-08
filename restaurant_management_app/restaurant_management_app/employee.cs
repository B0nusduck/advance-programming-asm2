using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class employee
    {
        public int ID { get; protected set; }
        public string name { get; protected set; }
        public order order { get; set; }
        public void infoInput()
        {
            Console.Write("input employee id: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("input employee name: ");
            name = Console.ReadLine();
        }
        public void assignOrder(order order)
        {
            this.order = order;
        }
        public void finishOrder()
        {
            order = null;
        }
        public string toString()
        {
            if (order == null)
            {
                return "\n-employee id: " + ID + "\n-employee name: " + name;
            }
            else
            {
                return "\n-employee id: " + ID + "\n-employee name: " + name + "\n-assigned order:\n" + order.toString();
            }
        }
    }
}
