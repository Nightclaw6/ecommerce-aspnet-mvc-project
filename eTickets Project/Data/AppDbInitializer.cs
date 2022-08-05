using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
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

                }
                ///Lineups
                if (!context.Lineups.Any())
                {

                }
                ///Festivals
                if (!context.Festivals.Any())
                {

                }
                ///Lineups & Festivals
                if (!context.Lineups_Festivals.Any())
                {

                }
            }
        }
    }
}
