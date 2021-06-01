﻿using Microsoft.EntityFrameworkCore;
using ParkingApp_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp_BackEnd.Data
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options)
            : base(options)
        {
        }
            public DbSet<Models.User> Users { get; set; }

        public async Task SeedDb()
        {
            await Database.EnsureDeletedAsync();
            await Database.EnsureCreatedAsync();

            User Alan = new User()
            {
                FirstName = "Alan",
                LastName = "Weik",
                Email = "something@hotmail.com",
                Phone = +46793481663,
                LicensePlate = "DYK 666",
                CardNumber = 1234123412341234,
                CardDate = 03/22,
                CCV = 221,
                CoordinatesWhenParking = 134.145,
                MinutesParked = 160, 
                DateTimeWhenParking = DateTime.Now,
                MinutesSpentFindingParking = 15,
            };
            User Johannes = new User()
            {
                FirstName = "Johannes",
                LastName = "Anttonen",
                Email = "something@hotmail.com",
                Phone = +46719929484,
                LicensePlate = "HEJ 777",
                CardNumber = 1234432143214321,
                CardDate = 01 / 22,
                CCV = 111,
                CoordinatesWhenParking = 133.142,
                MinutesParked = 10,
                DateTimeWhenParking = DateTime.Now,
                MinutesSpentFindingParking = 5,
            };
            await AddAsync(Johannes);
            await AddAsync(Alan);

            await SaveChangesAsync();
        }
    }
}