using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDomain.DomainModels
{
    public class LoanDomain
    {
        public int Id { get; set; }
        public decimal? RequestedAmount { get; set; }
        public int? PaybackTime { get; set; }
        public decimal? Apr { get; set; }
        public short? CreditScore { get; set; }
        public int? LatePayments { get; set; }
        public int? TotalDebt { get; set; }
        public decimal? RiskRating { get; set; }
    }
}
