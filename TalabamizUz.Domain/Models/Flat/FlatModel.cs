using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalabamizUz.Domain.Enums;
using TalabamizUz.Domain.Enums.User;

namespace TalabamizUz.Domain.Models.Flat
{
    [Table("flat")]
    public class FlatModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("floor_number")]
        public int FloorNumber { get; set; }

        [Column("room_count")]
        public int RoomCount { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("condition")]
        public string Condition { get; set; }

        [Column("location")]
        public string Location { get; set; }

        [Column("empty_place_count")]
        public int EmptyPlaceCount { get; set; }

        [Column("view_count")]
        public int ViewCount { get; set; }

        [Column("tags")]
        public string Tags { get; set; }

        [Column("target_client")]
        public string TargetClient { get; set; }

        [Column("flat_image")]
        public string FlatImage { get; set; }
    }
}
