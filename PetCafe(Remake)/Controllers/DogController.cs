
using Microsoft.AspNetCore.Mvc;
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogRepository _dogRepository;

        public DogController(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task<IActionResult> Index()
        {
            //bring in <dog> so that can @model in cshtml
            IEnumerable<Dog> dogs = await _dogRepository.GetAll();
            return View(dogs);
        }
        public async Task<IActionResult> Detail(int id)
        {

            Dog dog = await _dogRepository.GetByIdAsync(id);
            return View(dog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return View(dog);
            }
            _dogRepository.Add(dog);
            return RedirectToAction("Index");
        }

    }
}
