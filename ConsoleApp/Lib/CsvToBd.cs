using Domain.Entities;
using Domain.Models;
using Domain.Repositories;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebUi.Controllers;

namespace ConsoleApp.Lib
{
    public class CsvToBd
    {
        private readonly IEscortRepository _escortRepository;
        private readonly ITextRepository _textRepository;
        private readonly IFileImageRepository _fileImage;
        private readonly IMenuRepository _menuRepository;
        public CsvToBd(IServiceProvider serviceProvider)
        {
            var serviceProvider1 = serviceProvider;
            _escortRepository = serviceProvider1.GetService<IEscortRepository>();
            _fileImage = serviceProvider1.GetService<IFileImageRepository>();
            _textRepository = serviceProvider1.GetService<ITextRepository>();
            _menuRepository = serviceProvider1.GetService<IMenuRepository>();
        }

        public async Task TextBuildMenuHome(string siteName)
        {
            var text = new Text
            {
                SiteName = siteName,
                Position = "PositionHomeTopTitle"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "PositionHomeTop"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "PositionHomeBottom"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "SiteTitleHome"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "SiteDescriptionHome"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "About-SiteTitle"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "About-SiteDescription"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "About-Title"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "About-Description"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "Booking-SiteDescription"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "Booking-Title"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }

            text = new Text
            {
                SiteName = siteName,
                Position = "Contact-SiteDescription"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "Contact-Title"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }

            text = new Text
            {
                SiteName = siteName,
                Position = "Employment-SiteDescription"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
            text = new Text
            {
                SiteName = siteName,
                Position = "Employment-Title"
            };
            if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
            {
                _textRepository.Create(text);
                await _textRepository.SaveChangesAsync();
            }
        }

        public async Task TextBuildMenuEscorts(string siteName)
        {
            //var escortsSub = new List<Menu>
            //{
            //    new Menu {Name = "Asian Escorts", Href = "asian-escorts"},
            //    new Menu {Name = "Couple Massage", Href = "couples-massage"},
            //    new Menu {Name = "Nuru Massage", Href = "nuru-massage"},
            //    new Menu {Name = "Happy Ending Massage", Href = "happy-ending-massage"},
            //    new Menu {Name = "Nude Massage", Href = "nude-massage"},
            //    new Menu {Name = "Body Rubs", Href = "body-massage"},
            //};

            //foreach (var menu in escortsSub)
            //{
            //    var menuName = menu.Href;
            //    var text1 = new Text
            //    {
            //        SiteName = siteName, Position = $"Escorts-{menuName}-SiteTitle"
            //    };
            //    if (!_textRepository.Texts.Any(z => z.SiteName == text1.SiteName && z.Position == text1.Position))
            //    {
            //        _textRepository.Create(text1);
            //        await _textRepository.SaveChangesAsync();
            //    }
            //    var text3 = new Text
            //    {
            //        SiteName = siteName,
            //        Position = $"Escorts-{menuName}-SiteDescription"
            //    };
            //    if (!_textRepository.Texts.Any(z => z.SiteName == text3.SiteName && z.Position == text3.Position))
            //    {
            //        _textRepository.Create(text3);
            //        await _textRepository.SaveChangesAsync();
            //    }
            //    text3 = new Text
            //    {
            //        SiteName = siteName,
            //        Position = $"Escorts-{menuName}-Title"
            //    };
            //    if (!_textRepository.Texts.Any(z => z.SiteName == text3.SiteName && z.Position == text3.Position))
            //    {
            //        _textRepository.Create(text3);
            //        await _textRepository.SaveChangesAsync();
            //    }
            //    var text2 = new Text
            //    {
            //        SiteName = siteName,
            //        Position = $"Escorts-{menuName}-Top"
            //    };
            //    if (!_textRepository.Texts.Any(z => z.SiteName == text2.SiteName && z.Position == text2.Position))
            //    {
            //        _textRepository.Create(text2);
            //        await _textRepository.SaveChangesAsync();
            //    }
            //    text3 = new Text
            //    {
            //        SiteName = siteName,
            //        Position = $"Escorts-{menuName}-Bottom"
            //    };
            //    if (!_textRepository.Texts.Any(z => z.SiteName == text3.SiteName && z.Position == text3.Position))
            //    {
            //        _textRepository.Create(text3);
            //        await _textRepository.SaveChangesAsync();
            //    }
            //}

            var listMassage = new List<string>(new string[]
            {
                "asian-massage", "couples-massage","nuru-massage","happy-ending-massage","nude-massage","body-massage"
            });

            foreach (var massage in listMassage)
            {
                var text = new Text { SiteName = siteName, Position = $"Massage-{massage}-SiteTitle" };
                if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
                {
                    _textRepository.Create(text);
                    await _textRepository.SaveChangesAsync();
                }
                text = new Text { SiteName = siteName, Position = $"Massage-{massage}-SiteDescription" };
                if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
                {
                    _textRepository.Create(text);
                    await _textRepository.SaveChangesAsync();
                }
                text = new Text { SiteName = siteName, Position = $"Massage-{massage}-Title" };
                if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
                {
                    _textRepository.Create(text);
                    await _textRepository.SaveChangesAsync();
                }
               
                text = new Text { SiteName = siteName, Position = $"Massage-{massage}-Top" };
                if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
                {
                    _textRepository.Create(text);
                    await _textRepository.SaveChangesAsync();
                }
                text = new Text { SiteName = siteName, Position = $"Massage-{massage}-Bottom" };
                if (!_textRepository.Texts.Any(z => z.SiteName == text.SiteName && z.Position == text.Position))
                {
                    _textRepository.Create(text);
                    await _textRepository.SaveChangesAsync();
                }
            }
        }

        public async Task RemoveBad(string siteName)
        {
            //var list = await _escortRepository.Escorts
            //    .Where(z=>z.SiteName == siteName).Include(z=>z.FileImages).ToListAsync();
            //foreach (var p in list)
            //{
            //    foreach (var o in p.FileImages)
            //    {
            //        _fileImage.Remove(o);
            //    }
            //    _escortRepository.Remove(p);
            //}

            await _escortRepository.SaveChangesAsync();

            var list1 = await _textRepository.Texts.Where(z => z.SiteName == siteName).ToListAsync();
            foreach (var p in list1)
            {
                _textRepository.Remove(p);
            }

            await _textRepository.SaveChangesAsync();

            var list2 = await _menuRepository.Menus.Where(z => z.SiteName == siteName).ToListAsync();
            foreach (var p in list2)
            {
                _menuRepository.Remove(p);
            }

            await _menuRepository.SaveChangesAsync();
        }

        public async Task BuildSection(string siteName)
        {
            var list = await _escortRepository.Escorts.Where(z => z.SiteName == siteName).ToListAsync();
            foreach (var p in list)
            {
                if(!string.IsNullOrEmpty(p.Section)) continue;
                var age = "28-30";
                switch (p.Age)
                {
                    case { } n when (n <= 23):
                        age = "20-23";
                        break;
                    case { } n when (n >= 24 && n <= 27):
                        age = "24-27";
                        break;
                }

                var height = "59-6";
                var t = p.Height.Replace("ft ", string.Empty).Replace("inch", string.Empty);
                var f = int.TryParse(t, out var value);
                var h = GetRandom(52, 57);
                if (f) h = value;
                switch (h)
                {
                    case { } n when (n <= 55):
                        height = "50-55";
                        break;
                    case { } n when (n >= 56 && n <= 58):
                        height = "56-58";
                        break;
                }

                var weight = "141-160";
                switch (p.Weight)
                {
                    case { } n when (n <= 100):
                        weight = "80-100";
                        break;
                    case { } n when (n >= 101 && n <= 120):
                        weight = "101-120";
                        break;
                    case { } n when (n >= 121 && n <= 140):
                        weight = "121-140";
                        break;
                }
                p.Section = $"{age} {p.Bust} {height} {weight} {p.Hair}";
            }

            await _escortRepository.SaveChangesAsync();
        }

        public async Task AddEscort(string siteName, string fileName)
        {
            var path = $@"D:\!Download\{fileName}";
            using var reader = File.OpenText(path);
            var fileText = await reader.ReadToEndAsync();
            var list = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var p in list)
            {
                if(string.IsNullOrEmpty(p)) continue;
                var line = p.Split("~");
               
                if(line[0].Contains("escort_id")) continue;
                for (var i = 0; i < line.Length; i++)
                {
                   if(string.IsNullOrEmpty(line[i])) continue;
                   line[i] = line[i].Replace("\"", string.Empty);
                }

                var es = new Escort {SiteName = siteName};

                var fParse = int.TryParse(line[0], out var value);
                if(!fParse) continue;
                es.EscortId = value;

                if (!string.IsNullOrEmpty(line[1])) es.Section = line[1];
                if (!string.IsNullOrEmpty(line[2])) es.EscortName = line[2];
                if (!string.IsNullOrEmpty(line[3]))
                {
                    var f = int.TryParse(line[3], out var age);
                    if(f) es.Age = age;
                }
                if (!string.IsNullOrEmpty(line[4]))
                {
                    var f = int.TryParse(line[4], out var bust);
                    es.Bust = f ? bust : GetRandom(1, 4);
                }
                else
                {
                    es.Bust = GetRandom(1, 4);
                }
                if (!string.IsNullOrEmpty(line[5])) es.Nationality = line[5];
                if (!string.IsNullOrEmpty(line[6]))
                {
                    var f = int.TryParse(line[6], out var weight);
                    if (f) es.Weight = weight;
                }
                if (!string.IsNullOrEmpty(line[7])) es.Height = line[7];
                if (!string.IsNullOrEmpty(line[8])) es.Hair = line[8];
                if (!string.IsNullOrEmpty(line[9])) es.Languages = line[9];
                if (!string.IsNullOrEmpty(line[10])) es.Statistics = line[10];

                var descriptionPoint = line.Length - 1;
                if (!string.IsNullOrEmpty(line[descriptionPoint])) es.Description = line[descriptionPoint]; //todo line[descriptionPoint];

                for (var i = 11; i < line.Length - 2; i++) //todo line.Length - 2
                {
                    if (string.IsNullOrEmpty(line[i])) continue;
                    var fi = new FileImage {FileName = line[i], Escort = es};
                    _fileImage.Create(fi);
                }

                var f1 = await _escortRepository.Escorts
                    .Where(z => z.SiteName == es.SiteName && z.EscortName == es.EscortName).AnyAsync();
                if(f1) continue;
              
                _escortRepository.Create(es);
                await _escortRepository.SaveChangesAsync();
            }
            await _escortRepository.SaveChangesAsync();
        }

