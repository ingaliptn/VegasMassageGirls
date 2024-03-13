using ConsoleApp.Lib;
using Domain.Models;
using Domain.Repositories;
using Domain.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serviceProvider = new ServiceCollection()
                .AddDbContext<EfDbContext>(options =>
                    options.UseSqlServer(Constants.DefaultConnection))
                .AddSingleton<ISettingRepository, EfSettingRepository>()
                .AddSingleton<IEscortRepository, EfEscortRepository>()
                .AddSingleton<ITextRepository, EfTextRepository>()
                .AddSingleton<IMenuRepository, EfMenuRepository>()
                .AddSingleton<IFileImageRepository, EfFileImageRepository>()
                .BuildServiceProvider();

            var l = new TextChange(serviceProvider);
            await l.TextChangeDescription(Constants.SiteName, "702-852-3020", "702-789-6405");
            //var l = new CsvToBd(serviceProvider);
            //await l.RemoveBad(Constants.SiteName);
            //await l.AddEscort1(Constants.SiteName, "dreamgirl1.csv");
            //await l.AddSiteTitleSiteDescription(Constants.SiteName, "lasvegas.csv");
            //await l.AddParserTexts(Constants.SiteName);
            //await l.BuildSection(Constants.SiteName);
        }
    }
}
