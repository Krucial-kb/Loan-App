using LoanDomain.DomainModels;
using LoanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDataAccess.Repositories
{
    public class DemographicsRepo : IDemographicContract
    {
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void DeleteUser(DemographicDomain _demoApplicant)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DemographicDomain>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DemographicDomain> GetByIdAsync(string _demoApplicantName)
        {
            throw new NotImplementedException();
        }

        public void PostUserAsync(DemographicDomain _demoApplicant)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DemographicDomain>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(DemographicDomain _demoApplicant, int _demoApplicantid)
        {
            throw new NotImplementedException();
        }


    }
}
