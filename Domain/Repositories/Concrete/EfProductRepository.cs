using Domain.Entities;
using Domain.Repositories;
using System.Linq;
using Domain.Repositories.Concrete;

namespace Domain.Concrete
{
    public class EfProductRepository : EfBaseRepository<Product>, IProductRepository
    {
        public IQueryable<Product> Products => Context.Products;

        public EfProductRepository(EfDbContext db) : base(db)
        {
        }
    }
}
