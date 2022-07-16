
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Newtonsoft.Json;
=======
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
using PetCafe_Remake_.Extension;
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;
using PetCafe_Remake_.ViewModels;

namespace PetCafe_Remake_.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogRepository _dogRepository;
        private readonly IPhotoService _photoService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DogController(IDogRepository dogRepository, IPhotoService photoService,
            IHttpContextAccessor httpContextAccessor)
        {
            _dogRepository = dogRepository;
            _photoService = photoService;
            _httpContextAccessor = httpContextAccessor;
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

<<<<<<< HEAD
        [HttpGet]
=======

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public IActionResult Create()
        {
            var curUserId = _httpContextAccessor.HttpContext.User.GetUserId();
            var createDogViewModel = new CreateDogViewModel { AppUserId = curUserId };
            return View(createDogViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateDogViewModel dogVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(dogVM.Image);
                var dog = new Dog
                {
                    DogName = dogVM.DogName,
                    Introduction = dogVM.Introduction,
                    Image = result.Url.ToString(),
                    AppUserId = dogVM.AppUserId,
                    VisitTime = new VisitTime
                    {
                        Day = dogVM.VisitTime.Day,
                        TimeFrame = dogVM.VisitTime.TimeFrame

                    }
                };
                _dogRepository.Add(dog);
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }
            return View(dogVM);
        }

<<<<<<< HEAD
        [HttpGet]
=======

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public async Task<IActionResult> Edit(int id) //to copy message as a form data
        {
            var dog = await _dogRepository.GetByIdAsync(id);
            if (dog == null) return View("Error");
            var dogVM = new EditDogViewModel
            {
                DogName = dog.DogName,
                Introduction = dog.Introduction,
                VisitTimeId = dog.VisitTimeId,
                VisitTime = dog.VisitTime,
                URL = dog.Image,
<<<<<<< HEAD
                DogCategory = dog.DogCategory,

=======
                DogCategory = dog.DogCategory
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
            };
            return View(dogVM);
        }

        [HttpPost] //to update
        public async Task<IActionResult> Edit(int id, EditDogViewModel dogVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(" ", "Failed to edit club");
                return View("Edit", dogVM);
            }

            var dogId = await _dogRepository.GetByIdAsyncNoTracking(id);
<<<<<<< HEAD

            if(dogId != null)
=======
            if (dogId != null)
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
            {
                try
                {
                    await _photoService.DeletePhotoAsync(dogId.Image);
                }
<<<<<<< HEAD
                catch (Exception ex)
=======
                catch (Exception)

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(dogVM);
                }
<<<<<<< HEAD

            var photoResult = await _photoService.AddPhotoAsync(dogVM.Image);
            if (photoResult.Error != null)
            {
                ModelState.AddModelError("Image", "Photo upload failed");
                return View(dogVM);
            }
            var dog = new Dog //no need to put foreign inside
=======
                var photoResult = await _photoService.AddPhotoAsync(dogVM.Image);
                var dog = new Dog
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
                {
                    Id = id,
                    DogName = dogVM.DogName,
                    Introduction = dogVM.Introduction,
                    Image = photoResult.Url.ToString(),
                    VisitTimeId = dogVM.VisitTimeId,
                    VisitTime = dogVM.VisitTime,
<<<<<<< HEAD
                    AppUserId = dogId.AppUserId
            };
            _dogRepository.Update(dog);
            return RedirectToAction("index");
            }
            else
            {
                return View(dogVM); 
            }
        }

        [HttpGet]
=======
                };

                _dogRepository.Update(dog);

                return RedirectToAction("index");
            }
            else
            {
                return View(dogVM);
            }
        }

>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        public async Task<IActionResult> Delete(int id)
        {
            var dogDetails = await _dogRepository.GetByIdAsync(id);
            if (dogDetails == null) return View("Error");
            return View(dogDetails);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteDog(int id)
        {
            var dogDetails = await _dogRepository.GetByIdAsync(id);
            if (dogDetails == null) return View("Error");
            _dogRepository.Delete(dogDetails);
            return RedirectToAction("Index");
        }
    }
}
