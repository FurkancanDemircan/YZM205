namespace Week6
{
    public class Eatable : FoodItem
    {
        public Eatable(string name, decimal price) : base(name, price)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Eatable: {Name} - {Price}$");
        }
    }
}
