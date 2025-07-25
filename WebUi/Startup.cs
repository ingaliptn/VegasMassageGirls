using AutoMapper;
using Domain.Models;
using Domain.Repositories;
using Domain.Repositories.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUi.Data;
using WebUi.Infrastructure;
using WebUi.Models;

namespace WebUi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddDbContext<EfDbContext>(options =>
				options.UseSqlServer(Constants.DefaultConnection));

			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(Constants.DefaultConnection));
			services.AddDatabaseDeveloperPageExceptionFilter();

			services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ApplicationDbContext>();
			services.AddControllersWithViews();
			services.AddMemoryCache();

			ConfigureDi(services);
			services.AddAutoMapper(typeof(Startup));

		}

		private void ConfigureDi(IServiceCollection services)
		{
			services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
			services.AddScoped<ISettingRepository, EfSettingRepository>();
			services.AddScoped<IEscortRepository, EfEscortRepository>();
			services.AddScoped<IFileImageRepository, EfFileImageRepository>();
			services.AddScoped<ITextRepository, EfTextRepository>();
			services.AddScoped<IMenuRepository, EfMenuRepository>();

			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			//email
			services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
			services.AddSingleton<IEmailSender, EmailSender>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			/////////////////


			var rewriteOptions = new RewriteOptions()
			.Add(context =>
			{
				var request = context.HttpContext.Request;
				var host = request.Host.Value.ToLower();

				// Перевірка домену та редірект на новий піддомен
				if (host == "www.vegasmassagegirls.com" || host == "vegasmassagegirls.com")
				{
					if (request.Path.Value == "/fbsm-massage.php")
					{
						// Редірект на піддомен зі статусом 301 (Moved Permanently)
						context.HttpContext.Response.Redirect("https://nuru.vegasmassagegirls.com/fbsm-massage.php", true);
					}
					else if (request.Path.Value == "/nuru-massage.php")
					{
						context.HttpContext.Response.Redirect("https://nuru.vegasmassagegirls.com/", true);
					}
				}
				// Продовження виконання інших правил
				context.Result = RuleResult.ContinueRules;
			})
			// Перенаправлення на HTTPS зі статусом 301
			.AddRedirectToHttps(StatusCodes.Status301MovedPermanently);

			app.UseRewriter(rewriteOptions);


			/////////////////////


			//var options = new RewriteOptions()
			//             //.AddRedirectToWww(301)
			//             .AddRedirectToHttps(301);
			//         app.UseRewriter(options);

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}
	}
}
