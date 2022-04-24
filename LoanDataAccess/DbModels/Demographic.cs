using System;
using System.Collections.Generic;

#nullable disable

namespace LoanDataAccess.DbModels
{
    public partial class Demographic
    {
        public Demographic()
        {
            Businesses = new HashSet<Business>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public virtual Loan Loan { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
    }
}
