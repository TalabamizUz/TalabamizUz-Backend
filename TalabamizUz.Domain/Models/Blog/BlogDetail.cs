using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.Blog
{
    [Table("blog_detail")]
    public  class BlogDetail
    {
        [Column("id")]
        public int Id {  get; set; }

        [Column("blog_id")]
        public int BlogId {  get; set; }

        [Column("content")]
        public string Content {  get; set; }    
    }
}
