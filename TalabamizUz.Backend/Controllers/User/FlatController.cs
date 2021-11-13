using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using TalabamizUz.Core.Interfaces.User.Flat;
using TalabamizUz.Domain.Models.Flat;

namespace TalabamizUz.Api.Controllers.User
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FlatController : ControllerBase
    {
        private readonly IFlatService _flatService;
        private readonly IWebHostEnvironment _env;
        public FlatController(IFlatService flatService, IWebHostEnvironment env)
        {
            _flatService = flatService;
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlat([FromForm] FlatModel flat)
        {
            var result = await _flatService.CreateFlat(flat);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetFlats()
        {
            var flats = await _flatService.GetFlatModels();
            return Ok(flats);
        }

        [HttpGet]
        public async Task<IActionResult> GetFlat(int flatId)
        {
            var flat = await _flatService.GetFlat(flatId);
            return Ok(flat);
        }

        [HttpPost]
        public async Task<IActionResult> SetFlatImage(int flatId, IFormFile file)
        {
            string directoryPath = Path.Combine(_env.WebRootPath, "Images/Flat/");
            MemoryStream stream = new MemoryStream();
            await file.OpenReadStream().CopyToAsync(stream);
            await _flatService.SetFlatImage(directoryPath, flatId, stream.ToArray());
            return Ok(true);
        }

        [HttpGet]
        public async Task<IActionResult> GetFlatImage(int flatId)
        {
            string directoryPath = Path.Combine(_env.WebRootPath, "Images/Flat/");
            byte[] image = await _flatService.GetFlatImage(directoryPath, flatId);
            return File(image, "application/jpeg");
        }
    }
}
