using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.Account
{
    [Table("account")]
    public class User : UserWithoutPassword
    {
        [Key]
        [Required]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("password")]
        [Required]
        public string Password { get; set; }
    }
}
