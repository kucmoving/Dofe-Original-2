using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCafe_Remake_.Models
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }

        public string? Gender { get; set; }

        public string? Region { get; set; }

        public int? VisitTimeId { get; set; }

        public VisitTime? VisitTime { get; set; }

        public ICollection<Dog> Dogs { get; set; }

        public ICollection<Event> Events { get; set; }
    }

}
