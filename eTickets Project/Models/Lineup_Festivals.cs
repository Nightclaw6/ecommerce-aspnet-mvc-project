namespace eTickets_Project.Models
{
    public class Lineup_Festivals
    {
        public int FestivalId { get; set; }
        public MusicFestivals Festival { get; set; }
        public int LineupId { get; set; }
        public Lineup Lineup { get; set; }
    }
}
