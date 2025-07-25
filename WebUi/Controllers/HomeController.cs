using System;
using AutoMapper;
using Domain.Entities;
using Domain.Models;
using Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Domain.Infrastructure;
using WebUi.Lib;
using WebUi.Models;

namespace WebUi.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _env;

        public HomeController(IEscortRepository escortRepository,
            ITextRepository textRepository,
            IMenuRepository menuRepository,
            IMapper mapper,
            IWebHostEnvironment env,
            IMemoryCache memoryCache,
            IHttpContextAccessor httpContextAccessor,
            ILogger<HomeController> logger) : base (escortRepository, textRepository, menuRepository, memoryCache)
        {
            _logger = logger;
            _mapper = mapper;
            _env = env;
            _httpContextAccessor = httpContextAccessor;
        }

#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        public async Task<IActionResult> Index(string name)
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";

            if (baseUrl.Contains("bodyrubs.vegasmassagegirls.com"))
                return RedirectPermanent("https://www.vegasmassagegirls.com/body-rubs.php");
            if (baseUrl.Contains("happyending.vegasmassagegirls.com"))
                return RedirectPermanent("https://www.vegasmassagegirls.com/happy-ending-massage.php");
            if (baseUrl.Contains("inroom.vegasmassagegirls.com"))
                return RedirectPermanent("https://www.vegasmassagegirls.com/inroom-massage.php");
			if (baseUrl.Contains("tantra.vegasmassagegirls.com"))
				return RedirectPermanent("https://www.vegasmassagegirls.com/tantra-massage.php");
			if (baseUrl.Contains("nuru.vegasmassagegirls.com/fbsm-massage.php"))
				return RedirectPermanent("https://www.vegasmassagegirls.com/fbsm-massage.php");
			if (baseUrl.Contains("nuru.vegasmassagegirls.com"))
				return RedirectPermanent("https://www.vegasmassagegirls.com/nuru-massage.php");

			/////////
			//if (baseUrl.Contains("vegasmassagegirls.com/fbsm-massage.php"))
			//    return RedirectPermanent("https://nuru.vegasmassagegirls.com/fbsm-massage.php");
			//if (baseUrl.Contains("vegasmassagegirls.com/nuru-massage.php"))
			//    return RedirectPermanent("https://nuru.vegasmassagegirls.com/");
			/////////


			var m = new HomeViewModel();
            var escorts = await GetAllEscorts();
            foreach (var p in escorts)
            {
                m.List.Add(_mapper.Map<HomeViewItem>(p));
            }
            
            var list = await GetAllTexts();

            m.PositionHomeTopTitle = list
                .Where(z => z.Position == "PositionHomeTopTitle").Select(z => z.Description)
                .FirstOrDefault();
            m.PositionHomeTop = list
                .Where(z => z.Position == "PositionHomeTop").Select(z => z.Description)
                .FirstOrDefault();
            m.PositionHomeBottom = list
                .Where(z => z.Position == "PositionHomeBottom").Select(z => z.Description)
                .FirstOrDefault();

            ViewBag.BackGroundImage = "home_bg.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.SiteTitle = list
                .Where(z => z.Position == "SiteTitleHome").Select(z => z.Description)
                .FirstOrDefault();
            ViewBag.SiteDescription = list
                .Where(z => z.Position == "SiteDescriptionHome").Select(z => z.Description)
                .FirstOrDefault();

            //ViewBag.MenuEscorts = await GetAllMenu();

            ViewBag.GoogleAnalyticsObject = list
                .Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();

            return View(m);
        }

        private string GetCanonicalUrl()
        {
            if (_httpContextAccessor.HttpContext != null)
            {
                var request = _httpContextAccessor.HttpContext.Request;
                return string.Concat(
                    request.Scheme,
                    "://",
                    request.Host.ToUriComponent(),
                    request.PathBase.ToUriComponent(),
                    request.Path.ToUriComponent(),
                    request.QueryString.ToUriComponent());
            }

            return string.Empty;
        }

