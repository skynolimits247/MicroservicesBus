using MicroservicesBus.User.Application.Models;
using MicroservicesBus.User.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroservicesBus.User.Application.Interfaces
{
    public interface IUserProfileService
    {
        //IEnumerable<UserProfile> GetUserProfiles();
        Task<bool> CreateUserProfile(UserProfile userToCreate);
        Task<IEnumerable<UserProfile>> GetUserByCategory(FindUserCategoryDTO findUserCategory);
        Task<UserProfile> GetUserById(int id);
        Task<IEnumerable<UserProfile>> GetUserProfiles();

    }
}
