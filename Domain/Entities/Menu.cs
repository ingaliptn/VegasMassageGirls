using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string SiteName { get; set; }
        [MaxLength(50)]
        public string MenuName { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Href { get; set; }
    }
}
