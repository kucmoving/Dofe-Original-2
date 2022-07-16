using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Interface
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAll();
        Task<Event> GetByIdAsync(int id);
<<<<<<< HEAD
        Task<IEnumerable<Event>> GetEventByCity(string region);
        Task<Event> GetByIdAsyncNoTracking(int id);
=======
        Task<Event> GetByIdAsyncNoTracking(int id);
        // Task<IEnumerable<Event>> GetSharingByDay(string day);
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        bool Add(Event _event);
        bool Update(Event _event);
        bool Delete(Event _event);
        bool Save();
    }
}
