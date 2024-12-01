using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAFE_SHOP_MANAGEMENT.DTO;
namespace CAFE_SHOP_MANAGEMENT.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        CafeShopManagementSystemDataContext db = null;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance;  }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetCategories()
        {
            
            List<Category> categories = new List<Category>();
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from p in db.FoodCategories
                           select p;
                foreach (var item in list)
                {
                    Category category = new Category(item);
                    categories.Add(category);
                }
            }    


            return categories;
        }
    }
}
