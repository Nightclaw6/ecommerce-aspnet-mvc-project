using Microsoft.EntityFrameworkCore;

namespace eTickets_Project.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
    }
}
