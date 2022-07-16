using PetCafe_Remake_.Models;
using PetCafe_Remake_.Models.Data.Enum;

namespace PetCafe_Remake_.ViewModels
{
    public class EditDogViewModel
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string? DogName { get; set; }
        public string? Introduction { get; set; }
        public string? URL { get; set; }
        public IFormFile? Image { get; set; }
        public int? VisitTimeId { get; set; }
        public VisitTime? VisitTime { get; set; }
        public DogCategory DogCategory { get; set; }
        public string AppUserId { get; set; }
=======
        public string DogName { get; set; }
        public string Introduction { get; set; }
        public string? URL { get; set; }
        public IFormFile Image { get; set; }
        public int VisitTimeId { get; set; }
        public VisitTime VisitTime { get; set; }
        public DogCategory DogCategory { get; set; }

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
    }
}
