using Microsoft.EntityFrameworkCore;
using PetCafe_Remake_.Data;
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;


namespace PetCafe_Remake_.Repository
{

    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Event _event)
        {
            _context.Add(_event);
            return Save();
        }

        public bool Delete(Event _event)
        {
            _context.Remove(_event);
            return Save();
        }

        public async Task<Event> GetByIdAsync(int id) //return single item / one to many relationship (join and inclue)
        {
            return await _context.Events.FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<Event> GetByIdAsyncNoTracking(int id)
        {
            throw new NotImplementedException();
        }

        //      public async Task<Sharing> GetByIdAsyncNoTracking(int id) // no tracking in editing , 否則會重疊
        //     {
        //        return await _context.Events.Include(i => i.VisitTime).AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        //  }

        //     public async Task<IEnumerable<Event>> GetDogByDay(string day) //goin to dog > VisitTime > day
        //      {
        //          return await _context.Events.Where(c => c.VisitTime.Day.Contains(day)).ToListAsync();
        //      }

        //       public Task<IEnumerable<Event>> GetSharingByDay(string day)
        //       {
        //           throw new NotImplementedException();
        //       }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Event _event)
        {
            _context.Update(_event);
            return Save();
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _context.Events.ToListAsync();
        }
    }
}
