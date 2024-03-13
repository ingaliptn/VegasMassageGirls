using System.Collections.Generic;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISettingRepository : IBaseRepository<Setting>
    {
        IQueryable<Setting> Settings { get; }
        Task<string> SettingGetSingleValueAsync(string name);
        Task<List<Setting>> SettingListFromName(string name);
        Task SettingRemoveFromId(int id);
        Task SettingAddSingle(Setting s);
        string SettingGetSingleValue(string name);
        Task SettingAddIfNotFound(Setting s);
        Task SettingRemoveIfFound(Setting s);
        Task<List<string>> SettingListValueFromName(string name);
    }
}
