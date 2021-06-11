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
using ParkingApp_BackEnd.Data;
using Microsoft.AspNetCore.Identity;

namespace v1 {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/location")]
    public class GeoMessagesController : ControllerBase {
        
        
        private readonly ParkingDbContext _context;
        public GeoMessagesController(ParkingDbContext context) {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserLocation(int? id) {

            if (id != null) {
                var user = await _context.Users.FindAsync(id);

                if (user != null) {
                    return Ok(user);
                } else return NotFound();

            } else return new User();
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUserLocation(string coords) {
            var tempuser = _context.Users.FindAsync(1);

            tempuser.Result.CoordinatesWhenParking = coords;
            await _context.SaveChangesAsync();
            return Ok(tempuser);
        }
    }
}
