using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfVoiceRepository : EfBaseRepository<Voice>, IVoiceRepository
    {
        public IQueryable<Voice> Voices => Context.Voices;

        public EfVoiceRepository(EfDbContext db) : base(db)
        {
        }
    }
}