        public async Task AddEscort1(string siteName, string fileName)
        {
            var path = $@"D:\!Download\{fileName}";
            using var reader = File.OpenText(path);
            var fileText = await reader.ReadToEndAsync();
            //var list = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string[] stringSeparators = new string[] { "\n\r" };
            string[] list = fileText.Split(stringSeparators, StringSplitOptions.None);

            var count = 0;
            foreach (var p in list)
            {
                count++;
                if (string.IsNullOrEmpty(p)) continue;

                if (count == 36)
                {
                    var d = 1;
                }

                var line = p.Split("~");

                if (line[0].Contains("escort_id")) continue;
                for (var i = 0; i < line.Length; i++)
                {
                    if (string.IsNullOrEmpty(line[i])) continue;
                    line[i] = line[i].Replace("\"", string.Empty);
                }

                var es = new Escort { SiteName = siteName };

                var fParse = int.TryParse(line[0], out var value);
                if (!fParse) continue;
                es.EscortId = value;

                //if(es.EscortId == 575) continue;

                if (!string.IsNullOrEmpty(line[11])) es.Section = line[11];
                if (!string.IsNullOrEmpty(line[2])) es.EscortName = line[2];
                if (!string.IsNullOrEmpty(line[3]))
                {
                    var f = int.TryParse(line[3], out var age);
                    if (f) es.Age = age;
                }
                if (!string.IsNullOrEmpty(line[4]))
                {
                    var f = int.TryParse(line[4], out var bust);
                    es.Bust = f ? bust : GetRandom(1, 4);
                }
                else
                {
                    es.Bust = GetRandom(1, 4);
                }
                if (!string.IsNullOrEmpty(line[5])) es.Nationality = line[5];
                //if (!string.IsNullOrEmpty(line[7])) es.City = line[7];
                if (!string.IsNullOrEmpty(line[6]))
                {
                    var f = int.TryParse(line[6], out var weight);
                    if (f) es.Weight = weight;
                    if (es.Weight == 0) weight = GetRandom(115, 130);
                }
                if (!string.IsNullOrEmpty(line[7])) es.Height = line[7];
                if (!string.IsNullOrEmpty(line[8])) es.Hair = line[8];
                if (!string.IsNullOrEmpty(line[9])) es.Languages = line[9];
                if (!string.IsNullOrEmpty(line[10])) es.Statistics = line[10];

                
                if (!string.IsNullOrEmpty(line[24])) es.Description = line[24];

                for (var i = 12; i < 23; i++) 
                {
                    if (string.IsNullOrEmpty(line[i])) continue;
                    var fi = new FileImage { FileName = line[i], Escort = es };
                    _fileImage.Create(fi);
                }

                var f1 = await _escortRepository.Escorts
                    .Where(z => z.SiteName == es.SiteName && z.EscortName == es.EscortName).AnyAsync();
                if (f1) continue;

                //CorrectDouble(es);

                _escortRepository.Create(es);
                await _escortRepository.SaveChangesAsync();
            }
            await _escortRepository.SaveChangesAsync();
        }

        private static void CorrectDouble(Escort es)
        {
            if (es.EscortName == "Rachel" && es.City == "London")
            {
                es.EscortName = "Malvina";
            }
        }

