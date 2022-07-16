using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCafe_Remake_.Models
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Occupation { get; set; }
        public string? Region { get; set; }

<<<<<<< HEAD
        public string? AboutMe { get; set; }

=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

        [ForeignKey("VisitTime")]
        public int? VisitTimeId { get; set; }
        public VisitTime? VisitTime { get; set; }


        public ICollection<Dog> Dogs { get; set; }
        public ICollection<Event> Events { get; set; }
    }

}
