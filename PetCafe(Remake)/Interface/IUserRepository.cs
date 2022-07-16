using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetAllUsers();
        Task<AppUser> GetUserById(string id);
<<<<<<< HEAD

        bool Update(AppUser user);

=======
        bool Add(AppUser user);
        bool Update(AppUser user);
        bool Delete(AppUser user);
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        bool Save();
    }
}
