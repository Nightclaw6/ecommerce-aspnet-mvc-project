using eTickets_Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets_Project.Models
{
    public class MusicFestivals
    {
        [Key]
        public int FestivalId { get; set; }
        public string FestivalName { get; set; }
        public string FestivalDescription { get; set; }
        public double Price { get; set; }
        public string FestivalLogoURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Genre Genre { get; set; }

        ///Relationships
        
        public List<Lineup_Festivals> Lineups_Festivals { get; set; }

        ///Location
        
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }  



    }
}
