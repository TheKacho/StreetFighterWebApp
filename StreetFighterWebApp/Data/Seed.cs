using Microsoft.AspNetCore.Identity;
using StreetFighterWebApp.Data.Enum;
using StreetFighterWebApp.Models;

namespace StreetFighterWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //eSport Teams
                if (!context.EsportGroups.Any())
                {
                    context.EsportGroups.AddRange(new List<ESportGroup>()
                    {
                        new ESportGroup()
                        {
                            Title = "eSports Team 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of EvilGeniuses",
                            EsportCategory = EsportCategory.EvilGeniuses,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                Country = "USA"
                            }
                         },
                        new ESportGroup()
                        {
                            Title = "eSports Team 2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Rise Nation",
                            EsportCategory = EsportCategory.RiseNation,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                Country = "USA"
                            }
                        },
                        new ESportGroup()
                        {
                            Title = "eSports Team 3",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Panda Global",
                            EsportCategory = EsportCategory.PandaGlobal,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                Country = "USA"
                            }
                        },
                        new ESportGroup()
                        {
                            Title = "eSports Team 4",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Team Liquid",
                            EsportCategory = EsportCategory.TeamLiquid,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Michigan",
                                Country = "USA"
                            }
                        }
                    });
                    context.SaveChanges();
                }
                //Tournaments
                if (!context.Tournaments.Any())
                {
                    context.Tournaments.AddRange(new List<Tournament>()
                    {
                        new Tournament()
                        {
                            Title = "Tournament 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first race",
                            TournamentCategory = TournamentCategory.CEO,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC",
                                Country = "USA"
                            }
                        },
                        new Tournament()
                        {
                            Title = "Tournament 2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first race",
                            TournamentCategory = TournamentCategory.Evolution,
                            AddressId = 5,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC",
                                Country = "USA"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}