#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("services.php")]
        public IActionResult Services()
        {
            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 14)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.SiteDescription = "There are different massage services for different purposes. Here, on VegasMassageGirls, we offer all of them. Call now!";
            ViewBag.SiteTitle = "Massage Services In Las Vegas At VegasMassageGirls";
            return View();
        }

#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("about-us.php")]
        public async Task<IActionResult> AboutUs()
        {
            var texts = await GetAllTexts();
            var m = new AboutUsViewModel
            {
                PositionAbout = texts.Where(z => z.Position == "PositionAbout")
                    .Select(z => z.Description).Single(),
                SiteDescriptionAbout = texts.Where(z => z.Position == "SiteDescriptionPageAbout")
                    .Select(z => z.Description).Single()
            };

            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2,15)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.SiteTitle = texts.Where(z => z.Position == "SiteTitleAboutUs")
                .Select(z => z.Description).FirstOrDefault();
            ViewBag.SiteDescription = texts.Where(z => z.Position == "SiteDescriptionAboutUs").Select(z => z.Description)
                .FirstOrDefault();

            //ViewBag.MenuEscorts = await GetAllMenu();

            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
               .FirstOrDefault();

            return View(m);
        }


#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("report.php")]
        public async Task<IActionResult> Report()
        {
            var texts = await GetAllTexts();
            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 15)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.SiteTitle ="Report Trafficking - VegasMassageGirls";
            ViewBag.SiteDescription = "Report Trafficking - VegasMassageGirls";

            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();
            return View();
        }

        public async Task<IActionResult> Massage(string name, bool isMassage)
        {
            var m = new MassageViewModel();
            m.IsMassage = isMassage;
            
            var escorts = await GetAllEscorts();
            var texts = await GetAllTexts();
            var list = new List<Escort>();
            var rnd = new Random();
            var massageName = string.Empty;
            switch (name)
            {
                case "fbsm-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "FBSM";
                    break;
                case "asian":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "Asian";
                    break;
                case "outcall-massage":
                    list = escorts.Where(z => z.Section.Contains("Outcall")).ToList();
                    massageName = "OutcallMassage";
                    break;
                case "nuru-massage":
                    list = escorts.Where(z => z.Section.Contains("Nuru")).ToList();
                    massageName = "Nuru";
                    break;
                case "korean":
                    list = escorts.Where(z => z.Nationality == "Asian").OrderByDescending(z=>z.Id).Take(4).ToList();
                    massageName = "Korean";
                    break;
                case "erotic-women":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "EroticWoman";
                    break;
                case "couples":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "Couples";
                    break;
                case "erotic-couples":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "EroticCouples";
                    break;
                case "inroom-couples":
                    list = escorts.Where(z => z.Section.Contains("Room")).ToList();
                    massageName = "InroomCouples";
                    break;
                case "romantic-couples":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "RomanticCouples";
                    break;
                case "oriental":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "Oriental";
                    break;
                case "what-happens-tantra":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "HappensTantra";
                    break;
                case "what-is-body-rubs":
                    list = escorts.Where(z => z.Section.Contains("Rubs")).Take(4).ToList();
                    massageName = "BodyRubs";
                    break;
                case "body-rubs":
                    list = escorts.Where(z => z.Section.Contains("Body Rubs")).Take(8).ToList();
                    massageName = "BodyRubsNew";
                    break;
                case "happy-ending-massage":
                    list = escorts.Where(z => z.Section.Contains("Happy")).ToList();
                    massageName = "HappyEnding";
                    break;
                case "inroom-massage":
                    list = escorts.Where(z => z.Section.Contains("Room")).ToList();
                    massageName = "Inroom";
                    break;
                case "in-room-massage":
                    list = escorts.Where(z => z.Section.Contains("Room")).Take(8).ToList();
                    massageName = "Inroom";
                    break;
                case "tantra-massage":
                    list = escorts.Where(z => z.Section.Contains("Room")).ToList();
                    massageName = "TantraM";
                    break;
                case "what-is-tantra":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 12) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(8).ToList();
                    massageName = "Tantra";
                    break;
                case "about-outcall-massage":
                    list = escorts.Where(z => z.Section.Contains("Outcall")).ToList();
                    massageName = "AboutOutcall";
                    break;
                case "massage-benefits":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "MassageBenefits";
                    break;
                case "nuru-massage-definition":
                    list = escorts.Where(z => z.Section.Contains("Nuru")).ToList();
                    massageName = "NuruDefinition";
                    break;
                case "is-nuru-massage-legal":
                    list = escorts.Where(z => z.Section.Contains("Nuru")).ToList();
                    massageName = "NuruLegal";
                    break;
                case "where-to-get-a-nuru-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "GetNuru";
                    break;
                case "how-to-give-a-nuru-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "GiveNuru";
                    break;
                case "erotic-massage-benefits":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "EroticBenefits";
                    break;
                case "where-to-get-erotic-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "GetErotic";
                    break;
                case "what-is-an-erotic-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "WhatErotic";
                    break;
                case "what-happens-during-an-erotic-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "HappensErotic";
                    break;
                case "what-to-expect-erotic-massage":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "ExpectErotic";
                    break;
                case "what-does-erotic-massage-mean":
                    foreach (var r in escorts.Select(p => rnd.Next(escorts.Count - 1)))
                    {
                        list.Add(escorts[r]);
                        if (list.Count == 6) break;
                    }
                    list = list.DistinctBy(z => z.EscortName).Take(4).ToList();
                    massageName = "EroticMean";
                    break;
            }

            var s = name.Replace("-", " ");
            m.EscortsNavTitle = Regex.Replace(s, @"(^\w)|(\s\w)", m => m.Value.ToUpper());

            m.PositionMassageTitle = texts.Where(z => z.Position == $"Position{massageName}Title").Select(z => z.Description)
                .FirstOrDefault();
            m.PositionMassageTop = texts.Where(z => z.Position == $"Position{massageName}Top").Select(z => z.Description)
                .FirstOrDefault();
            m.PositionMassageBottom = texts.Where(z => z.Position == $"Position{massageName}Bottom").Select(z => z.Description)
                .FirstOrDefault();
            ViewBag.SiteTitle = texts.Where(z => z.Position == $"SiteTitle{massageName}Massage").Select(z => z.Description)
                .FirstOrDefault();
            ViewBag.SiteDescription = texts.Where(z => z.Position == $"SiteDescription{massageName}Massage").Select(z => z.Description)
                .FirstOrDefault();
            
            foreach (var i in list.Select(p => _mapper.Map<HomeViewItem>(p)))
            {
                m.List.Add(i);
            }

            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 14)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.MenuEscorts = await GetAllMenu();
            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();

            return View("Massage",m);
        }

