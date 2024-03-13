using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfTextRepository : EfBaseRepository<Text>, ITextRepository
    {
        public IQueryable<Text> Texts => Context.Texts;

        public EfTextRepository(EfDbContext db) : base(db)
        {
        }
    }
}