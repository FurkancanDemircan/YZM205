using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class DeliveryDriver : Person, IComparable<DeliveryDriver>
    {
        public int DeliveryCount { get; private set; }


        public DeliveryDriver(int id, string name) : base(id, name)
        {
            DeliveryCount = 0;
        }

        public void AssignDriver()
        {
            DeliveryCount++;
        }

        public int CompareTo(DeliveryDriver? other)
        {
            return DeliveryCount.CompareTo(other.DeliveryCount);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Driver: {Name} - Delivered: {DeliveryCount}");
        }
    }
}
