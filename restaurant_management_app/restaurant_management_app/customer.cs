using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class customer
    {
        public string name { get; private set; }

        public void infoInput()
        {
            Console.WriteLine("\n-input customer name: ");
            name = Console.ReadLine();
        }
        public string toString()
        {
            return "\n-customer name" + name;
        }
    }
}
