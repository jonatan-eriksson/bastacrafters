using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParkingApp_FrontEnd.Data;
using ParkingApp_FrontEnd.Models;

[assembly: HostingStartup(typeof(ParkingApp_FrontEnd.Areas.Identity.IdentityHostingStartup))]
namespace ParkingApp_FrontEnd.Areas.Identity
{

        public class IdentityHostingStartup : IHostingStartup
        {
            public void Configure(IWebHostBuilder builder)
            {
                builder.ConfigureServices((context, services) => {
                });
            }
        }
    
}