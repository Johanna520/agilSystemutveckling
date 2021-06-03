﻿using IBBS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBS.Data
{
    public class BurgerDbContext : IdentityDbContext<Users>
    {
        public BurgerDbContext(DbContextOptions<BurgerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Comments> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<SavedHamburgers> Burgers { get; set; }

        public async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {

            await this.Database.EnsureDeletedAsync(); //Use this to reset the database

            bool isCreated = await this.Database.EnsureCreatedAsync();
            if (!isCreated)
            {
                return;
            }

            await roleManager.CreateAsync(new IdentityRole("Admin")); //Create roles
            await roleManager.CreateAsync(new IdentityRole("User"));

            Users admin = new Users()  //Put in user info
            {
                FirstName = "Admin",
                LastName = "Adminsson",
                UserName = "Admin",
                Email = "Admin@hotmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            Users user = new Users()
            {
                FirstName = "User",
                LastName = "Usersson",
                UserName = "User",
                Email = "User@hotmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            await userManager.CreateAsync(admin, "admin"); //Assign password
            await userManager.CreateAsync(user, "user1");

            for (int i = 0; i < 10; i++)
            {

                Users users = new Users()
                {
                    FirstName = "User" + i,
                    LastName = "Usersson" + i,
                    UserName = "User" + i,
                    Email = "User"+i+"@hotmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                };
                await userManager.CreateAsync(users, "user"+i);

                var userRoles = await Users.Where(u => u.Email == "User" + i + "@hotmail.com").FirstOrDefaultAsync();

                await userManager.AddToRoleAsync(userRoles, "User");
            }

            var adminRole = await Users.Where(u => u.Email == "Admin@hotmail.com").FirstOrDefaultAsync();
            var userRole = await Users.Where(u => u.Email == "User@hotmail.com").FirstOrDefaultAsync();


            await userManager.AddToRoleAsync(adminRole, "Admin"); //Assign roles
            await userManager.AddToRoleAsync(userRole, "User");

            await SaveChangesAsync();

        }

    }
}
