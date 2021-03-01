using MicroservicesBus.User.Application.Interfaces;
using MicroservicesBus.User.Application.Models;
using MicroservicesBus.User.Domain.Interfaces;
using MicroservicesBus.User.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesBus.User.Application.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public async Task<bool> CreateUserProfile(UserProfile userToCreate)
        {
            return await _userProfileRepository.CreateUserProfile(userToCreate);
        }

        public async Task<IEnumerable<UserProfile>> GetUserProfiles()
        {
            return await _userProfileRepository.GetUserProfiles();
        }

        public async Task<UserProfile> GetUserById(int id)
        {
            return (UserProfile)await _userProfileRepository.GetUserById(id);
        }

        public async Task<IEnumerable<UserProfile>> GetUserByCategory(FindUserCategoryDTO findUserCategory)
        {
            return await _userProfileRepository.GetUserByCategory(findUserCategory);
        }

    }
}
