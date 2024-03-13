using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfEscortRepository : EfBaseRepository<Escort>, IEscortRepository
    {
        public IQueryable<Escort> Escorts => Context.Escorts;

        public EfEscortRepository(EfDbContext db) : base(db)
        {
        }
    }
}