#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("blog/{name}")]
        public async Task<IActionResult> BlogMassage(string name)
        {
            return await Massage(name.Substring(0, name.Length - 4), false);
        }

#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("{name}")]
        public async Task<IActionResult> Escorts(string name)
        {
            var escortNames = new List<string>(new string[]
            {
                "lida.php", "lora.php", "nika.php","marina.php", "natasha.php", "snejana.php",
                "rada.php", "maya.php", "milana.php","nataly.php", "miledi.php", "daniela.php",
                "katrin.php", "emilie.php", "eldara.php","betti.php", "lala.php", "katia.php",
                "klaudia.php", "gloria.php", "ivory.php","irina.php", "nina.php", "amy.php",
                "fiona.php", "valeria.php", "suzi.php","maria.php", "mandy.php", "jessica.php",
                "ada.php", "carol.php", "lexi.php","alexis.php", "anita.php", "amalia.php",
                "beata.php", "alina.php", "albina.php","asa.php","claudia.php","abigail.php",
                "anna.php","yana.php","lili.php","lika.php","milena.php","stella.php","ada.php"
            });

            if (
                name == "fbsm-massage.php" ||
                name == "korean.php" ||
                name == "asian.php" ||
                name == "outcall-massage.php" ||
                name == "erotic-women.php" ||
                name == "body-rubs.php" ||
                name == "happy-ending-massage.php" ||
                name == "inroom-massage.php" ||
                name == "in-room-massage.php" ||
                name == "tantra-massage.php" ||
                name == "nuru-massage.php"
                )
            {
                return await Massage(name.Substring(0, name.Length - 4), true);
            }

            if (escortNames.Contains(name)) return await Profile(name);

            var m = new EscortsViewModel();

            var escorts = await GetAllEscorts();
            var texts = await GetAllTexts();

            var escortsSub = new List<Menu>
            {
                new Menu {Name = "Asian Escorts", Href = "asian-escorts"},
                new Menu {Name = "Ebony Escorts", Href = "ebony-escorts"},
                new Menu {Name = "GFE", Href = "gfe"}
            };
            var menuName = escortsSub.Where(z => z.Href == name).Select(z => z.Name).Single();

            m.EscortsNavTitle = menuName;

            //menuName = menuName.Replace(" ", "-");
            m.EscortsHeading = await GetEscortsHeading($"Escorts-{name}-Title");

            m.PositionEscortsTop = texts.Where(z => z.Position == $"Escorts-{name}-Top")
                .Select(z => z.Description).Single();
            m.PositionEscortsBottom = texts.Where(z => z.Position == $"Escorts-{name}-Bottom")
                .Select(z => z.Description).Single();

            var title = $"Escorts-{name}-SiteTitle";
            var description = $"Escorts-{name}-SiteDescription";
            var list = escorts.Where(z => z.City == name.Replace("-","_")).ToList();

            foreach (var i in list.Select(p => _mapper.Map<HomeViewItem>(p)))
            {
                m.List.Add(i);
            }

            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 14)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();

            ViewBag.SiteTitle = texts.Where(z => z.Position == title).Select(z => z.Description)
                .FirstOrDefault();
            ViewBag.SiteDescription = texts.Where(z => z.Position == description).Select(z => z.Description)
                .FirstOrDefault();

            //ViewBag.MenuEscorts = menu;
            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();

            return View(m);
        }

        public async Task<IActionResult> Profile(string name)
        {
            name = name.Substring(0, name.Length - 4);
            var escorts = await GetAllEscorts();
            var texts = await GetAllTexts();

            var escort = escorts.FirstOrDefault(z => z.EscortName.ToLower() == name);

            if (escort == null) return RedirectToAction("Error", "Home");

            var m = _mapper.Map<ProfileViewModel>(escort);

            //var list = escorts.Where(z => z.Id != escort.Id && z.City == escort.City).ToList();
            var list = escorts.Where(z => z.Id != escort.Id).ToList();

            var rnd = new Random();
            foreach (var r in list.Select(p => rnd.Next(list.Count - 1)))
            {
                m.List.Add(list[r]);
                if (m.List.Count == 8) break;
            }
            m.List = m.List.Where(z => z.Id != escort.Id).DistinctBy(z => z.Id).Take(4).ToList();

            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 15)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();

            //ViewBag.SiteTitle = texts.Where(z => z.Position == $"SiteTitleProfile-{escort.EscortId}").Select(z => z.Description)
            //    .FirstOrDefault();
            //ViewBag.SiteDescription = texts.Where(z => z.Position == $"SiteDescriptionProfile-{escort.EscortId}").Select(z => z.Description)
            //    .FirstOrDefault();

            ViewBag.SiteTitle = $"Masseuse {escort.EscortName} is experienced {escort.Age} years old girl - Vegas Massage Girls";
            ViewBag.SiteDescription = $"{escort.EscortName} is experienced {escort.Age} years old masseuse. She can provide for relaxing massage of all types. Call now to Vegas Massage Girls";

            //ViewBag.MenuEscorts = await GetAllMenu();
            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();

            return View("Profile",m);
        }


