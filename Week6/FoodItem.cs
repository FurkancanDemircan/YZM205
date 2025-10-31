namespace Week6
{
    public abstract class FoodItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public FoodItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display();
    }
}