        public async Task AddEscort2(string siteName, string fileName)
        {
            var path = $@"D:\!Download\{fileName}";
            using var reader = File.OpenText(path);
            var fileText = await reader.ReadToEndAsync();
            //var list = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string[] stringSeparators = new string[] { "\n\r" };
            string[] list = fileText.Split(stringSeparators, StringSplitOptions.None);
            foreach (var p in list)
            {
                if (string.IsNullOrEmpty(p)) continue;
                var line = p.Split("~");

                if (line[0].Contains("escort_id")) continue;
                for (var i = 0; i < line.Length; i++)
                {
                    if (string.IsNullOrEmpty(line[i])) continue;
                    line[i] = line[i].Replace("\"", string.Empty);
                }

                var es = new Escort { SiteName = siteName };

                var fParse = int.TryParse(line[0], out var value);
                if (!fParse) continue;
                es.EscortId = value;

                //if(es.EscortId == 575) continue;

                if (!string.IsNullOrEmpty(line[11])) es.Section = line[11];
                if (!string.IsNullOrEmpty(line[2])) es.EscortName = line[2];
                if (!string.IsNullOrEmpty(line[3]))
                {
                    var f = int.TryParse(line[3], out var age);
                    if (f) es.Age = age;
                }
                if (!string.IsNullOrEmpty(line[4]))
                {
                    var f = int.TryParse(line[4], out var bust);
                    es.Bust = f ? bust : GetRandom(1, 4);
                }
                else
                {
                    es.Bust = GetRandom(1, 4);
                }
                if (!string.IsNullOrEmpty(line[5])) es.Nationality = line[5];
                //if (!string.IsNullOrEmpty(line[7])) es.City = line[7];
                if (!string.IsNullOrEmpty(line[6]))
                {
                    var f = int.TryParse(line[6], out var weight);
                    if (f) es.Weight = weight;
                    if (es.Weight == 0) weight = GetRandom(115, 130);
                }
                if (!string.IsNullOrEmpty(line[7])) es.Height = line[7];
                if (!string.IsNullOrEmpty(line[8])) es.Hair = line[8];
                if (!string.IsNullOrEmpty(line[9])) es.Languages = line[9];
                if (!string.IsNullOrEmpty(line[10])) es.Statistics = line[10];


                if (!string.IsNullOrEmpty(line[23])) es.Description = line[23];

                for (var i = 12; i < 21; i++) //todo line.Length - 2
                {
                    if (string.IsNullOrEmpty(line[i])) continue;
                    var fi = new FileImage { FileName = line[i], Escort = es };
                    _fileImage.Create(fi);
                }

                var f1 = await _escortRepository.Escorts
                    .Where(z => z.SiteName == es.SiteName && z.EscortName == es.EscortName).AnyAsync();
                if (f1) continue;

                //CorrectDouble(es);

                _escortRepository.Create(es);
                await _escortRepository.SaveChangesAsync();
            }
            await _escortRepository.SaveChangesAsync();
        }

        private int GetRandom(int min, int max)
        {
            var r = new Random();
            return r.Next(min, max);
        }

