using CAFE_SHOP_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CAFE_SHOP_MANAGEMENT.DAO
{
    public class FoodDrinkDAO
    {
        private static FoodDrinkDAO instance;
        CafeShopManagementSystemDataContext db = null;

        public static FoodDrinkDAO Instance
        {
            get { if (instance == null) instance = new FoodDrinkDAO(); return FoodDrinkDAO.instance; }
            private set { FoodDrinkDAO.instance = value; }
        }


        private FoodDrinkDAO() { }

        public List<FoodDrink> GetFoodDrinksByCategoryID(int id)
        {

            List<FoodDrink> foodDrinks = new List<FoodDrink>();
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from p in db.Foods
                           where p.idCategory == id
                           select p;
                foreach (var item in list)
                {
                    FoodDrink foodDrink = new FoodDrink(item);
                    foodDrinks.Add(foodDrink);
                }
                           
            }    


            return foodDrinks;
        }




    }
}
