using Domain.Entities;
using Domain.Models;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{
    public class BaseController : Controller
    {
        private readonly IEscortRepository _escortRepository;
        private readonly ITextRepository _textRepository;
        private readonly IMenuRepository _menuRepository;
        private readonly IMemoryCache _cache;
        public BaseController(IEscortRepository escortRepository,
            ITextRepository textRepository,
            IMenuRepository menuRepository,
            IMemoryCache memoryCache)
        {
            _escortRepository = escortRepository;
            _textRepository = textRepository;
            _menuRepository = menuRepository;
            _cache = memoryCache;
        }

        protected async Task<List<Escort>> GetAllEscorts()
        {
#if DEBUG
            return await _escortRepository.Escorts.AsNoTracking()
                .Where(z => z.SiteName == Constants.SiteName)
                .Include(z => z.FileImages).ToListAsync();
#else
            if (_cache.TryGetValue("escorts-time-cache", out List<Escort> escorts)) return escorts;

            escorts = await _escortRepository.Escorts.AsNoTracking()
                .Where(z => z.SiteName == Constants.SiteName)
                .Include(z => z.FileImages).ToListAsync();

            _cache.Set("escorts-time-cache", escorts, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(5)));

            return escorts;
#endif
        }

        protected async Task<List<Text>> GetAllTexts()
        {
#if DEBUG
            return await _textRepository.Texts.AsNoTracking()
                .Where(z => z.SiteName == Constants.SiteName).ToListAsync();
#else
            if (_cache.TryGetValue("texts-time-cache", out List<Text> texts)) return texts;

            texts = await _textRepository.Texts.AsNoTracking()
                .Where(z => z.SiteName == Constants.SiteName).ToListAsync();

            _cache.Set("texts-time-cache", texts, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(5)));

            return texts;
#endif
        }

        protected async Task<List<Menu>> GetAllMenu()
        {
            if (_cache.TryGetValue("menu-time-cache", out List<Menu> menu)) return menu;

            menu = await _menuRepository.Menus.AsNoTracking()
                .Where(z => z.SiteName == Constants.SiteName).OrderByDescending(z => z.Id).ToListAsync();

            _cache.Set("menu-time-cache", menu, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(5)));

            return menu;
        }
    }
}
