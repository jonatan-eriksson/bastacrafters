using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkingApp_FrontEnd.Models;

namespace ParkingApp_FrontEnd.Data
{
    public class ParkingApp_FrontEndContext : IdentityDbContext<User>
    {
        public ParkingApp_FrontEndContext(DbContextOptions<ParkingApp_FrontEndContext> options)
            : base(options)
        {
        }
       
        public async Task SeedDb(UserManager<User> userManager)
        {
            await Database.EnsureDeletedAsync();
            await Database.EnsureCreatedAsync();

            User Marcus = new User()
            {
                FirstName = "Marcus",
                LastName = "Backholm",
                Email = "Marcus.Test@live.se",
                UserName = "Marcus.Test@live.se",
                Phone = "46739247977",
                LicensePlate = "AWP 796",
                CardNumber = "0000000000000000",
                CardDate = "08 / 22",
                CCV = "045",
                DateTimeWhenParking = DateTime.Now,
            };

            await userManager.CreateAsync(Marcus, "Test123!");

            await SaveChangesAsync();
        }
    }
}
