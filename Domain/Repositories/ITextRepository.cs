using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface ITextRepository : IBaseRepository<Text>
    {
        IQueryable<Text> Texts { get; }
    }
}