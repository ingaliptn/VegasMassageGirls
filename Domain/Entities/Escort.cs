using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Escort
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string SiteName { get; set; }
        [MaxLength(50)]
        public string Section { get; set; }
        [MaxLength(30)]
        public string EscortName { get; set; }
        public int Age { get; set; }
        public int Bust { get; set; }
        [MaxLength(20)]
        public string Nationality { get; set; }
        public int Weight { get; set; }
        [MaxLength(10)]
        public string Height { get; set; }
        [MaxLength(20)]
        public string Hair { get; set; }
        [MaxLength(100)]
        public string Languages { get; set; }
        [MaxLength(10)]
        public string Statistics { get; set; }
        public string Description { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        public int EscortId { get; set; }
        public ICollection<FileImage> FileImages { get; set; } = new List<FileImage>();
    }
}