        public async Task AddSiteTitleSiteDescriptionNew(string siteName, string fileName)
        {
            var path = $@"D:\!Download\{fileName}";
            using var reader = File.OpenText(path);
            var fileText = await reader.ReadToEndAsync();
            var list = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            //var escorts = await _escortRepository.Escorts.Where(z => z.SiteName == siteName).ToListAsync();

            foreach (var p in list)
            {
                if (string.IsNullOrEmpty(p)) continue;
                var line = p.Split("~");
                var txtTitle = new Text { SiteName = siteName };
                var txtDescription = new Text { SiteName = siteName };

                if (line[0] == "index")
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = "SiteTitleHome";
                    txtDescription.Position = "SiteDescriptionHome";
                }
                else
                if (line[0].Contains("asian"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAsianMassage";
                    txtDescription.Position = $"SiteDescriptionAsianMassage";
                }
                else
                if (line[0].Contains("outcall-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleOutcallMassage";
                    txtDescription.Position = $"SiteDescriptionOutCallMassage";
                }
                else
                if (line[0].Contains("korean"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleKoreanMassage";
                    txtDescription.Position = $"SiteDescriptionKoreanMassage";
                }
                else
                if (line[0].Contains("erotic-women"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEroticWomanMassage";
                    txtDescription.Position = $"SiteDescriptionEroticWomanMassage";
                }
                else
                if (line[0].Contains("erotic-couples"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEroticCouplesMassage";
                    txtDescription.Position = $"SiteDescriptionEroticCouplesMassage";
                }
                else
                if (line[0].Contains("inroom-couples"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleInroomCouplesMassage";
                    txtDescription.Position = $"SiteDescriptionInroomCouplesMassage";
                }
                else
                if (line[0].Contains("romantic-couples"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleRomanticCouplesMassage";
                    txtDescription.Position = $"SiteDescriptionRomanticCouplesMassage";
                }
                else
                if (line[0].Contains("couples"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleCouplesMassage";
                    txtDescription.Position = $"SiteDescriptionCouplesMassage";
                }
                else
                if (line[0].Contains("oriental"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleOrientalMassage";
                    txtDescription.Position = $"SiteDescriptionOrientalMassage";
                }
                else
                if (line[0].Contains("what-happens-tantra"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleHappensTantraMassage";
                    txtDescription.Position = $"SiteDescriptionHappensTantraMassage";
                }
                else
                if (line[0].Contains("what-is-body-rubs"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBodyRubsMassage";
                    txtDescription.Position = $"SiteDescriptionBodyRubsMassage";
                }
                else
                if (line[0].Contains("what-is-tantra"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleTantraMassage";
                    txtDescription.Position = $"SiteDescriptionTantraMassage";
                }
                else
                if (line[0].Contains("about-outcall-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAboutOutcallMassage";
                    txtDescription.Position = $"SiteDescriptionAboutOutcallMassage";
                }
                else
                if (line[0].Contains("nuru-massage-definition"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNuruDefinitionMassage";
                    txtDescription.Position = $"SiteDescriptionNuruDefinitionMassage";
                }
                else
                if (line[0].Contains("is-nuru-massage-legal"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNuruLegalMassage";
                    txtDescription.Position = $"SiteDescriptionNuruLegalMassage";
                }
                else
                if (line[0].Contains("where-to-get-a-nuru-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleGetNuruMassage";
                    txtDescription.Position = $"SiteDescriptionGetNuruMassage";
                }
                else
                if (line[0].Contains("how-to-give-a-nuru-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleGiveNuruMassage";
                    txtDescription.Position = $"SiteDescriptionGiveNuruMassage";
                }
                else
                if (line[0].Contains("nuru-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNuruMassage";
                    txtDescription.Position = $"SiteDescriptionNuruMassage";
                }
                else
                if (line[0].Contains("erotic-massage-benefits"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEroticBenefitsMassage";
                    txtDescription.Position = $"SiteDescriptionEroticBenefitsMassage";
                }
                else
                if (line[0].Contains("massage-benefits"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMassageBenefitsMassage";
                    txtDescription.Position = $"SiteDescriptionMassageBenefitsMassage";
                }
                else
                if (line[0].Contains("where-to-get-erotic-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleGetEroticMassage";
                    txtDescription.Position = $"SiteDescriptionGetEroticMassage";
                }
                else
                if (line[0].Contains("what-is-an-erotic-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleWhatEroticMassage";
                    txtDescription.Position = $"SiteDescriptionWhatEroticMassage";
                }
                else
                if (line[0].Contains("what-happens-during-an-erotic-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleHappensEroticMassage";
                    txtDescription.Position = $"SiteDescriptionHappensEroticMassage";
                }
                else
                if (line[0].Contains("what-to-expect-erotic-massage"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleExpectEroticMassage";
                    txtDescription.Position = $"SiteDescriptionExpectEroticMassage";
                }
                else
                if (line[0].Contains("what-does-erotic-massage-mean"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEroticMeanMassage";
                    txtDescription.Position = $"SiteDescriptionEroticMeanMassage";
                }


                else
                if (line[0].Contains("about-us"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAboutUs";
                    txtDescription.Position = $"SiteDescriptionAboutUs";
                }
                else
                if (line[0].Contains("booking"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBooking";
                    txtDescription.Position = $"SiteDescriptionBooking";
                }
                else
                if (line[0].Contains("contact"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleContact";
                    txtDescription.Position = $"SiteDescriptionContact";
                }
                else
                if (line[0].Contains("employment"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEmployment";
                    txtDescription.Position = $"SiteDescriptionEmployment";
                }
                else
                {
                    continue;
                }

                var f = _textRepository.Texts.Any(z => z.SiteName == siteName && (z.Position == txtTitle.Position || z.Position == txtDescription.Position));
                if (f)
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(txtTitle.Position) && !string.IsNullOrEmpty(txtTitle.Description))
                {
                    f = _textRepository.Texts.Any(z => z.SiteName == Constants.SiteName &&
                                                       z.Position == txtTitle.Position);
                    if (f) _textRepository.Update(txtTitle);
                    else _textRepository.Create(txtTitle);
                }

                if (!string.IsNullOrEmpty(txtDescription.Position) && !string.IsNullOrEmpty(txtDescription.Description))
                {
                    f = _textRepository.Texts.Any(z => z.SiteName == Constants.SiteName &&
                                                       z.Position == txtDescription.Position);
                    if (f) _textRepository.Update(txtDescription);
                    else _textRepository.Create(txtDescription);
                }
            }
            //await _textRepository.SaveChangesAsync();
        }

        public async Task BuildEscorts(string siteName, string path)
        {
            var dirs = new List<string>(Directory.EnumerateDirectories(path));
            foreach (var dir in dirs)
            {
                var folderName = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                var folderMenu = new List<string>(Directory.EnumerateDirectories(dir));
                foreach (var fol in folderMenu)
                {
                    var escort = new Escort {SiteName = siteName, City = folderName};
                    var escortFolder = $"{fol.Substring(fol.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                    escort.EscortName = escortFolder.OnlyLetter();
                    _escortRepository.Create(escort);
                    await _escortRepository.SaveChangesAsync();
                    var escortImages = new List<string>(Directory.EnumerateFiles(fol));
                    foreach (var image in escortImages)
                    {
                        var fileImage = new FileImage {Escort = escort};
                        fileImage.FileName = image.Replace($@"{path}\", string.Empty);
                        _fileImage.Create(fileImage);
                    }
                }

                await _fileImage.SaveChangesAsync();
            }
        }

        public async Task AddSiteTitleSiteDescription(string siteName, string fileName)
        {
            var path = $@"D:\!Download\{fileName}";
            using var reader = File.OpenText(path);
            var fileText = await reader.ReadToEndAsync();
            var list = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var escorts = await _escortRepository.Escorts.Where(z => z.SiteName == siteName).ToListAsync();
            
            foreach (var p in list)
            {
                if (string.IsNullOrEmpty(p)) continue;
                var line = p.Split("~");
                var txtTitle = new Text{SiteName = siteName};
                var txtDescription = new Text { SiteName = siteName };

                if(!line[0].Contains(siteName)) return;

                if (line[0] == $"http://{siteName}/")
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = "SiteTitleHome";
                    txtDescription.Position = "SiteDescriptionHome";
                }
                else
                if (line[0].Contains("?escort_id"))
                {
                    var index = line[0].IndexOf("?escort_id=", StringComparison.Ordinal);
                    var id = line[0].Substring(index + 11);
                    var fParse = int.TryParse(id, out var value);
                    if (!fParse)
                    {
                        return;
                    };
                    fParse = escorts.Any(z => z.EscortId == value);
                    if (!fParse)
                    {
                        return;
                    }
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleProfile-{id}";
                    txtDescription.Position = $"SiteDescriptionProfile-{id}";
                }
                else
                if (line[0].Contains("profile.php?id="))
                {
                    var index = line[0].IndexOf("?id=", StringComparison.Ordinal);
                    var id = line[0].Substring(index + 4);
                    var fParse = int.TryParse(id, out var value);
                    if (!fParse)
                    {
                        return;
                    };
                    fParse = escorts.Any(z => z.EscortId == value);
                    if (!fParse)
                    {
                        return;
                    }
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleProfile-{id}";
                    txtDescription.Position = $"SiteDescriptionProfile-{id}";
                }
                else
                if (line[0].Contains("employment.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEmployment";
                    txtDescription.Position = $"SiteDescriptionEmployment";
                }
                else
                if (line[0].Contains("london-asian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonAsianEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonAsianEscorts";
                }
                else
                if (line[0].Contains("london-bbw-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonBbwEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonBbwEscorts";
                }
                else
                if (line[0].Contains("manchester-asian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleManchesterAsianEscorts";
                    txtDescription.Position = $"SiteDescriptionManchesterAsianEscorts";
                }
                else
                if (line[0].Contains("manchester-elite-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleManchesterEliteEscorts";
                    txtDescription.Position = $"SiteDescriptionManchesterEliteEscorts";
                }
                else
                if (line[0].Contains("birmingham-asian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamAsianEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamAsianEscorts";
                }
                else
                if (line[0].Contains("liverpool-asian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLiverpoolAsianEscorts";
                    txtDescription.Position = $"SiteDescriptionLiverpoolAsianEscorts";
                }
                else
                if (line[0].Contains("liverpool-bbw-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLiverpoolBbwEscorts";
                    txtDescription.Position = $"SiteDescriptionLiverpoolBbwEscorts";
                }
                else
                if (line[0].Contains("bristol-asian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBristolAsianEscorts";
                    txtDescription.Position = $"SiteDescriptionBristolAsianEscorts";
                }
                else
                if (line[0].Contains("bristol-bbw-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBristolBbwEscorts";
                    txtDescription.Position = $"SiteDescriptionBbwAsianEscorts";
                }
                else
                if (line[0].Contains("london-black-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonBlackEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonBlackEscorts";
                }
                else
                if (line[0].Contains("manchester-black-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleManchesterBlackEscorts";
                    txtDescription.Position = $"SiteDescriptionManchesterBlackEscorts";
                }
                else
                if (line[0].Contains("birmingham-black-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamBlackEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamBlackEscorts";
                }
                else
                if (line[0].Contains("liverpool-black-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLiverpoolBlackEscorts";
                    txtDescription.Position = $"SiteDescriptionLiverpoolBlackEscorts";
                }
                else
                if (line[0].Contains("london-busty-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonBustEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonBustEscorts";
                }
                else
                if (line[0].Contains("london-cheap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonCheapEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonCheapEscorts";
                }
                else
                if (line[0].Contains("manchester-cheap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleManchesterCheapEscorts";
                    txtDescription.Position = $"SiteDescriptionManchesterCheapEscorts";
                }
                else
                if (line[0].Contains("birmingham-cheap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamCheapEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamCheapEscorts";
                }
                else
                if (line[0].Contains("liverpool-cheap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLiverpoolCheapEscorts";
                    txtDescription.Position = $"SiteDescriptionLiverpoolCheapEscorts";
                }
                else
                if (line[0].Contains("bristol-cheap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBristolCheapEscorts";
                    txtDescription.Position = $"SiteDescriptionBristolCheapEscorts";
                }
                else
                if (line[0].Contains("london-high-class-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonHighEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonHighEscorts";
                }
                else
                if (line[0].Contains("birmingham-high-class-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamHighEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamHighEscorts";
                }
                else
                if (line[0].Contains("london-indian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonIndianEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonIndianEscorts";
                }
                else
                if (line[0].Contains("manchester-indian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleManchesterIndianEscorts";
                    txtDescription.Position = $"SiteDescriptionManchesterIndianEscorts";
                }
                else
                if (line[0].Contains("birmingham-indian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamIndianEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamIndianEscorts";
                }
                else
                if (line[0].Contains("indian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleIndianEscorts";
                    txtDescription.Position = $"SiteDescriptionIndianEscorts";
                }
                else
                if (line[0].Contains("london-mature-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLondonMatureEscorts";
                    txtDescription.Position = $"SiteDescriptionLondonMatureEscorts";
                }
                else
                if (line[0].Contains("manchester-mature-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleManchesterMatureEscorts";
                    txtDescription.Position = $"SiteDescriptionManchesterMatureEscorts";
                }
                else
                if (line[0].Contains("birmingham-mature-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamMatureEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamMatureEscorts";
                }
                else
                if (line[0].Contains("liverpool-mature-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLiverpoolMatureEscorts";
                    txtDescription.Position = $"SiteDescriptionLiverpoolMatureEscorts";
                }
                else
                if (line[0].Contains("bristol-mature-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBristolMatureEscorts";
                    txtDescription.Position = $"SiteDescriptionBristolMatureEscorts";
                }
                else
                if (line[0].Contains("birmingham-outcall-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBirminghamOutcallEscorts";
                    txtDescription.Position = $"SiteDescriptionBirminghamOutcallEscorts";
                }
                else
                if (line[0].Contains("cheap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleCheap";
                    txtDescription.Position = $"SiteDescriptionCheap";
                }
                else
                if (line[0].Contains("bbw-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBBW";
                    txtDescription.Position = $"SiteDescriptionBbw";
                }
                else
                if (line[0].Contains("fetish-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleFetish";
                    txtDescription.Position = $"SiteDescriptionFetish";
                }
                else
                if (line[0].Contains("ebony-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEbony";
                    txtDescription.Position = $"SiteDescriptionEbony";
                }
                else
                if (line[0].Contains("about.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAbout";
                    txtDescription.Position = $"SiteDescriptionAbout";
                }
                else
                if (line[0].Contains("contact.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleContact";
                    txtDescription.Position = $"SiteDescriptionContact";
                }
                else
                if (line[0].Contains("gfe-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleGfeEscorts";
                    txtDescription.Position = $"SiteDescriptionGfeEscorts";
                }
                else
                if (line[0].Contains("asian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAsian";
                    txtDescription.Position = $"SiteDescriptionAsian";
                }
                else
                if (line[0].Contains("booking.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBooking";
                    txtDescription.Position = $"SiteDescriptionBooking";
                }
                else
                if (line[0].Contains("mature-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMature";
                    txtDescription.Position = $"SiteDescriptionMature";
                }
                else
                if (line[0].Contains("latina-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLatina";
                    txtDescription.Position = $"SiteDescriptionLatina";
                }
                else
                if (line[0].Contains("latinas-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLatina";
                    txtDescription.Position = $"SiteDescriptionLatina";
                }
                else
                if (line[0].Contains("black-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBlack";
                    txtDescription.Position = $"SiteDescriptionBlack";
                }
                else
                if (line[0].Contains("busty-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBusty";
                    txtDescription.Position = $"SiteDescriptionBusty";
                }
                else
                if (line[0].Contains("girlfriend-experience.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleGirlfriend";
                    txtDescription.Position = $"SiteDescriptionGirlfriend";
                }
                else
                if (line[0].Contains("big-booty-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBigBooty";
                    txtDescription.Position = $"SiteDescriptionBigBooty";
                }
                else
                if (line[0].Contains("checap-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleChecapEscorts";
                    txtDescription.Position = $"SiteDescriptionChecapEscorts";
                }
                else
                if (line[0].Contains("gfe.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleGfe";
                    txtDescription.Position = $"SiteDescriptionGfe";
                }
                else
                if (line[0].Contains("blonde-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBlondeEscorts";
                    txtDescription.Position = $"SiteDescriptionBlondeEscorts";
                }
                else
                if (line[0].Contains("russian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleRussianEscorts";
                    txtDescription.Position = $"SiteDescriptionRussianEscorts";
                }
                else
                if (line[0].Contains("miami-gardens.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMiamiGardenEscorts";
                    txtDescription.Position = $"SiteDescriptionMiamiGardenEscorts";
                }
                else
                if (line[0].Contains("miami-south.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMiamiSouthEscorts";
                    txtDescription.Position = $"SiteDescriptionMiamiSouthEscorts";
                }
                else
                if (line[0].Contains("miami-north.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMiamiNorthEscorts";
                    txtDescription.Position = $"SiteDescriptionMiamiNorthEscorts";
                }
                else
                if (line[0].Contains("miami-airport.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMiamiAirportEscorts";
                    txtDescription.Position = $"SiteDescriptionMiamiAirportEscorts";
                }
                else
                if (line[0].Contains("miami-lakes.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMiamiLakesEscorts";
                    txtDescription.Position = $"SiteDescriptionMiamiLakesEscorts";
                }
                else
                if (line[0].Contains("vip-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleVipEscorts";
                    txtDescription.Position = $"SiteDescriptionVipEscorts";
                }
                else
                if (line[0].Contains("lombard-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleLombardEscorts";
                    txtDescription.Position = $"SiteDescriptionLombardEscorts";
                }
                else
                if (line[0].Contains("independent-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleIndependentEscorts";
                    txtDescription.Position = $"SiteIndependentLombardEscorts";
                }
                else
                if (line[0].Contains("naperville-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNapervilleEscorts";
                    txtDescription.Position = $"SiteDescriptionNapervilleEscorts";
                }
                else
                if (line[0].Contains("ohare-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleOhareEscorts";
                    txtDescription.Position = $"SiteDescriptionOhareEscorts";
                }
                else
                if (line[0].Contains("schaumburg-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleSchaumburgEscorts";
                    txtDescription.Position = $"SiteDescriptionSchaumburgEscorts";
                }
                else
                if (line[0].Contains("quincy-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleQuincyEscorts";
                    txtDescription.Position = $"SiteDescriptionQuincyEscorts";
                }
                else
                if (line[0].Contains("braintree-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBraintreeEscorts";
                    txtDescription.Position = $"SiteDescriptionBraintreeEscorts";
                }
                else
                if (line[0].Contains("skokie-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleSkokieEscorts";
                    txtDescription.Position = $"SiteDescriptionSkokieEscorts";
                }
                else
                if (line[0].Contains("brunette-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBrunetteEscorts";
                    txtDescription.Position = $"SiteDescriptionBrunetteEscorts";
                }
                else
                if (line[0].Contains("outcall-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleOutcallEscorts";
                    txtDescription.Position = $"SiteDescriptionOutcallEscorts";
                }
                else
                if (line[0].Contains("erotic-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEroticMassage";
                    txtDescription.Position = $"SiteDescriptionEroticMassage";
                }
                else
                if (line[0].Contains("body-rubs.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBodyRubs";
                    txtDescription.Position = $"SiteDescriptionBodyRubs";
                }
                else
                if (line[0].Contains("asian.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAsianMassage";
                    txtDescription.Position = $"SiteDescriptionAsianMassage";
                }
                else
                if (line[0].Contains("in-room.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleInRoomMassage";
                    txtDescription.Position = $"SiteDescriptionInRoomMassage";
                }
                else
                if (line[0].Contains("couples-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleCouplesEscorts";
                    txtDescription.Position = $"SiteDescriptionCouplesEscorts";
                }
                else
                if (line[0].Contains("full-body-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleFullBody";
                    txtDescription.Position = $"SiteDescriptionFullBody";
                }
                else
                if (line[0].Contains("full-body.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleFullBody";
                    txtDescription.Position = $"SiteDescriptionFullBody";
                }
                else
                if (line[0].Contains("happy-ending-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleHappyEnding";
                    txtDescription.Position = $"SiteDescriptionHappyEnding";
                }
                else
                if (line[0].Contains("happy-ending.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleHappyEnding";
                    txtDescription.Position = $"SiteDescriptionHappyEnding";
                }
                else
                if (line[0].Contains("nuru-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNuru";
                    txtDescription.Position = $"SiteDescriptionNuru";
                }
                else
                if (line[0].Contains("nuru.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNuru";
                    txtDescription.Position = $"SiteDescriptionNuru";
                }
                else
                if (line[0].Contains("escort-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEscortMassage";
                    txtDescription.Position = $"SiteDescriptionEscortMassage";
                }
                else
                if (line[0].Contains("tantra-massage.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleTantra";
                    txtDescription.Position = $"SiteDescriptionTantra";
                }
                else
                if (line[0].Contains("tantra.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleTantra";
                    txtDescription.Position = $"SiteDescriptionTantra";
                }
                else
                if (line[0].Contains("erotic.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleErotic";
                    txtDescription.Position = $"SiteDescriptionErotic";
                }
                else
                if (line[0].Contains("outcall.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleOutcall";
                    txtDescription.Position = $"SiteDescriptionOutcall";
                }
                else
                if (line[0].Contains("sex.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleSex";
                    txtDescription.Position = $"SiteDescriptionSex";
                }
                else
                if (line[0].Contains("arab-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleArabEscorts";
                    txtDescription.Position = $"SiteDescriptionArabEscorts";
                }
                else
                if (line[0].Contains("iranian-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleIranianEscorts";
                    txtDescription.Position = $"SiteDescriptionIranianEscorts";
                }
                else
                if (line[0].Contains("strapon-escort.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleStraponEscorts";
                    txtDescription.Position = $"SiteDescriptionStraponEscorts";
                }
                else
                if (line[0].Contains("bisexual-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBisexualEscorts";
                    txtDescription.Position = $"SiteDescriptionBisexualEscorts";
                }
                else
                if (line[0].Contains("escorts-for-couples.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleForCouplesEscorts";
                    txtDescription.Position = $"SiteDescriptionForCouplesEscorts";
                }
                else
                if (line[0].Contains("escort.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleEscortMassage";
                    txtDescription.Position = $"SiteDescriptionEscortMassage";
                }
                else
                if (line[0].Contains("couples.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleCouplesEscorts";
                    txtDescription.Position = $"SiteDescriptionCouplesEscorts";
                }
                else
                if (line[0].Contains("big-island-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBigIslandEscorts";
                    txtDescription.Position = $"SiteDescriptionBigIslandEscorts";
                }
                else
                if (line[0].Contains("kauai-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleKauaiEscorts";
                    txtDescription.Position = $"SiteDescriptionKauaiEscorts";
                }
                else
                if (line[0].Contains("maui-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMauiEscorts";
                    txtDescription.Position = $"SiteDescriptionMauiEscorts";
                }
                else
                if (line[0].Contains("oahu-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleOahuEscorts";
                    txtDescription.Position = $"SiteDescriptionOahuEscorts";
                }
                else
                if (line[0].Contains("honolulu-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleHonoluluEscorts";
                    txtDescription.Position = $"SiteDescriptionHonoluluEscorts";
                }
                else
                if (line[0].Contains("kona-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleKonaEscorts";
                    txtDescription.Position = $"SiteDescriptionKonaEscorts";
                }
                else
                if (line[0].Contains("hilo-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleHiloEscorts";
                    txtDescription.Position = $"SiteDescriptionHiloEscorts";
                }
                else
                if (line[0].Contains("airport-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleAirportEscorts";
                    txtDescription.Position = $"SiteDescriptionAirportEscorts";
                }
                else
                if (line[0].Contains("northeast-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleNortheastEscorts";
                    txtDescription.Position = $"SiteDescriptionNortheastEscorts";
                }
                else
                if (line[0].Contains("cherryhills-escorts.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleCherryhillsEscorts";
                    txtDescription.Position = $"SiteDescriptionCherryhillsEscorts";
                }
                else
                if (line[0].Contains("mature.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleMatureEscorts";
                    txtDescription.Position = $"SiteDescriptionMatureEscorts";
                }
                else
                if (line[0].Contains("bbw.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleBbwEscorts";
                    txtDescription.Position = $"SiteDescriptionBbwEscorts";
                }
                else
                if (line[0].Contains("cheap.php"))
                {
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleCheapEscorts";
                    txtDescription.Position = $"SiteDescriptionCheapEscorts";
                }
                else
                if(!string.IsNullOrEmpty(line[0]))
                {
                    var index = line[0].LastIndexOf("/", StringComparison.Ordinal);
                    if(index < 3) continue;
                    var t = line[0].Substring(index + 1);
                    if(string.IsNullOrEmpty(t)) continue;
                    var name = t.Replace(".php", "");
                    if(string.IsNullOrEmpty(name)) continue;
                    var id = escorts.Where(z => z.EscortName.ToLower() == name).Select(z=>z.EscortId).FirstOrDefault();
                    if(id == 0) continue;
                    txtTitle.Description = line[1];
                    txtDescription.Description = line[2];
                    txtTitle.Position = $"SiteTitleProfile-{id}";
                    txtDescription.Position = $"SiteDescriptionProfile-{id}";
                }
                else
                {
                    continue;
                }

                var f = _textRepository.Texts.Any(z => z.SiteName == siteName && (z.Position == txtTitle.Position || z.Position == txtDescription.Position));
                if (f)
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(txtTitle.Position) && !string.IsNullOrEmpty(txtTitle.Description))
                {
                    f = _textRepository.Texts.Any(z => z.SiteName == Constants.SiteName &&
                                                       z.Position == txtTitle.Position);
                    if (f) _textRepository.Update(txtTitle);
                    else  _textRepository.Create(txtTitle);
                }

                if (!string.IsNullOrEmpty(txtDescription.Position) && !string.IsNullOrEmpty(txtDescription.Description))
                {
                    f = _textRepository.Texts.Any(z => z.SiteName == Constants.SiteName &&
                                                       z.Position == txtDescription.Position);
                    if (f) _textRepository.Update(txtDescription);
                    else _textRepository.Create(txtDescription);
                }
            }
            await _textRepository.SaveChangesAsync();
        }

        public async Task AddParserTexts(string site)
        {

            await AddMassagePage($"https://{Constants.SiteName}/korean.php", "PositionBodyRubs");
            await AddMassagePage($"https://{Constants.SiteName}/asian.php", "PositionAsian");
            //await AddMassagePage($"https://{Constants.SiteName}/couples-massage.php", "PositionCouples");
            //await AddMassagePage($"https://{Constants.SiteName}/full-body-massage.php", "PositionFullBody");
            //await AddMassagePage($"https://{Constants.SiteName}/happy-ending-massage.php", "PositionHappyEnding");
            await AddMassagePage($"https://{Constants.SiteName}/nuru-massage.php", "PositionNuru");
            //await AddMassagePage($"https://{Constants.SiteName}/tantra-massage.php", "PositionTantra");

            //await AddMassagePage($"https://{Constants.SiteName}/asian.php", "PositionAsianMassage");
            //await AddMassagePage($"https://{Constants.SiteName}/body-rubs.php", "PositionBodyRubs");
            //await AddMassagePage($"https://{Constants.SiteName}/couples.php", "PositionCouples");
            //await AddMassagePage($"https://{Constants.SiteName}/escort.php", "PositionEscortMassage");
            //await AddMassagePage($"https://{Constants.SiteName}/full-body.php", "PositionFullBody");
            //await AddMassagePage($"https://{Constants.SiteName}/happy-ending.php", "PositionHappyEnding");
            //await AddMassagePage($"https://{Constants.SiteName}/in-room.php", "PositionInRoomMassage");
            //await AddMassagePage($"https://{Constants.SiteName}/nuru.php", "PositionNuru");
            await AddMassagePage($"https://{Constants.SiteName}/outcall-massage.php", "PositionOutcallMassage");
            //await AddMassagePage($"https://{Constants.SiteName}/tantra.php", "PositionTantra");
            //await AddMassagePage($"https://{Constants.SiteName}/erotic.php", "PositionErotic");
            //await AddMassagePage($"https://{Constants.SiteName}/sex.php", "PositionSexMassage");

            //await AddMassagePage($"https://{Constants.SiteName}/escort-massage.php", "PositionEscortMassage");

            //https://www.dreamgirlshawaii.com/#all
            var url = $"https://{Constants.SiteNameSsl}";
            var s = await ReadPage(url);
            if (!string.IsNullOrEmpty(s))
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(s);

                //await BuildMenuEscorts(doc);

                var node = doc.DocumentNode.SelectSingleNode(".//div[@class='static_banner_content']");
                var strString = node.SelectNodes(".//h1").First().InnerText; //todo
                //var strString = "Welcome";
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0].OuterHtml;
                var strHtml = string.Empty;
                var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='common_page_container clearfix']")[0].InnerHtml; //todo 1

                //var node1 = doc.DocumentNode.SelectNodes(".//div[@class='row']")[2];
                //var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[1].InnerHtml;
                //var strHtml1 = node1.OuterHtml;
                //var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[1].InnerHtml;

                var scriptsList = doc.DocumentNode.Descendants().Where(z => z.Name == "script").ToList();
                foreach (var p in scriptsList)
                {
                    if (!p.InnerText.Contains("GoogleAnalyticsObject")) continue;
                    _textRepository.Create(new Text
                    {
                        SiteName = site, Position = "GoogleAnalyticsObject", 
                        Description = $"<script>{p.InnerText}</script>"
                    });
                    break;
                }

                _textRepository.Create(new Text { SiteName = site, Position = "PositionHomeTopTitle", Description = strString });
                _textRepository.Create(new Text { SiteName = site, Position = "PositionHomeTop", Description = strHtml });
                _textRepository.Create(new Text { SiteName = site, Position = "PositionHomeBottom", Description = strHtml1 });

            }
            else
            {
                _textRepository.Create(new Text { SiteName = site, Position = "PositionHomeTopTitle" });
                _textRepository.Create(new Text {SiteName = site, Position = "PositionHomeTop" });
                _textRepository.Create(new Text { SiteName = site, Position = "PositionHomeBottom" });
            }

            await _textRepository.SaveChangesAsync();

            //Escorts 
            //var escortsSub = await _menuRepository.Menus
            //    .Where(z => z.SiteName == Constants.SiteName).ToListAsync();
            //WE COVER MENU
            //escortsSub.Add(new Menu { Name = "Asian Escorts", Href = "asian-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Black Escorts", Href = "black-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Russian Escorts", Href = "russian-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Busty Escorts", Href = "busty-escorts.php" });
            //escortsSub.Add(new Menu { Name = "VIP Escorts", Href = "vip-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Cheap Escorts", Href = "cheap-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Outcall Escorts", Href = "outcall-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Arab Escorts", Href = "arab-escorts.php" });
            //escortsSub.Add(new Menu { Name = "BBW Escorts", Href = "bbw-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Iranian Escorts", Href = "iranian-escorts.php" });
            //escortsSub.Add(new Menu { Name = "Mature Escorts", Href = "mature-escorts.php" });

            //escortsSub.Add(new Menu { Name = "Strapon Escorts", Href = "strapon-escort.php" });
            //escortsSub.Add(new Menu { Name = "Mistress Escorts", Href = "mistress-escorts.php" });


            //todo if menu Escorts
            //foreach (var p in escortsSub)
            //{
            //    var cityName = $"{p.Name.Trim()}";
            //    var name = cityName.Replace(" ", "-");
            //    await AddEscorts($"https://{Constants.SiteNameSsl}/{p.Href}", $"EscortsHeading{name}", $"PositionEscorts{name}Top", $"PositionEscorts{name}Bottom");
            //}

            await _textRepository.SaveChangesAsync();

            await AddAboutPage();
        }

        private async Task AddAboutPage()
        {
            var url = $"https://{Constants.SiteNameSsl}/about-us.php";
            var s = await ReadPage(url);
            if (!string.IsNullOrEmpty(s))
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(s);
                var strString = doc.DocumentNode.SelectNodes(".//h1[@class='heading']").First().InnerText;
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='common_page_container clearfix']")[0].InnerHtml;
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='common_page_container clearfix']")[0].OuterHtml;

                var strHtml = doc.DocumentNode.SelectSingleNode(".//div[@class='container_area border_radius bg_boston']").InnerHtml;

                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = "PositionAbout", Description = strString });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = "SiteDescriptionPageAbout", Description = strHtml });

            }
            else
            {
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = "PositionAbout" });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = "SiteDescriptionPageAbout" });
            }

            await _textRepository.SaveChangesAsync();
        }

        private async Task AddMassagePage(string url, string name)
        {
            
            var s = await ReadPage(url);
            if (!string.IsNullOrEmpty(s))
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(s);
                var strString = doc.DocumentNode.SelectNodes(".//h1[@class='heading']").First().InnerText;
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='container_area border_radius bg_new_york']")[0].InnerHtml; //todo 1
                //var strHtml = doc.DocumentNode.SelectSingleNode(".//div[@class='common_page_container']").OuterHtml;
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0].InnerHtml;

                var node = doc.DocumentNode.SelectNodes(".//div[@class='common_page_container clearfix']")[0];
                //foreach (var p in node.ChildNodes)
                //{
                //    var dd = p.OuterHtml;
                //}
                var strHtml = $"{node.ChildNodes[1].OuterHtml} {node.ChildNodes[3].OuterHtml} {node.ChildNodes[4].OuterHtml} {node.ChildNodes[6].OuterHtml}";

                //var node1 = doc.DocumentNode.SelectNodes(".//div[@class='row']")[2];
                //var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[1].InnerHtml;
                //var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='site_content_area']")[0].InnerHtml;
                var strHtml1 = "ADD TEXT";
                //var strHtml1 = node1.InnerHtml;
                //var strHtml1 = doc.DocumentNode.SelectSingleNode(".//div[@class='site_content_area']").OuterHtml;

                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = $"{name}Title", Description = strString });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = $"{name}Top", Description = strHtml });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = $"{name}Bottom", Description = strHtml1 });
            }
            else
            {
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = $"{name}Title" });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = $"{name}Top" });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = $"{name}Bottom" });
            }

            await _textRepository.SaveChangesAsync();
        }

        private async Task BuildMenuEscorts(HtmlDocument doc)
        {
            //var menuName = new List<string> {"London", "Manchester", "Birmingham", "Liverpool", "Bristol"};
            //var menuEscortLi = doc.DocumentNode.SelectNodes(".//ul[@class='sub-menu']").First()
            //    .SelectNodes("./li");
            var menuEscort = doc.DocumentNode.SelectNodes(".//ul[@class='sub-menu']");
            //for(var i=0; i < 5; i++)
            //{
                var menuEscortLi = menuEscort[0].SelectNodes("./li");
                foreach (var p in menuEscortLi)
                {
                    var name = p.InnerText;
                    var href = p.SelectNodes("./a").First().GetAttributeValue("href", string.Empty);
                    _menuRepository.Create(new Menu
                    {
                        SiteName = Constants.SiteName,
                        //MenuName = menuName[i],
                        Name = name,
                        Href = href.Replace("/", string.Empty)
                    }); ;
                }
            //var menuEscortL1I = menuEscort[1].SelectNodes("./li");
            //foreach (var p in menuEscortL1I)
            //{
            //    var name = p.InnerText;
            //    var href = p.SelectNodes("./a").First().GetAttributeValue("href", string.Empty);
            //    _menuRepository.Create(new Menu
            //    {
            //        SiteName = Constants.SiteName,
            //        //MenuName = menuName[i],
            //        Name = name,
            //        Href = href.Replace("/", string.Empty)
            //    }); ;
            //}
            //}

            await _menuRepository.SaveChangesAsync();
        }

        private async Task AddEscorts(string url, string heading, string top, string bottom)
        {
            var s = await ReadPage(url);
            if (!string.IsNullOrEmpty(s))
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(s);
                var strString = doc.DocumentNode.SelectNodes(".//h1[@class='heading']").First().InnerText;
                //var strHtml = doc.DocumentNode.SelectSingleNode(".//div[@class='col-sm-12 col-md-12 col-lg-12']").OuterHtml;
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0].InnerHtml;
                //var strHtml = doc.DocumentNode.SelectNodes(".//div[@class='main_container_block escorts_display_page']")[0].SelectNodes(".//p").First().OuterHtml + " <br>";
                //var strHtml1 = string.Empty;
                //try
                //{
                //    strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[1].InnerHtml;
                //}
                //catch (Exception)
                //{

                //}

                var nodes = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0];
                //foreach (var p in nodes.ChildNodes)
                //{
                //    var d = p.OuterHtml;
                //}
                var strHtml = $"{nodes.ChildNodes[1].OuterHtml} {nodes.ChildNodes[3].OuterHtml} {nodes.ChildNodes[4].OuterHtml} {nodes.ChildNodes[6].OuterHtml}";
                var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='site_content_area']")[0].OuterHtml;
                //var strString = string.Empty;
                //var htmlNodes = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']");
                //var strHtml = string.Empty;
                //string strHtml1;
                //if (htmlNodes.Count > 1)
                //{
                //    strHtml = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0].InnerHtml;
                //    strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[1].InnerHtml;
                //}
                //else
                //{
                //    strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0].InnerHtml;
                //}

                //var nodes = doc.DocumentNode.SelectNodes(".//div[@class='row']")[0];
                //var strHtml1 = string.Empty;
                //foreach (var p in nodes.ChildNodes)
                //{
                //    if (p.Name == "div") break;
                //    strHtml1 += $"{p.OuterHtml}";
                //}

                //var strHtml1 = doc.DocumentNode.SelectNodes(".//div[@class='custom_content_block clearfix']")[0].InnerHtml;

                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = heading, Description = strString });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = top, Description = strHtml });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = bottom, Description = strHtml1 });

            }
            else
            {
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = heading });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = top });
                _textRepository.Create(new Text { SiteName = Constants.SiteName, Position = bottom });
            }
        }

        private static async Task<string> ReadPage(string url)
        {
            try
            {
                using var client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false });
                var response = await client.GetAsync(url);
                var s = await response.Content.ReadAsStringAsync();
                return !response.IsSuccessStatusCode ? string.Empty : s;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}
