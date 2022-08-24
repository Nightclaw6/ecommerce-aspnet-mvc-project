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


        public void Add(Lineup lineup)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Lineup>> GetAll()
        {
            var result = await _context.Lineups.ToListAsync();
            return result;  
        }

        public Lineup GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Lineup Update(int id, Lineup newLineup)
        {
            throw new System.NotImplementedException();
        }
    }
}
