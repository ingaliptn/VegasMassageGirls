using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IEscortRepository : IBaseRepository<Escort>
    {
        IQueryable<Escort> Escorts { get; }
    }
}
