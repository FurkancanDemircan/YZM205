using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoor { get; set; }
        public bool Wiper = false;

        public Car(string model, DateTime year, string color, int numberOfWheel, double kilometer, double topSpeed, double currentSpeed, int numberOfDoor) : base(model, year, color, numberOfWheel, kilometer, topSpeed, currentSpeed)
        {
            NumberOfDoor = numberOfDoor;
        }

        public bool HaveSunroof { get; set; }

        public void ActivateWiper()
        {
            if (Wiper.Equals(false))
            {
                Wiper = true;
                Console.WriteLine("Wiper activated!");
            }
            else
            {
                Wiper = false;
                Console.WriteLine("Wiper deactivated!");
            }
        }

        public void ActivateSunroof()
        {
            if (HaveSunroof)
                Console.WriteLine("Sunroof opened!");
            else
                Console.WriteLine("You're poor, you don't have sunroof!");
        }
    }
}
