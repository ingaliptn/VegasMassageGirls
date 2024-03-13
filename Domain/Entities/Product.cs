using Domain.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Searchable]
        public string Title { get; set; }
    }
}