#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("blog.php")]
        public async Task<IActionResult> Blog()
        {
            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 14)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.SiteDescription = "Find the most relevant articles about erotic and sensual massage in Las Vegas on VegasMassageGirls";
            ViewBag.SiteTitle = "Erotic Massage Blog on VegasMassageGirls";
            var texts = await GetAllTexts();
            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();
            return View("Blog");
        }

#if !DEBUG
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
#endif
        [Route("blog/page-2.php")]
        public async Task<IActionResult> Page2()
        {
            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 14)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();
            ViewBag.SiteDescription = "Find the most relevant articles about erotic and sensual massage in Las Vegas on VegasMassageGirls";
            ViewBag.SiteTitle = "Erotic Massage Blog on VegasMassageGirls";
            var texts = await GetAllTexts();
            ViewBag.GoogleAnalyticsObject = texts.Where(z => z.Position == "GoogleAnalyticsObject").Select(z => z.Description)
                .FirstOrDefault();
            return View("Page2");
        }

        [Route("robots.txt")]
        public ContentResult RobotsTxt()
        {
            var filePath = Path.Combine(_env.WebRootPath,"robots.txt");
            var s = System.IO.File.ReadAllText(filePath);
            return this.Content(s, "text/plain", Encoding.UTF8);
        }

        [Route("sitemap.xml")]
        public ContentResult SiteMap()
        {
            var filePath = Path.Combine(_env.WebRootPath, "sitemap.xml");
            var s = System.IO.File.ReadAllText(filePath);
            return this.Content(s, "text/plain", Encoding.UTF8);
        }

        private async Task<string> GetEscortsHeading(string position)
        {
            var texts = await GetAllTexts();
            return texts.Where(z => z.Position == position)
                .Select(z => z.Description).FirstOrDefault();
        }

        [Route("{seg1?}/{seg2}")]
        public IActionResult BadUrl()
        {
            return RedirectToAction("Error");
        }

        [Route("404.php")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            ViewBag.BackGroundImage = $"{WorkLib.GetRandomNumber(2, 14)}.jpg";
            ViewBag.CanonicalUrl = GetCanonicalUrl();

            ViewBag.SiteTitle = "";
            ViewBag.SiteDescription = "";

            Response.StatusCode = 404;

            ViewBag.MenuEscorts = await GetAllMenu();

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class HomeViewModel
    {
        public string PositionHomeTopTitle { get; set; }
        public string PositionHomeTop { get; set; }
        public string PositionHomeBottom { get; set; }
        public List<HomeViewItem> List { get; set; } = new List<HomeViewItem>();
    }

    public class EscortsViewModel
    {
        public string EscortsHeading { get; set; }
        public string EscortsNavTitle { get; set; }
        public string PositionEscortsTop { get; set; }
        public string PositionEscortsBottom { get; set; }
        public List<HomeViewItem> List { get; set; } = new List<HomeViewItem>();
    }

    public class MassageViewModel
    {
        public string EscortsNavTitle { get; set; }
        public string PositionMassageTitle { get; set; }
        public string PositionMassageTop { get; set; }
        public string PositionMassageBottom { get; set; }
        public bool IsMassage { get; set; }
        public List<HomeViewItem> List { get; set; } = new List<HomeViewItem>();
    }

    public class BodyRubsViewModel
    {
        public string PositionBodyRubsTitle { get; set; }
        public string PositionBodyRubsTop { get; set; }
        public string PositionBodyRubsBottom { get; set; }
        public List<HomeViewItem> List { get; set; } = new List<HomeViewItem>();
    }

    public class AboutUsViewModel
    {
        public string PositionAbout { get; set; }
        public string SiteDescriptionAbout { get; set; }
        public List<HomeViewItem> List { get; set; } = new List<HomeViewItem>();
    }

    public class HomeViewItem : Escort
    {
        
    }
}
