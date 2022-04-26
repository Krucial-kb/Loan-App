using LoanDomain.DomainModels;
using LoanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDataAccess.Repositories
{
    public class BusinessRepo : IBusinessContract
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

        public Task<IEnumerable<BusinessDomain>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BusinessDomain>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
