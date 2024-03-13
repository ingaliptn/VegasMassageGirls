using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Text
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string SiteName { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        public string Description { get; set; }
    }
}
