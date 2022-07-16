using PetCafe_Remake_.Models.Data.Enum;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

namespace PetCafe_Remake_.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string EventName { get; set; }

        public string Introduction { get; set; }

        public string Image { get; set; }

        public string Region { get; set; }
        public DateTime EventTime { get; set; }

        public EventCategory EventCategory { get; set; }
<<<<<<< HEAD
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
=======


        public string? AppUserId { get; set; }

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public AppUser? AppUser { get; set; }
    }

}
