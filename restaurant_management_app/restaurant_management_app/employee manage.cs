using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace restaurant_management_app
{
    internal class employee_manage
    {
        private List<employee> employeeList;
        public employee_manage()
        {
            employeeList = new List<employee>();
        }
        public void addEmployee()
        {
            employee employee = new employee();
            employee.infoInput();
            employeeList.Add(employee);
        }
        public employee searchEmployeeByID()
        {
            Console.Write("\ninput employee id: ");
            int searchID = int.Parse(Console.ReadLine());
            employee result = employeeList.Where(employee => employee.ID == searchID).FirstOrDefault();
            return result;
        }
        public void employeeMenu()
        {
            bool exit = false;
            int page = 1;
            table_manage table = new table_manage();
            order_manage order = new order_manage();
            food_manage food = new food_manage();
            do
            {
                Console.Clear();
                switch (page)
                {
                    
                    //menu page 1
                    case 1:
                        {
                            Console.WriteLine("--employee menu page 1--");
                            Console.WriteLine("1)add employee.");
                            Console.WriteLine("2)view employee list.");
                            Console.WriteLine("3)search employee.");
                            Console.WriteLine("4)assign order.");
                            Console.WriteLine("5)finish order.");
                            Console.WriteLine("6)show table list.");
                            Console.WriteLine("7)add table.");
                            Console.WriteLine("8)delete table.");
                            Console.WriteLine("9)next page.");
                            Console.WriteLine("0)exit employee menu.");
                            ConsoleKeyInfo key = Console.ReadKey();
                            switch (key.KeyChar)
                            {
                                case '1':
                                    {
                                        Console.Clear();
                                        addEmployee();
                                    }
                                    break;
                                case '2':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("employee list");
                                        employeeList.ForEach(employee => Console.WriteLine(employee.toString()));
                                        Console.ReadKey();
                                    }
                                    break;
                                case '3':
                                    {
                                        Console.Clear();
                                        Console.WriteLine(searchEmployeeByID().toString());
                                        Console.ReadKey();
                                    }
                                    break;
                                case '4':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("input employee ID for order assignment: ");
                                        int ID = int.Parse(Console.ReadLine());
                                        employee assignedEmployee = employeeList.Where(employee => employee.ID == ID).FirstOrDefault();
                                        if(assignedEmployee.order == null)
                                        {
                                            assignedEmployee.assignOrder(order.getFirstOrder());
                                            Console.WriteLine($"order number {order.getFirstOrder().ID} has been assigned to {assignedEmployee.name}");
                                            order.deleteOrder(order.getFirstOrder());
                                        }
                                        else
                                        {
                                            Console.WriteLine("employee already has an order");
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                                case '5':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("input employee ID for order assignment: ");
                                        int ID = int.Parse(Console.ReadLine());
                                        employee assignedEmployee = employeeList.Where(employee => employee.ID == ID).FirstOrDefault();
                                        if(assignedEmployee.order != null)
                                        {
                                            assignedEmployee.finishOrder();
                                            Console.WriteLine($"{assignedEmployee.name} has complete their order and can be assigned with new ones");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{assignedEmployee.name} has no order to complete");
                                        }

                                    }
                                    break;
                                case '6':
                                    {
                                        Console.Clear();
                                        table.showTable();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '7':
                                    {
                                        Console.Clear();
                                        table.addTable();
                                    }
                                    break;
                                case '8':
                                    {
                                        Console.Clear();
                                        table.removeTable();
                                    }
                                    break;
                                case '9':
                                    page = 2;
                                    break;
                                case '0':
                                    exit = true;
                                    break;
                                default:
                                    break;
                            }
                        }

                        break;
                    //menu page 2
                    case 2:
                        {
                            Console.WriteLine("--employee menu page 2--");
                            Console.WriteLine("1)show order list.");
                            Console.WriteLine("2)add food.");
                            Console.WriteLine("3)remove food.");
                            Console.WriteLine("4)show food list.");
                            Console.WriteLine("9)preveous page.");
                            Console.WriteLine("0)exit employee menu.");
                            ConsoleKeyInfo key = Console.ReadKey();
                            switch (key.KeyChar)
                            {
                                case '1':
                                    {
                                        Console.Clear();
                                        order.showOrder();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '2':
                                    {
                                        Console.Clear();
                                        food.addFood();
                                        Console.WriteLine("food added to list succesfully");
                                        Console.ReadKey();
                                    }
                                    break;
                                case '3':
                                    {
                                        Console.Clear();
                                        food.removeFood();
                                    }
                                    break;
                                case '4':
                                    {
                                        Console.Clear();
                                        food.showFood();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '9':
                                    page = 1;
                                    break;
                                case '0':
                                    exit = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        page = 1;
                        break;
                }
            } while (exit == false);
        }
    }
}
