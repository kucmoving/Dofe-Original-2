using PetCafe_Remake_.Models.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCafe_Remake_.Models
{
    public class Dog
    {
        public int Id { get; set; }

        public string DogName { get; set; }

        public string Introduction { get; set; }

        public string Image { get; set; }
        [ForeignKey("VisitTime")]
        public int VisitTimeId { get; set; }

        public VisitTime VisitTime { get; set; }

        public DogCategory DogCategory { get; set; }


        public string? AppUserId { get; set; }

        public AppUser? AppUser { get; set; }

    }

}
