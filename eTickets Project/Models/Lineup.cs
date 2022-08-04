using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets_Project.Models
{
    public class Lineup
    {
        [Key]
        public int BandId { get; set; }
        public string BandLogo { get; set; }
        public string BandName { get; set; }
        public string BandBio { get; set; }

        ///Relationships
        
        public List<Lineup_Festivals> Lineups_Festivals { get; set; }
    }
}
