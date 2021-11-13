using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.Blog
{
    [Table("blog")]
   public class Blog
    {
        [Column("id")]
        public int Id {  get; set; }

        [Column("title")]
        public string Title {  get; set; }

        [Column("description")]
        public string Description {  get; set; }   

        [Column("cover_image_path")]
        public string CoverImagePath {  get; set; }

        [Column("content")]
        public string Content {  get; set; }

        [Column("created_by")]
        public int CreatedBy {  get; set; }

        [Column("created_at")]
        public DateTime CreatedAt {  get; set; } = DateTime.Now;

    }
}
