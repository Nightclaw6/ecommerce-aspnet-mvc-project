using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets_Project.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Display(Name = "City Name")]
        public string City { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }

        ///Relationships
        
        public List<MusicFestivals> MusicFestivals { get; set; }  
        
    }
}
