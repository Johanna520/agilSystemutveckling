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

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<BurgerItems> BurgerItems { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<SavedHamburgers> Burgers { get; set; }


        public async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {

            //  await this.Database.EnsureDeletedAsync(); //Use this to reset the database or comment it out

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

            var adminRole = await Users.Where(u => u.Email == "Admin@hotmail.com").FirstOrDefaultAsync();
            var userRole = await Users.Where(u => u.Email == "User@hotmail.com").FirstOrDefaultAsync();


            await userManager.AddToRoleAsync(adminRole, "Admin"); //Assign roles
            await userManager.AddToRoleAsync(userRole, "User");
            await AddBurgerItems();


            for (int i = 0; i < 10; i++)
            {

                Users users = new Users()
                {
                    FirstName = "User" + i,
                    LastName = "Usersson" + i,
                    UserName = "User" + i,
                    Email = "User" + i + "@hotmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                };
                await userManager.CreateAsync(users, "user" + i);

                var userRoles = await Users.Where(u => u.Email == "User" + i + "@hotmail.com").FirstOrDefaultAsync();

                await userManager.AddToRoleAsync(userRoles, "User");
            }

            await SaveChangesAsync();

        }

        public async Task AddBurgerItems()
        {
            Ingredients.Add(new Ingredient()
            {
                Name = "Avocado"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Bacon"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "BottomBunDark"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "TopBunDark"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Cheese"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Chicken"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Cucumber"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Hallumi"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Ketchup"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Mayo"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Onion"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "SalladBunBottom"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "SalladBunTop"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "TopLightBun"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Sallad"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Tomato"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "Beef"
            });
            Ingredients.Add(new Ingredient()
            {
                Name = "BottomLightBun"
            });
            await SaveChangesAsync();
        }

    }
}
