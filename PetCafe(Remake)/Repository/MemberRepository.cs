using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PetCafe_Remake_.Data;
<<<<<<< HEAD
using PetCafe_Remake_.Extension;
=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MemberRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // using httpcontext to get the user

        public async Task<List<Dog>> GetAllUserDogs()
        {
<<<<<<< HEAD
            var curUser = _httpContextAccessor.HttpContext?.User.GetUserId();
            var userDogs = _context.Dogs.Where(r => r.AppUser.Id == curUser.ToString());

=======
            var curUser = _httpContextAccessor.HttpContext?.User;
            var userDogs = _context.Dogs.Where(r => r.AppUser.Id == curUser.ToString());
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
            return userDogs.ToList();
        }

        public async Task<List<Event>> GetAllUserEvents()
        {
<<<<<<< HEAD
            var curUser = _httpContextAccessor.HttpContext?.User.GetUserId();
            var userSharings = _context.Events.Where(r => r.AppUser.Id == curUser.ToString());
            return userSharings.ToList();
        }


=======
            var curUser = _httpContextAccessor.HttpContext?.User;
            var userEvents = _context.Events.Where(r => r.AppUser.Id == curUser.ToString());
            return userEvents.ToList();
        }

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public async Task<AppUser> GetUserById(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetByIdNoTracking(string id)
        {
            return await _context.Users.Where(u => u.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public bool Update(AppUser user)
        {
            _context.Users.Update(user);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
<<<<<<< HEAD

=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
    }
}

