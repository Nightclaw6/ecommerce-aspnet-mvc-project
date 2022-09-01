using eTickets_Project.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets_Project.Models
{
    public class Lineup:IEntityBase
    {
        [Key]
        public int BandId { get; set; }

        [Display(Name = "Band Logo")]
        ///[Required(ErrorMessage = "Band logo is required")]
        public string BandLogo { get; set; }
        
        [Display(Name = "Band Name")]
        [Required(ErrorMessage = "Band name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Band name must be between 3 and 50 chars")]
        public string BandName { get; set; }
        
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Band biography is required")]
        public string BandBio { get; set; }

        ///Relationships
        
        public List<Lineup_Festivals> Lineups_Festivals { get; set; }
    }
}
