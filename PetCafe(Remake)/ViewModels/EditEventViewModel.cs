<<<<<<< HEAD
﻿using PetCafe_Remake_.Models;
using PetCafe_Remake_.Models.Data.Enum;
=======
﻿using PetCafe_Remake_.Models.Data.Enum;
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

namespace PetCafe_Remake_.ViewModels
{
    public class EditEventViewModel
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string? EventName { get; set; }
        public string? Introduction { get; set; }
        public IFormFile? Image { get; set; }
        public string? URL { get; set; }
        public string? Region { get; set; }
        public DateTime? EventTime { get; set; }
        public EventCategory EventCategory { get; set; }
        public string AppUserId { get; set; }
=======
        public string EventName { get; set; }
        public string Introduction { get; set; }
        public IFormFile Image { get; set; }
        public string? URL { get; set; }
        public string Region { get; set; }
        public DateTime EventTime { get; set; }
        public EventCategory EventCategory { get; set; }
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

    }
}
