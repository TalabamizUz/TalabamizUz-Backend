using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.User.Account
{
    [Table("account_detail")]
   public class AccountDetail
    {
        [Column("id")]
        public int Id {  get; set; }

        [Column("user_id")]
        public int UserId {  get; set; }

        [Column("pinfl")]
        public string Pinfl { get; set; }

        [Column("telegram_user_id")]
        public string TelegramUserId {  get; set; }

        [Column("address")]
        public string Address {  get; set; }

        [Column("is_poor")]
        public bool IsPoor {  get; set; }

        [Column("is_student")]
        public bool IsStudent {  get; set; }
    }
}
