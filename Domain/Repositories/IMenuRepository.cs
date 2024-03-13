using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IMenuRepository : IBaseRepository<Menu>
    {
        IQueryable<Menu> Menus { get; }
    }
}