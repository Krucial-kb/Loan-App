﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LoanDataAccess.DbModels
{
    public partial class Demographic
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
