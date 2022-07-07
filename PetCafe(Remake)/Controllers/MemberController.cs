using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using PetCafe_Remake_.Extension;
using PetCafe_Remake_.Interface;
using PetCafe_Remake_.Models;
using PetCafe_Remake_.ViewModels;

namespace PetCafe_Remake_.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberRepository _memberRepository;

        public MemberController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<IActionResult> Index()
        {
            var userEvents = await _memberRepository.GetAllUserEvents();
            var userDogs = await _memberRepository.GetAllUserDogs();
            var memberViewModel = new MemberViewModel()
            {
                Events = userEvents,
                Dogs = userDogs,
            };
            return View(memberViewModel);

        }


    }
}
