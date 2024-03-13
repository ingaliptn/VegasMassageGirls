using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfMessageRepository : EfBaseRepository<Message>, IMessageRepository
    {
        public IQueryable<Message> Messages => Context.Messages;

        public EfMessageRepository(EfDbContext db) : base(db)
        {
        }
    }
}