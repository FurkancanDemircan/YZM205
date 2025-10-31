using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Order : OrderBase
    {
        public Order(Customer customer) : base(customer)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{OrderStatus} {GetTotal()}");
            foodItems.ForEach(foodItem => { foodItem.Display(); });
        }
    }
}
