using PetCafe_Remake_.Models.Data.Enum;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCafe_Remake_.Models
{
    public class Dog
    {
<<<<<<< HEAD
        [Key]
        public int Id { get; set; }

        public string? DogName { get; set; }

        public string? Introduction { get; set; }

        public string? Image { get; set; }

        [ForeignKey("VisitTime")]
        public int? VisitTimeId { get; set; }
=======
        public int Id { get; set; }

        public string DogName { get; set; }

        public string Introduction { get; set; }

        public string Image { get; set; }
        [ForeignKey("VisitTime")]
        public int VisitTimeId { get; set; }
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

        public VisitTime VisitTime { get; set; }

        public DogCategory DogCategory { get; set; }

<<<<<<< HEAD
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
=======

        public string? AppUserId { get; set; }

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public AppUser? AppUser { get; set; }

    }

}
