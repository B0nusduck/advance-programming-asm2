using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class table_manage
    {
        private static List<table> tableList = new List<table>();
        public void addTable()
        {
            table table = new table();
            table.infoInput();
            tableList.Add(table);
        }
        public void removeTable()
        {
            Console.Write("input table id for removal: ");
            int removeID = int.Parse(Console.ReadLine());
            table removedTable = tableList.Where(table => table.ID == removeID).FirstOrDefault();
            tableList.Remove(removedTable);
        }
        public table getTableByID(int ID)
        {
            return tableList.Where(table => table.ID == ID).FirstOrDefault();
        }
        public void showTable()
        {
            Console.WriteLine("table list:");
            tableList.ForEach(table => Console.WriteLine(table.toString()));
        }
        public void tableMenu()
        {
            Console.Clear();
            Console.Write("select your table: table ");
            int input = int.Parse(Console.ReadLine());
            table currentTable = getTableByID(input);
            if (currentTable != null)
            {
                bool exit = false;
                food_manage food = new food_manage();
                order_manage order = new order_manage();
                do
                {
                    Console.Clear();
                    Console.WriteLine("customer options");
                    Console.WriteLine("1)view food menu.");
                    Console.WriteLine("2)make order.");
                    Console.WriteLine("3)exit customer menu");
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.KeyChar)
                    {
                        case '1':
                            {
                                Console.Clear();
                                food.showFood();
                                Console.ReadKey();
                            }
                            break;
                        case '2':
                            {
                                Console.Clear();
                                Console.Write("-input the ID of the food you want to order: ");
                                int ID = int.Parse(Console.ReadLine());
                                Console.Write("\n-input the ammount you want to order: ");
                                int ammount = int.Parse(Console.ReadLine());
                                order.createOrder(currentTable,food.getFoodByID(ID),ammount);
                                Console.ReadKey();
                            }
                            break;
                        case '3':
                            exit = true;
                            break;
                        default:
                            break;
                    }
                } while (exit == false);
            }
            else
            {
                Console.Write("table not found! try again");
                Console.ReadKey();
            }
        }
    }
}
