using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Interface
{
    public interface IMemberRepository
    {
        Task<List<Dog>> GetAllUserDogs();
        Task<List<Event>> GetAllUserEvents();
        Task<AppUser> GetUserById(string id);
<<<<<<< HEAD
        Task<AppUser> GetByIdNoTracking(string id);
        bool Update(AppUser user);
        bool Save();
=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0


    }
}
