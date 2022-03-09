﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminMaster.Models
{
    public class Tb1__Users
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public string ProfileImage { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? Created_On { get; set; }
        public DateTime? UPdated_On { get; set; }


    }
}
