using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets_Project.Models
{
    public class Lineup
    {
        [Key]
        public int BandId { get; set; }

        [Display(Name = "Band Logo")]
        public string BandLogo { get; set; }
        [Display(Name = "Band Name")]
        public string BandName { get; set; }
        [Display(Name = "Biography")]
        public string BandBio { get; set; }

        ///Relationships
        
        public List<Lineup_Festivals> Lineups_Festivals { get; set; }
    }
}
