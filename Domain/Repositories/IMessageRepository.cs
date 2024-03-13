using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IMessageRepository : IBaseRepository<Message>
    {
        IQueryable<Message> Messages { get; }
    }
}