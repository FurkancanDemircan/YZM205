using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public Vehicle(string model,
            DateTime year,
            string color,
            int numberOfWheel,
            double kilometer,
            double topSpeed,
            double currentSpeed)
        {
            Model = model;
            Year = year;
            Color = color;
            NumberOfWheel = numberOfWheel;
            Kilometer = kilometer;
            TopSpeed = topSpeed;
            CurrentSpeed = currentSpeed;
        }

        protected string Model { get; set; }
        protected DateTime Year { get; set; }
        protected string Color { get; set; }
        protected int NumberOfWheel { get; set; }
        protected double Kilometer { get; set; }
        protected double TopSpeed { get; set; }
        protected double CurrentSpeed { get; set; }

        public void StartEngine()
        {
            CurrentSpeed = 20;
            Console.WriteLine($"Engine started! {base.ToString()}");
        }

        public void StopEngine()
        {
            CurrentSpeed = 0;
            Console.WriteLine($"Engine stoped! {base.ToString()}");
        }

        public void IncreaseSpeed()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current Speed: {CurrentSpeed}");
        }

        public void DecreaseSpeed()
        {
            CurrentSpeed -= 10;
            Console.WriteLine($"Current Speed: {CurrentSpeed}");
        }
    }
}
