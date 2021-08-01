using System.Collections.Generic;
using System.Linq;

namespace SpecificationPattern
{
    public class _context
    {
        
        public static IQueryable<Product> Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Iphone x", Description = "Lorem Lorem Lorem Lorem", Price = 300, Brand = "Apple", Type = "Phones" },
                new Product { Id = 2, Name = "Samsung A32", Description = "Lorem Lorem Lorem Lorem", Price = 200, Brand = "Nokia", Type = "Phones" },
                new Product { Id = 3, Name = "Oppo A32", Description = "Lorem Lorem Lorem Lorem", Price = 100, Brand = "Xiaomi", Type = "Phones" },
                new Product { Id = 4, Name = "Samsung S8", Description = "Lorem Lorem Lorem Lorem", Price = 400, Brand = "Samsung", Type = "Phones" },
                new Product { Id = 5, Name = "Iphone Max Pro", Description = "Lorem Lorem Lorem Lorem", Price = 500, Brand = "Oppo", Type = "Phones" }
            };

            return products.AsQueryable();
        }
    }
}
