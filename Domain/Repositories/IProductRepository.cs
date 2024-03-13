using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IQueryable<Product> Products { get; }
    }
}
