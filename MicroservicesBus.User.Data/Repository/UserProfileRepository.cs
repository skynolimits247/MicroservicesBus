using MicroservicesBus.User.Data.Context;
using MicroservicesBus.User.Domain.Interfaces;
using MicroservicesBus.User.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesBus.User.Data.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private UserProfileDbContext _userProfileContext;
        private bool flag;
        public UserProfileRepository(UserProfileDbContext userProfileDbContext)
        {
            _userProfileContext = userProfileDbContext;
        }

        public async Task<bool> CreateUserProfile(UserProfile userToCreate)
        {
            try
            {
                _userProfileContext.UserProfiles.Add(userToCreate);
                _userProfileContext.SaveChanges();
                flag = true;
                return await Task.FromResult(flag);
            }
            catch
            {
                flag = false;
                return await Task.FromResult(flag);
            }
        }

        public async Task<UserProfile> GetUserById(int id)
        {
            return await _userProfileContext.UserProfiles.FirstOrDefaultAsync(s => s.Id.Equals(id));
        }

        public async Task<IEnumerable<UserProfile>> GetUserByCategory(FindUserCategoryDTO findUserCategory)
        {
            List<UserProfile> users = _userProfileContext.UserProfiles.Where(s => 
            (s.Specialization.ToLower().Equals(findUserCategory.Category.ToLower())) && 
            s.AreaOfCoverage.Equals(findUserCategory.Zip)).ToList();

            return await Task.FromResult(users);
        }

        public async Task<IEnumerable<UserProfile>> GetUserProfiles()
        {
            return await _userProfileContext.UserProfiles.ToListAsync();
        }

        public async Task<bool> UpdateNumberOfAppointemnts(int id)
        {
            UserProfile user = _userProfileContext.UserProfiles.FirstOrDefault(s => s.Id.Equals(id));
            if(user != null)
            {
                user.NumberOfAppointments += 1;
                _userProfileContext.UserProfiles.Update(user);
                _userProfileContext.SaveChanges();
                return await Task.FromResult(true);
            }
            else
            {
                return false;
            }
            
        }
    }
}
