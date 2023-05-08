using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class food
    {
        public int ID { get; protected set; }
        public string name { get; protected set;}
        public float price { get; protected set; }

        public void infoInput()
        {
            Console.Write("\ninput food id: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("\ninput food name: ");
            name = Console.ReadLine();
            Console.Write("\ninput food price: ");
            price = float.Parse(Console.ReadLine());
        }
        public string toString()
        {
            return "\n-food id: " + ID + "\n-food name: " + name + "\n-food price: " + price;
        }
    }
}
