using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_SHOP_MANAGEMENT.DTO
{
    public class Category
    {
        private int iD;
        private string name;
        
        public Category(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }
        public Category(FoodCategory fcategory)
        {
            this.iD = fcategory.id;
            this.name = fcategory.name;
        }
        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
