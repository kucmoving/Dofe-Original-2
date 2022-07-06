using Microsoft.AspNetCore.Mvc;
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Event> events = await _eventRepository.GetAll();
            return View(events);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Event _event = await _eventRepository.GetByIdAsync(id);
            return View(_event);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Event _event)
        {
            if (!ModelState.IsValid)
            {
                return View(_event);
            }
            _eventRepository.Add(_event);
            return RedirectToAction("Index");
        }

    }
}
