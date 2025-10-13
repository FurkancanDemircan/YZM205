using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bike : Vehicle
    {
        private bool _havePasengerSeat;

        public bool HaveHelmet { get; set; }
        public bool HavePasengerSeat
        {
            get => _havePasengerSeat;
            set
            {
                if (NumberOfWheel.Equals(3))
                    _havePasengerSeat = true;

                else
                    _havePasengerSeat = false;
            }
        }

        public Bike(string model,
            DateTime year,
            string color,
            int numberOfWheel,
            double kilometer,
            double topSpeed,
            double currentSpeed)
            : base(model, year, color, numberOfWheel, kilometer, topSpeed, currentSpeed)
        {
        }

        public Bike(string model,
            DateTime year,
            string color,
            int numberOfWheel,
            double kilometer,
            double topSpeed,
            double currentSpeed,
            bool haveHelmet)
            : this(model,
                  year,
                  color,
                  numberOfWheel,
                  kilometer,
                    topSpeed,
                    currentSpeed)
        {
            HaveHelmet = haveHelmet;
        }

        public void FrontBreak()
        {
            Console.WriteLine("Front break used!");
        }

    }
}
