using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Setting
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
