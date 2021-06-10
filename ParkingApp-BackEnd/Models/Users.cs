using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp_BackEnd.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Phone { get; set; }
        public double CardNumber { get; set; }
        public int CardDate { get; set; }
        public int CCV { get; set; }
        public string LicensePlate { get; set; }
        public string CoordinatesWhenParking { get; set; }
        public DateTime DateTimeWhenParking { get; set; } = DateTime.Now;
        public int MinutesSpentFindingParking { get; set; }
        public int MinutesParked { get; set; }
    }
}
