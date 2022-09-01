using eTickets_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets_Project.Data.Services
{
    public class LineupsService : ILineupsService
    {

        private readonly AppDbContext _context;
        public LineupsService(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Lineup lineup)
        {
            await _context.Lineups.AddAsync(lineup);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Lineups.FirstOrDefaultAsync(n => n.BandId == id);
            _context.Lineups.Remove(result);
            await _context.SaveChangesAsync();
        }

        

        public async Task<Lineup> UpdateAsync(int id, Lineup newLineup)
        {
            _context.Update(newLineup);
            await _context.SaveChangesAsync();
            return newLineup;
        }
    }
}
