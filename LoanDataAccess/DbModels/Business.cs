using System;
using System.Collections.Generic;

#nullable disable

namespace LoanDataAccess.DbModels
{
    public partial class Business
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
