using eTickets_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets_Project.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lineup_Festivals>().HasKey(lf => new
            {
                lf.LineupId,
                lf.FestivalId
            });

            modelBuilder.Entity<Lineup_Festivals>().HasOne(f => f.Festival).WithMany(lf => lf.Lineups_Festivals).HasForeignKey(f => f.FestivalId);

            modelBuilder.Entity<Lineup_Festivals>().HasOne(f => f.Lineup).WithMany(lf => lf.Lineups_Festivals).HasForeignKey(f => f.LineupId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Lineup> Lineups { get; set; }
        public DbSet<MusicFestivals> Festivals { get; set; }
        public DbSet<Lineup_Festivals> Lineups_Festivals { get; set; }
        public DbSet<Location> Locations { get; set; }



    }
}
