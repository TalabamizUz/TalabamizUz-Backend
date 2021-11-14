using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.User
{
    public class TelegramRequestModel
    {
        public string FirstName { get; set; }
        public string LastName {  get; set; }   
        public string Phone {  get; set; }
        public string Message { get; set; }
    }
}
