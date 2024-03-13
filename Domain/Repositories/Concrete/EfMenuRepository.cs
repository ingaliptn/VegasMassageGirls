using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfMenuRepository : EfBaseRepository<Menu>, IMenuRepository
    {
        public IQueryable<Menu> Menus => Context.Menus;

        public EfMenuRepository(EfDbContext db) : base(db)
        {
        }
    }
}