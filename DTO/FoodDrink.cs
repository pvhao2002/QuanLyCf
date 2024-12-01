using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_SHOP_MANAGEMENT.DTO
{
    public class FoodDrink
    {
        private int iD;
        private string name;
        private int categoryId;
        private double price;
        private int state;
        public FoodDrink(int id, string name, int categoryID, double price, int state)
        {
            this.iD = id;
            this.name = name;
            this.categoryId = categoryID;
            this.price = price;
            this.state = state;
        }
        public FoodDrink(Food item)
        {
            this.iD = item.id;
            this.name = item.name;
            this.categoryId = item.idCategory;
            this.price = item.price;
            this.state = item.stateID;
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public double Price { get => price; set => price = value; }
        public int State { get => state; set => state = value; }
    }
}
