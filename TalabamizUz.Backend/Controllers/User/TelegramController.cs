using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TalabamizUz.Data.Contexts;
using TalabamizUz.Domain.Models.User;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TalabamizUz.Api.Controllers.User
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TelegramController : ControllerBase
    {
        private readonly TalabamizDbContext _dbContext;
        private ITelegramBotClient _client;
        public TelegramController(TalabamizDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> SendRequest(int flatId, TelegramRequestModel requestModel)
        {
            _client = new TelegramBotClient("2106929555:AAHObQtah7EmjSM6lDbmzqUr62EgaqtqLeo");

            var flat = await _dbContext.Flats.FirstOrDefaultAsync(p => p.Id == flatId);
            var detail = await _dbContext.AccountDetails.FirstOrDefaultAsync(p => p.UserId == flat.UserId);
            
            string chat_id = detail.TelegramUserId.ToString();
            string message = $"<b>FIO:</b> {requestModel.FirstName} {requestModel.LastName}\n<b>Phone:</b> {requestModel.Phone}\n\n<b>Message:</b> {requestModel.Message}";
            await _client.SendTextMessageAsync(long.Parse(chat_id), message, Telegram.Bot.Types.Enums.ParseMode.Html);
            return Ok(true);
        }
    }
}
