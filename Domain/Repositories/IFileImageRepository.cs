using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IFileImageRepository : IBaseRepository<FileImage>
    {
        IQueryable<FileImage> FileImages { get; }
    }
}
