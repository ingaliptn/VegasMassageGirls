using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.Lib
{
    public class TextChange
    {
        private readonly IEscortRepository _escortRepository;
        private readonly ITextRepository _textRepository;
        private readonly IFileImageRepository _fileImage;
        private readonly IMenuRepository _menuRepository;

        public TextChange(IServiceProvider serviceProvider)
        {
            var serviceProvider1 = serviceProvider;
            _escortRepository = serviceProvider1.GetService<IEscortRepository>();
            _fileImage = serviceProvider1.GetService<IFileImageRepository>();
            _textRepository = serviceProvider1.GetService<ITextRepository>();
            _menuRepository = serviceProvider1.GetService<IMenuRepository>();
        }

        public async Task TextChangeDescription(string siteName, string textOld, string textNew)
        {
            var list = await _textRepository.Texts
                .Where(z => z.SiteName == siteName).ToListAsync();
            foreach (var p in list)
            {
                p.Description = p.Description.Replace(textOld, textNew);
            }

            await _textRepository.SaveChangesAsync();
        }
    }
}
