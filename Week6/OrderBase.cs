using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public enum OrderStatus
    {
        Pending,
        Preparing,
        Delivery,
        Completed
    }

    public abstract class OrderBase
    {
        protected List<FoodItem> foodItems;

        protected OrderBase(Customer customer)
        {
            this.foodItems = new List<FoodItem>(); ;
            Customer = customer;
        }

        public OrderStatus OrderStatus { get; set; }

        public Customer Customer { get; set; }

        public void AddItem(FoodItem item)
        {
            this.foodItems.Add(item);
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            this.foodItems.ForEach(foodItem => { total += foodItem.Price; });
            return total;
        }

        public abstract void DisplayInfo();
    }
}
