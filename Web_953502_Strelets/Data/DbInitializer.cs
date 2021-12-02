using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_953502_Strelets.Entities;

namespace Web_953502_Strelets.Data
{
    public class DbInitializer
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };

                await roleManager.CreateAsync(roleAdmin);
            }

            if (!context.Users.Any())
            {
                var user = new ApplicationUser()
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru",
                };

                await userManager.CreateAsync(user, "111111");

                var admin = new ApplicationUser()
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru",
                };

                await userManager.CreateAsync(admin, "111111");
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }

            if (!context.CarGroups.Any())
            {
                context.CarGroups.AddRange( new List<CarGroup>()
                {
                    new CarGroup() { GroupName = "Audi"},
                    new CarGroup() { GroupName = "Mercedes"},
                    new CarGroup() { GroupName = "BMW"},
                    new CarGroup() { GroupName = "Reno"},
                    new CarGroup() { GroupName = "Toyota"},
                    new CarGroup() { GroupName = "Lada"},
                });

                await context.SaveChangesAsync();
            }

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(new List<Car>()
                {
                    new Car() { Color = "Black", Mark = "Audi", Model = "Q3", CarGroupId = 1, Image = "Q3.jfif"},
                    new Car() { Color = "Red", Mark = "Mercedes", Model = "Benz C", CarGroupId = 2, Image = "benz.jfif"},
                    new Car() { Color = "Blue", Mark = "BMW", Model = "M3", CarGroupId = 3, Image = "m3.jfif"},
                    new Car() { Color = "Blue", Mark = "Reno", Model = "Espace", CarGroupId = 4, Image = "espace.jfif"},
                    new Car() { Color = "Gray", Mark = "Toyota", Model = "Camry", CarGroupId = 5, Image = "camri.jfif"},
                    new Car() { Color = "Red", Mark = "Lada", Model = "Vesta", CarGroupId = 6, Image = "vesta.jfif"},
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
