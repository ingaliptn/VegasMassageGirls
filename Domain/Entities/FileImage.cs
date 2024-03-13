using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class FileImage
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FileName { get; set; }
        public virtual Escort Escort { get; set; }
    }
}
