using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_SHOP_MANAGEMENT.DTO
{
    public class Menuu
    {
        private string foodName;
        private int count;
        private double price;
        private double totalPrice;
        

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public Menuu(string foodName, int count, double price, double totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }
    }
}
