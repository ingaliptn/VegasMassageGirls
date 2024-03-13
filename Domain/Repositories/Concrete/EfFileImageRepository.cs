using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfFileImageRepository : EfBaseRepository<FileImage>, IFileImageRepository
    {
        public IQueryable<FileImage> FileImages => Context.FileImages;

        public EfFileImageRepository(EfDbContext db) : base(db)
        {
        }
    }
}