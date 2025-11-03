namespace ShoppingLibrary
{
    public class Product
    {
        /*Fields*/
        /*Properties*/
        public int ProductId { get; set; } = 0;
        public string? Name { get; set; } = default;
        public decimal Stock { get; set; } = 1;
        public float ReviewScore { get; set; } = 0.0f;
        public decimal Price { get; set; } = decimal.Zero;
        public string? Description { get; set; }
        public DateTime CreateDate => DateTime.Now;

        /*Methods*/
        public Product(int productId, string? name, decimal stock, float reviewScore, decimal price, string? description)
        {
            ProductId = productId;
            Name = name;
            Stock = stock;
            ReviewScore = reviewScore;
            Price = price;
            Description = description;
        }

        public override string? ToString()
        {
            return $"{ProductId} {Name} {ReviewScore} {Description}";
        }
    }
}
