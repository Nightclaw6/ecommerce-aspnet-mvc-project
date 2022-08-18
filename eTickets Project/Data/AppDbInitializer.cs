using eTickets_Project.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets_Project.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                ///Locations
                if(!context.Locations.Any())
                {
                    context.Locations.AddRange(new List<Location>()
                    {
                        new Location()
                        {
                            City = "Toronto",
                            Address = "Lakeshore Blvd."
                        },
                        new Location()
                        {
                            City = "Toronto",
                            Address = "Cherry Beach"
                        },
                        new Location()
                        {
                            City = "Hamilton",
                            Address = "Music Plaza"
                        },
                        new Location()
                        {
                            City = "Montreal",
                            Address = "Old Port"
                        },
                        new Location()
                        {
                            City = "Halifax",
                            Address = "Harbourfront Centre"
                        },
                    });
                    context.SaveChanges();
                }
                ///Lineups
                if (!context.Lineups.Any())
                {
                    context.Lineups.AddRange(new List<Lineup>()
                    {
                        new Lineup()
                        {
                            BandName = "Queen",
                            BandBio = "This is the Bio of Queen",
                            BandLogo = "/"
                        },
                        new Lineup()
                        {
                            BandName = "Pink Floyd",
                            BandBio = "This is the Bio of Pink Floyd",
                            BandLogo = "/"
                        },
                        new Lineup()
                        {
                            BandName = "Joe Bonamassa",
                            BandBio = "This is the Bio of Joe Bonamassa",
                            BandLogo = "/"
                        },
                        new Lineup()
                        {
                            BandName = "Eric Clapton",
                            BandBio = "This is the Bio of Eric Clapton",
                            BandLogo = "/"
                        },
                        new Lineup()
                        {
                            BandName = "Led Zeppelin",
                            BandBio = "This is the Bio of Led Zeppelin",
                            BandLogo = "/"
                        },
                    });
                    context.SaveChanges();
                }
                ///Festivals
                if (!context.Festivals.Any())
                {
                    context.Festivals.AddRange(new List<MusicFestivals>()
                    {
                        new MusicFestivals()
                        {
                            FestivalName = "Festival 1",
                            FestivalDescription = "This is the Festival 1 description",
                            Price = 39.50,
                            FestivalLogoURL = "/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LocationId = 1,
                            Genre = Enums.Genre.Rock
                        },
                        new MusicFestivals()
                        {
                            FestivalName = "Festival 2",
                            FestivalDescription = "This is the Festival 2 description",
                            Price = 45,
                            FestivalLogoURL = "/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LocationId = 2,
                            Genre = Enums.Genre.Folk
                        },
                        new MusicFestivals()
                        {
                            FestivalName = "Festival 3",
                            FestivalDescription = "This is the Festival 3 description",
                            Price = 50,
                            FestivalLogoURL = "/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LocationId = 3,
                            Genre = Enums.Genre.Pop
                        },
                        new MusicFestivals()
                        {
                            FestivalName = "Festival 4",
                            FestivalDescription = "This is the Festival 4 description",
                            Price = 55,
                            FestivalLogoURL = "/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LocationId = 4,
                            Genre = Enums.Genre.Trance
                        },
                        new MusicFestivals()
                        {
                            FestivalName = "Festival 5",
                            FestivalDescription = "This is the Festival 5 description",
                            Price = 60,
                            FestivalLogoURL = "/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LocationId = 5,
                            Genre = Enums.Genre.Folk
                        },
                        new MusicFestivals()
                        {
                            FestivalName = "Festival 6",
                            FestivalDescription = "This is the Festival 6 description",
                            Price = 70,
                            FestivalLogoURL = "/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LocationId = 1,
                            Genre = Enums.Genre.Rock
                        },
                    });
                    context.SaveChanges();
                }
                ///Lineups & Festivals
                if (!context.Lineups_Festivals.Any())
                {
                    context.Lineups_Festivals.AddRange(new List<Lineup_Festivals>()
                    {
                        new Lineup_Festivals()
                        {
                            LineupId = 1,
                            FestivalId = 1
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 2,
                            FestivalId = 1
                        },

                        new Lineup_Festivals()
                        {
                            LineupId = 2,
                            FestivalId = 2
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 3,
                            FestivalId = 2
                        },

                        new Lineup_Festivals()
                        {
                            LineupId = 1,
                            FestivalId = 3
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 3,
                            FestivalId = 3
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 4,
                            FestivalId = 3
                        },


                        new Lineup_Festivals()
                        {
                            LineupId = 1,
                            FestivalId = 4
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 2,
                            FestivalId = 4
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 4,
                            FestivalId = 4
                        },


                        new Lineup_Festivals()
                        {
                            LineupId = 1,
                            FestivalId = 5
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 5,
                            FestivalId = 5
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 4,
                            FestivalId = 5
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 2,
                            FestivalId = 5
                        },


                        new Lineup_Festivals()
                        {
                            LineupId = 5,
                            FestivalId = 6
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 4,
                            FestivalId = 6
                        },
                        new Lineup_Festivals()
                        {
                            LineupId = 3,
                            FestivalId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
