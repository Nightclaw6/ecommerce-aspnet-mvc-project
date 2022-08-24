using eTickets_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets_Project.Data.Services
{
    public interface ILineupsService
    {
        Task<IEnumerable<Lineup>> GetAll();

        Lineup GetById(int id);   

        void Add(Lineup lineup);

        Lineup Update(int id, Lineup newLineup);

        void Delete(int id);
    }
}
