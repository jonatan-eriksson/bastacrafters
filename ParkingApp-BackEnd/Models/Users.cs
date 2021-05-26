﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp_BackEnd.Models
{
    public class Users
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public double Phone { get; set; }
        public double creditCardDetails { get; set; }
        public string licensePlate { get; set; }
        public double coordinatesWhenParking { get; set; }
        public double dateTimeWhenParking { get; set; }
        public double timeSpentFindingParking { get; set; }
        public double timeParked { get; set; }
    }
}
