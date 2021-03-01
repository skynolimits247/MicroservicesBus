using MicroservicesBus.User.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroservicesBus.User.Domain.Interfaces
{
    public interface IUserProfileRepository
    {
        Task<bool> CreateUserProfile(UserProfile userToCreate);
        Task<IEnumerable<UserProfile>> GetUserByCategory(FindUserCategoryDTO findUserCategory);
        Task<UserProfile> GetUserById(int id);
        Task<IEnumerable<UserProfile>> GetUserProfiles();

        Task<bool> UpdateNumberOfAppointemnts(int id);
    }
}
