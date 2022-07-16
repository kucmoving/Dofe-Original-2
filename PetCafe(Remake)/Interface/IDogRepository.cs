using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Interface
{
    public interface IDogRepository
    {
        Task<IEnumerable<Dog>> GetAll();
        Task<Dog> GetByIdAsync(int id);

        Task<Dog> GetByIdAsyncNoTracking(int id);
<<<<<<< HEAD
=======
        Task<IEnumerable<Dog>> GetDogByDay(string day);
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        bool Add(Dog dog);
        bool Update(Dog dog);
        bool Delete(Dog dog);
        bool Save();

    }
}
