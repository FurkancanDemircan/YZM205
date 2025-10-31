using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Drinkable : FoodItem
    {
        public Drinkable(string name, decimal price) : base(name, price)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Drink: {Name} - {Price}$");
        }
    }
}
