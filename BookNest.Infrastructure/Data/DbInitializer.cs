﻿using BookNest.Application.Common.Interfaces;
using BookNest.Application.Common.Utility;
using BookNest.Domain.Entities;
using BookNest.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookNest.Application.Common.Interfaces;
using BookNest.Application.Common.Utility;
using BookNest.Domain.Entities;

namespace BookNest.Infrastructure.Data
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }

                if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).Wait();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).Wait();
                    _userManager.CreateAsync(new ApplicationUser
                    {
                        UserName = "admin@eren.com",
                        Email = "admin@eren.com",
                        Name = "Eren ŞAKRAK",
                        NormalizedUserName = "ADMIN@EREN.COM",
                        NormalizedEmail = "ADMIN@EREN.COM",
                        PhoneNumber = "1112223333",
                    }, "Admin123*").GetAwaiter().GetResult();

                    ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin@eren.com");
                    _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}