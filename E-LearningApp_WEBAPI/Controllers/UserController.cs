using DataLibrary.Models;
using E_LearningApp_WEBAPI.Models_DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace E_LearningApp_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<Object> RegisterUser(UserDTO user)
        {
            var newUser = new User()
            {
                UserName = user.UserName,
                Email = user.Email,
                FullName = user.FullName,
            };

            try
            {
                var result = await _userManager.CreateAsync(newUser, user.Password);
                return Ok(result);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
