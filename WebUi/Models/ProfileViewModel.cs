using Domain.Entities;
using System.Collections.Generic;

namespace WebUi.Models
{
    public class ProfileViewModel : Escort
    {
        public List<Escort> List { get; set; } = new List<Escort>();
    }
}
