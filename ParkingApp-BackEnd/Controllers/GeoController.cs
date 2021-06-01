using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Device.Location;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Swashbuckle.Swagger.Annotations;
using Prometheus;
using BenchmarkDotNet.Reports;
using ParkingApp_BackEnd.Models;

namespace v1 {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/location")]
    public class GeoMessagesController : ControllerBase {
        
        
        //Vänta på DB
        /*private readonly ParkingAppDbContext _context;

        public GeoMessagesController(ParkingAppDbContext context) {
            _context = context;
        }*/

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUserLocation(int? id) {

            if (id == 15) {
                Users customuser = new Users() {
                    firstName = "Adam",
                    lastName = "Adamsson",
                    Email = "adam.adamsson@gmail.com",
                    Phone = 087020090,
                    creditCardDetails = 087020090,
                    licensePlate = "abc 123",
                    coordinatesWhenParking = "56.676577669193534&12.857049661467235",
                };
                return customuser;
            } else return new Users();
        }
    }
}
