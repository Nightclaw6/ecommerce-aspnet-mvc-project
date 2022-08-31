using eTickets_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets_Project.Data.Services
{
    public interface ILineupsService
    {
        Task<IEnumerable<Lineup>> GetAllAsync();

        Task<Lineup> GetByIdAsync(int id);   

        Task AddAsync(Lineup lineup);

        Task<Lineup> UpdateAsync(int id, Lineup newLineup);

        void Delete(int id);
    }
}
