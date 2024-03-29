﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> GetByIdAsync(int id) //return single item / one to many relationship (join and inclue)
        {
            return await _context.Events.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Event> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Events.Where(i => i.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

<<<<<<< HEAD
=======

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

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
<<<<<<< HEAD
        public async Task<IEnumerable<Event>> GetEventByCity(string region)
        {
            return await _context.Events.Where(c => c.Region.Contains(region)).Distinct().ToListAsync();
        }
=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

        public bool Update(Event _event)
        {
            _context.Update(_event);
            return Save();
        }

    }
}
