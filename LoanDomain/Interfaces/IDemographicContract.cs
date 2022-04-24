using LoanDomain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDomain.Interfaces
{
    public interface IDemographicContract : IDisposable
    {
        //Get All (Show All Records)
        Task<IEnumerable<DemographicDomain>> GetAllAsync();
        //Find By Id (Search)
        Task<DemographicDomain> GetByIdAsync(int _demoApplicantid);
        //POST Call (Create)
        void PostUserAsync(DemographicDomain _demoApplicant);
        //PUT Call (Update)
        Task<bool> UpdateAsync(DemographicDomain _demoApplicant, int _demoApplicantid);
        //DELETE Call (Remove specified record)
        void DeleteUser(DemographicDomain _demoApplicant);
        //Persists to Database
        Task<int> SaveChangesAsync();
        //From Db to Client (List)
        Task<IEnumerable<DemographicDomain>> ToListAsync();
    }
}
