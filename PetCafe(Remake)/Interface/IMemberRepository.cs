﻿using PetCafe_Remake_.Models;

namespace PetCafe_Remake_.Interface
{
    public interface IMemberRepository
    {
        Task<List<Dog>> GetAllUserDogs();
        Task<List<Event>> GetAllUserEvents();
        Task<AppUser> GetUserById(string id);


    }
}
