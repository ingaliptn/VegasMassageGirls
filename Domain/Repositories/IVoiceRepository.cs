using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IVoiceRepository : IBaseRepository<Voice>
    {
        IQueryable<Voice> Voices { get; }
    }
}