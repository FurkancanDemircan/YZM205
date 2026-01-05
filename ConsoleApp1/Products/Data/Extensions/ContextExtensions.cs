using Products.Models;

namespace Products.Data.Extensions;

public static class ContextExtensions
{
    public static IQueryable<Product> GetAllProducts(this IQueryable<Product> products,
        float min, float max)
    {
        return products
            .Where(p => p.Price <= max && p.Price >= min);
    }
}
