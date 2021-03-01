using MicroservicesBus.User.Application.Interfaces;
using MicroservicesBus.User.Application.Models;
using MicroservicesBus.User.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesBus.User.API.Controllers
{
    [ApiController]
    [Route("api1/[controller]")]
    public class UserProfileController : Controller
    {
        
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserProfile>>> GetUsers()
        {
            var users = await _userProfileService.GetUserProfiles();
            //System.Diagnostics.Debug.WriteLine(users);
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserProfile userToCreate)
        {
            var result = await _userProfileService.CreateUserProfile(userToCreate);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserProfile>> GetUserById(int id)
        {
            return Ok(await Task.FromResult(await _userProfileService.GetUserById(id)));
        }

        // POST: api1/userprofile/findservices
        [HttpPost]
        [Route("findservices")]
        public async Task<ActionResult<List<UserProfile>>> GetUserByCategory([FromBody] FindUserCategoryDTO findUserCategory)
        {
            return Ok(await Task.FromResult(await _userProfileService.GetUserByCategory(findUserCategory)));
        }
    }
}
