using System.Collections.Generic;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories.Concrete
{
    public class EfSettingRepository : EfBaseRepository<Setting>, ISettingRepository
    {
        public IQueryable<Setting> Settings => Context.Settings;

        public EfSettingRepository(EfDbContext db) : base(db)
        {
        }

        public async Task<string> SettingGetSingleValueAsync(string name)
        {
            var q = Settings.Where(z => z.Name == name).Select(z=>z.Value);
            var f = await q.AnyAsync();
            if (!f) return string.Empty;
            return await q.AsNoTracking().FirstAsync();
        }

        public string SettingGetSingleValue(string name)
        {
            return Settings.AsNoTracking()
                .Where(z => z.Name == name).Select(z => z.Value)
                .FirstOrDefault();
        }

        public async Task SettingAddSingle(Setting s)
        {
            var q = Settings.Where(z => z.Name == s.Name);
            var f = await q.AnyAsync();
            if (f)
            {
                var st = await q.FirstAsync();
                st.Value = s.Value;
            } else Context.Add(s);

            await SaveChangesAsync();
        }

        public async Task<List<Setting>> SettingListFromName(string name)
        {
            var q = Settings.Where(z => z.Name == name);
            var f = await q.AnyAsync();
            if(!f) return new List<Setting>();
            return await q.ToListAsync();
        }

        public async Task SettingRemoveFromId(int id)
        {
            var q = Settings.Where(z => z.Id == id);
            var f = await q.AnyAsync();
            if (!f) return;
            var ag = await q.SingleAsync();
            Context.Remove(ag);
            await SaveChangesAsync();
        }

        public async Task SettingAddIfNotFound(Setting s)
        {
            var q = Settings
                .Where(z => z.Name == s.Name && z.Value == s.Value);
            var f = await q.AnyAsync();
            if (f) return;
            Context.Add(s);
            await SaveChangesAsync();
        }

        public async Task SettingRemoveIfFound(Setting s)
        {
            var q = Settings
                .Where(z => z.Name == s.Name && z.Value == s.Value);
            var f = await q.AnyAsync();
            if (!f) return;
            var st = await q.SingleAsync();
            Context.Remove(st);
            await SaveChangesAsync();
        }

        public async Task<List<string>> SettingListValueFromName(string name)
        {
            var q = Settings.AsNoTracking()
                .Where(z => z.Name == name)
                .Select(z=>z.Value);
            var f = await q.AnyAsync();
            if (!f) return new List<string>();
            return await q.ToListAsync();
        }
    }
}
