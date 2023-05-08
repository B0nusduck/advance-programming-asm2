using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class table
    {
        public int ID { get; protected set; }
        public void infoInput()
        {
            Console.Write("input table id:");
            ID = int.Parse(Console.ReadLine());
        }
        public string toString()
        {
            return "\n-table ID: " + ID;
        }
    }
}
