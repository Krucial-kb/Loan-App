using LoanDomain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDomain.Interfaces
{
    public interface IBusinessContract : IDisposable
    {
        //Get All (Show All Records)
        Task<IEnumerable<BusinessDomain>> GetAllAsync();
        //From Db to Client (List)
        Task<IEnumerable<BusinessDomain>> ToListAsync();
    }
}
