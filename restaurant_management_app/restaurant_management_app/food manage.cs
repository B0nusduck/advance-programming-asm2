using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management_app
{
    internal class food_manage
    {
        private static List<food> foodList = new List<food>();
        public void addFood()
        {
            food food = new food();
            food.infoInput();
            foodList.Add(food);
        }
        public void removeFood()
        {
            Console.Write("\ninput food id for removal: ");
            int removeID = int.Parse(Console.ReadLine());
            food removeFood = foodList.Where(food => food.ID == removeID).FirstOrDefault();
            foodList.Remove(removeFood);
        }
        public food getFoodByID(int ID)
        {
            return foodList.Where(food => food.ID == ID).FirstOrDefault();
        }
        public void showFood()
        {
            Console.WriteLine("all food in the menu");
            foodList.ForEach(food => Console.WriteLine(food.toString()));
        }
    }
}
