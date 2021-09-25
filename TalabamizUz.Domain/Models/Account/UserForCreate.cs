using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Enums;

namespace TalabamizUz.Domain.Models.Account
{
    public class UserForCreate : UserWithoutPassword
    {
        [Column("password")]
        [Required]
        public string Password { get; set; }
    }
}
