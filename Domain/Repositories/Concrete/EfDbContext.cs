using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories.Concrete
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options)
            : base(options)
        {
        }
   
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Escort> Escorts { get; set; }
        public DbSet<FileImage> FileImages { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Setting>().HasIndex(z => z.Name);
            modelBuilder.Entity<Escort>().HasIndex(z => z.SiteName);
            modelBuilder.Entity<Text>().HasIndex(z => z.SiteName);
            modelBuilder.Entity<Menu>().HasIndex(z => z.SiteName);

            base.OnModelCreating(modelBuilder);
        }
    }
}
