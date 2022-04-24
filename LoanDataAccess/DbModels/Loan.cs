using System;
using System.Collections.Generic;

#nullable disable

namespace LoanDomain.DbModels
{
    public partial class Loan
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
