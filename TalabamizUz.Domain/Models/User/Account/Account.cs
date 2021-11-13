using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Enums;

namespace TalabamizUz.Domain.Models.User.Account
{
    [Table("account")]
    public class Account
    {
        [Column("id")]
        public int Id{  get; set; }

        [Column("firstname")]
        public string Firstname {  get; set; }

        [Column("lastname")]
        public string Lastname {  get; set; }

        [Column("phone")]
        public string Phone {  get; set; }

        [Required]
        [Column("password")]
        public string Password {  get; set; }

        [Column("role")]
        public RoleType Role {  get; set; }
    }
}
