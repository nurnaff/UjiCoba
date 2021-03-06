﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web3.Controllers.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Company { get; set; }
        public string ProfileImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
    }
}
