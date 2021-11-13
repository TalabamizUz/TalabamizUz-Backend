using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalabamizUz.Core.Interfaces;
using TalabamizUz.Domain.Models.Account;

namespace TalabamizUz.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserForCreate model)
        {
            var mapModel = _mapper.Map<User>(model);
            var result = await _userService.CreateUserAsync(mapModel);
            var resultModel = _mapper.Map<UserWithoutPassword>(result);
            return Ok(resultModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsersAsync();
            var models = _mapper.Map<IEnumerable<UserWithoutPassword>>(users);
            return Ok(models);
        }


        [HttpPost]
        public async Task<IActionResult> PostAnnouncement()
        {
           var users  = await _userService.po
        }
    }
}
