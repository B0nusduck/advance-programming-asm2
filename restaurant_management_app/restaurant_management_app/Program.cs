using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            employee_manage employee = new employee_manage();
            table_manage table = new table_manage();
            do
            {
                Console.Clear();
                Console.WriteLine("select user types or exit app: ");
                Console.WriteLine("1)customer.");
                Console.WriteLine("2)employee.");
                Console.WriteLine("3)close app.");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case '1':
                        {
                            //Console.WriteLine("customer view, work in progress");
                            table.tableMenu();
                        }
                        break;
                    case '2':
                        {
                            //Console.WriteLine("employee view, work in progress");
                            employee.employeeMenu();
                        }
                        break;
                    case '3':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }while (exit == false);
        }
    }
}
