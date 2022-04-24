using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDomain.DomainModels
{
    public class BusinessDomain
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public byte? ZipCode { get; set; }
        public string Country { get; set; }
    }
}
