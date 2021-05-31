using IBBS.Models;
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

        public DbSet<BurgerItems> BurgerItems { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<SavedHamburgers> Burgers { get; set; }

        public async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {

            //await this.Database.EnsureDeletedAsync(); //Use this to reset the database

            bool isCreated = await this.Database.EnsureCreatedAsync();
            if (!isCreated)
            {
                return;
            }

            Users admin = new Users()  //Put in user info
            {
                UserName = "Admin",
                Email = "Admin@hotmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            Users user = new Users()
            {
                UserName = "User",
                Email = "User@hotmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            await userManager.CreateAsync(admin, "Admin_1"); //Assign password
            await userManager.CreateAsync(user, "User_1");

            var adminRole = await Users.Where(u => u.Email == "Admin@hotmail.com").FirstOrDefaultAsync();
            var userRole = await Users.Where(u => u.Email == "User@hotmail.com").FirstOrDefaultAsync();

            await roleManager.CreateAsync(new IdentityRole("Admin")); //Create roles
            await roleManager.CreateAsync(new IdentityRole("User"));

            await userManager.AddToRoleAsync(adminRole, "Admin"); //Assign roles
            await userManager.AddToRoleAsync(userRole, "User");

            await SaveChangesAsync();

        }

    }
}
