using Microsoft.EntityFrameworkCore;

namespace Products.Models
{
    public static class ProductExtension
    {
        public static List<Product> GetProducts(this DbSet<Product> product,
            float minValue, float maxValue)
        {
            // MinValue - MaxValue arasındaki değerleri döndür. => Price
            return product.Where(p => p.Price >= minValue && p.Price <= maxValue).ToList();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public decimal Stock { get; set; }

        public float CalculatePrice()
            => Price * (float)Stock;
    }
}