using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.Account
{
    public class UserWithoutPassword
    {
        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("username")]
        [Required]
        public string Username { get; set; }

        [Column("phone_number")]
        [Required]
        public string PhoneNumber { get; set; }

        [Column("role")]
        [Required]
        public int Role { get; set; }

        [Column("address")]
        public string Address { get; set; }
    }
}
