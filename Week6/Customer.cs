using System.Xml.Linq;

namespace Week6
{
    public class Customer : Person
    {
        public string Email { get; set; }

        public Customer(string name, int id, string email) : base(id, name)
        {
            this.Email = email;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Customer: {Name}, Email: {Email}");
        }
    }
}