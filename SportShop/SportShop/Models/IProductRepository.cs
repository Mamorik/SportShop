using System.Linq;

namespace SportShop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
