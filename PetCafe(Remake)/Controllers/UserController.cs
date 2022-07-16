using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetCafe_Remake_.Extension;
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;
using PetCafe_Remake_.ViewModels;

namespace PetCafe_Remake_.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IPhotoService _photoService;

<<<<<<< HEAD
        public UserController(IUserRepository userRepository,
            UserManager<AppUser> userManager, IPhotoService photoService)
=======
        public UserController(IUserRepository userRepository, UserManager<AppUser> userManager, IPhotoService photoService)
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
        {
            _photoService = photoService;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        [HttpGet("users")]
        public async Task<IActionResult> Index()
        {
            var users = await _userRepository.GetAllUsers();
            List<UserViewModel> result = new List<UserViewModel>();
            foreach (var user in users)
            {
                var userViewModel = new UserViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Gender = user.Gender,
                    Region = user.Region,
<<<<<<< HEAD
                    Occupation = user.Occupation,
                    ProfileImageUrl = user.ProfileImageUrl,
                    AboutMe = user.AboutMe
=======
                    ProfileImageUrl = user.ProfileImageUrl,
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
                };
                result.Add(userViewModel);
            }
            return View(result);
        }

        public async Task<IActionResult> Detail(string id)
        {
            var user = await _userRepository.GetUserById(id);
            var userDetailViewModel = new UserDetailViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Gender = user.Gender,
                Region = user.Region,
<<<<<<< HEAD
                Occupation = user.Occupation,
                ProfileImageUrl = user.ProfileImageUrl,
                AboutMe = user.AboutMe
=======
                ProfileImageUrl = user.ProfileImageUrl,
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0

            };
            return View(userDetailViewModel);
        }
        //setup page
        public async Task<IActionResult> EditProfile()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error");
            }
            var editUserViewModel = new EditProfileViewModel()
            {
<<<<<<< HEAD
                UserName = user.UserName,
                Gender = user.Gender,
                ProfileImageUrl = user.ProfileImageUrl,
                Occupation = user.Occupation,
                Region = user.Region,
                AboutMe = user.AboutMe
=======
                Gender = user.Gender,
                ProfileImageUrl = user.ProfileImageUrl,
                Occupation = user.Occupation,
                Region = user.Region
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
            };
            return View(editUserViewModel);
        }

        //receive form
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel editVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit profile");
                return View("EditProfile", editVM);
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error");
            }

            if (editVM.Image != null) // only update profile image
            {
                var photoResult = await _photoService.AddPhotoAsync(editVM.Image);

                if (photoResult.Error != null)
                {
                    ModelState.AddModelError("Image", "Failed to upload image");
                    return View("EditProfile", editVM);
                }

                if (!string.IsNullOrEmpty(user.ProfileImageUrl))
                {
                    _ = _photoService.DeletePhotoAsync(user.ProfileImageUrl);
                }

                user.ProfileImageUrl = photoResult.Url.ToString();
                editVM.ProfileImageUrl = user.ProfileImageUrl;

                await _userManager.UpdateAsync(user);

                return View(editVM);
            }
<<<<<<< HEAD
            user.UserName = editVM.UserName;
            user.Gender = editVM.Gender;
            user.Region = editVM.Region;
            user.Occupation = editVM.Occupation;
            user.AboutMe = editVM.AboutMe;
=======
            user.Gender = editVM.Gender;
            user.Region = editVM.Region;
            user.Occupation = editVM.Occupation;
>>>>>>> 9172c66b404ee8df6bfc144723ad290023ac8ec0
            await _userManager.UpdateAsync(user);

            return RedirectToAction("Detail", "User", new { user.Id });
        }
    }
}