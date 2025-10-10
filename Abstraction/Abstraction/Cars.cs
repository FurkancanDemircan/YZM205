using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Cars
    {
        /*
        public DateTime GetDate() { return _year; }
        public void SetDate(DateTime value) { _year = value; }
        */
        private double _MIN_SALARY = 22104;

        // field
        private DateTime _year;
        private double _price;
        private string _color;

        // Property
        public DateTime Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Model { get; set; }

        public double Price
        {
            get
            {
                Console.WriteLine("Real price: " + _price);
                return _price;
            }
            set
            {
                if (value < 4 * _MIN_SALARY)
                    _price = 100000;
                else
                    _price = value;
            }
        }
        public string Manufacturer { get; set; }

        public string Color
        {
            set
            {
                _color = value;
            }
        }

        public DateTime BuyDate
        {
            get
            {
                return DateTime.Now;
            }
        }

        public Cars()
        {

        }

        public Cars(string model, string manufacturer, string color, double price, DateTime year)
        {
            Color = color;
            Model = model;
            Price = price;
            Year = year;
            Manufacturer = manufacturer;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("------ Car Information ------");
            Console.WriteLine($"Model        : {Model}");
            Console.WriteLine($"Manufacturer : {Manufacturer}");
            Console.WriteLine($"Year         : {Year.Year}");
            Console.WriteLine($"Price        : {Price:C}");
            Console.WriteLine($"Color        : {_color}");
            Console.WriteLine($"Buy Date     : {BuyDate}");
            Console.WriteLine("------------------------------");
        }
    }
}
