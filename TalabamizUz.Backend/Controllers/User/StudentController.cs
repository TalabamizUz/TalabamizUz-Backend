using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TalabamizUz.Data.Contexts;
using TalabamizUz.Domain.Models.User.Account;

namespace TalabamizUz.Api.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly TalabamizDbContext _dbContext;
        public StudentController(TalabamizDbContext dbContext)
        {
            _dbContext = dbContext;                
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody]Account account)
        {
            _dbContext.Accounts.Add(account);
            await _dbContext.SaveChangesAsync();
            return Ok(true);
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = _dbContext.Accounts;
            return Ok(students);
        }
    }
}
