using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabamizUz.Domain.Models.User.Flat
{
    [Table("flat_detail")]
    public class FlatDetail
    {
        [Column("id")]
        public int Id {  get; set; }

        [Column("flat_id")]
        public int FlatId {  get; set; }

        [Column("flat_photos_path")]
        public string FlatPhotosPath {  get; set; }

        [Column("has_kitchen")]
        public bool HasKitchen {  get; set;}

        [Column("has_bath_room")]
        public bool HasBathRoom {  get; set;}

        [Column("has_wifi")]
        public bool HasWifi {  get;}

        [Column("has_elevator")]
        public bool HasElevator {  get; set;}

        [Column("bus")]
        public string Bus {  get;}

        [Column("landlord_message")]
        public string LandlordMassage {  get; set; }
    }
}
