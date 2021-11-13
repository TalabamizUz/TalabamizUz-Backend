using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TalabamizUz.Core.Interfaces.User;
using TalabamizUz.Data.Contexts;
using TalabamizUz.Domain.Models.User;

namespace TalabamizUz.Api.Controllers.User
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LandlordController : ControllerBase
    {
        private readonly IUserService _userService;
        public LandlordController(IUserService userService)
        {
            _userService = userService;                
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] Account account)
        {
            var user = await _userService.CreateUser(account);
            if (user is null)
                return NotFound(user);

            return Ok(user);

        }

        [HttpGet]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _userService.GetUser(userId);
            if (user is null)
                return NotFound(user);

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUser();
            return Ok(users);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(int userId, Account account)
        {
            var user = await _userService.UpdateUser(userId, account);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            await _userService.DeleteUser(userId);
            return Ok(true);
        }
    }
}
