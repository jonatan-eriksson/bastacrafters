using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp_FrontEnd.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string CardNumber { get; set; }
        public string CardDate { get; set; }
        public string CCV { get; set; }
        public string LicensePlate { get; set; }
        public string CoordinatesWhenParking { get; set; }
        public DateTime DateTimeWhenParking { get; set; } = DateTime.Now;
        public int MinutesSpentFindingParking { get; set; }
        public int MinutesParked { get; set; }
    }
}
