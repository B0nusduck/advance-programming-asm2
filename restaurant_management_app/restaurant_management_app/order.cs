using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class order
    {
        public int ID { get; protected set; }
        public table table { get; protected set; }
        public food food { get; protected set; }
        public int ammount { get; protected set; }

        public order(int ID, table table, food food, int ammount)
        {
            this.ID = ID;
            this.table = table;
            this.food = food;
            this.ammount = ammount;
        }
        public string toString()
        {
            return "\n-order id: " + ID + "\n-table info:" + table.toString() + "\n-food ordered: " + food.name + "\n-ordered ammount: " + ammount;
        }
    }
}
