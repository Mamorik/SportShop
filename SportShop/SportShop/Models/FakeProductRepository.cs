using System.Collections.Generic;
using System.Linq;

namespace SportShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product
            {
                nameProduct = "Football",
                priceProduct = 25
            },
            new Product
            {
                nameProduct = "Surf board",
                priceProduct = 95
            },
            new Product
            {
                nameProduct = "Running shoes",
                priceProduct = 95
            }

        }.AsQueryable<Product>();

    }
}
