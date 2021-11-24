using eEnchere.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Articles.Any())
                {
                    context.Articles.AddRange(new List<Article>()
                    {
                        /*new Article()
                        {
                            Nom = "Iphone 13",
                            Description = "This is a phone",
                            Prix= 10254 ,
                            Photo="https://d1fmx1rbmqrxrr.cloudfront.net/cnet/optim/i/edit/2019/09/iphone-11-11-pro-prix-sortie__w770.jpg",
                            Etat="Non vendu" 
                        },*/
                        new Article()
                        {
                            Nom = "IPhone 12",
                            Description = "This is a phone",
                            Prix = 14752 ,
                            Photo="https://img.bfmtv.com/c/1256/708/697/18b3fae06494dd9eab71b1f689574.jpg",
                            Etat="Non vendu"
                            
                        },
                        new Article()
                        {
                            Nom = "Samsung",
                            Description = "This is a samsung photo",
                            Prix = 1500,
                            Photo="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJLM2D0YKPmUnkMXdDK-XrHia7dfgAPExHIQ&usqp=CAU",
                            Etat="Non vendu"
                            

                        },
                        new Article()
                        {
                            Nom = "TV",
                            Description = "This is a TV",
                            Prix = 3500,
                            Photo="https://images.samsung.com/is/image/samsung/n-africa-fhd-t5300-ua43t5300auxmv-frontblack-237364315?$720_576_PNG$",
                            Etat="Non vendu"
                           
                        },
                        new Article()
                        {
                            Nom = "TV HD",
                            Description = "This is a TV",
                            Prix = 2500,
                            Photo="https://sc02.alicdn.com/kf/HTB1d_rubijrK1RjSsplq6xHmVXar/221948536/HTB1d_rubijrK1RjSsplq6xHmVXar.jpg_.webp",
                            Etat="Non vendu"
                          
                        },

                          new Article()
                        {
                            Nom = "TV HD",
                            Description = "This is a TV",
                            Prix = 2500,
                            Photo="https://sc02.alicdn.com/kf/HTB1d_rubijrK1RjSsplq6xHmVXar/221948536/HTB1d_rubijrK1RjSsplq6xHmVXar.jpg_.webp",
                            Etat="Non vendu"
                           
                        },

                            new Article()
                        {
                            Nom = "TV HD",
                            Description = "This is a TV",
                            Prix = 2500,
                            Photo="https://www.samsungtunisie.tn/2773-large_default/tv-samsung-32-n5000-full-hd-tunisie.jpg",
                            Etat="Non vendu"
                           
                        },
                            new Article()
                        {
                            Nom = "PC",
                            Description = "This is a PC",
                            Prix = 2500,
                            Photo="https://www.tunisianet.com.tn/134180-large/pc-portable-lenovo-ideapad-l340-15irh-gaming-i7-9e-gen-16-go.jpg",
                            Etat="Non vendu"
                           
                        },
                             new Article()
                        {
                            Nom = "PC",
                            Description = "This is a PC",
                            Prix = 2200,
                            Photo="https://cdn.futura-sciences.com/buildsv6/images/largeoriginal/d/a/e/daedbc7758_50170718_2-lenovo-legion-y540-15irh.jpg",
                            Etat="Non vendu"
                           
                        },
                    });
                    context.SaveChanges();
                }
                ////Actors
                //if (!context.Actors.Any())
                //{
                //    context.Actors.AddRange(new List<Actor>()
                //    {
                //        new Actor()
                //        {
                //            FullName = "Actor 1",
                //            Bio = "This is the Bio of the first actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                //        },
                //        new Actor()
                //        {
                //            FullName = "Actor 2",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                //        },
                //        new Actor()
                //        {
                //            FullName = "Actor 3",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                //        },
                //        new Actor()
                //        {
                //            FullName = "Actor 4",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                //        },
                //        new Actor()
                //        {
                //            FullName = "Actor 5",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                //        }
                //    });
                //    context.SaveChanges();
                //}
                ////Producers
                //if (!context.Producers.Any())
                //{
                //    context.Producers.AddRange(new List<Producer>()
                //    {
                //        new Producer()
                //        {
                //            FullName = "Producer 1",
                //            Bio = "This is the Bio of the first actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                //        },
                //        new Producer()
                //        {
                //            FullName = "Producer 2",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                //        },
                //        new Producer()
                //        {
                //            FullName = "Producer 3",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                //        },
                //        new Producer()
                //        {
                //            FullName = "Producer 4",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                //        },
                //        new Producer()
                //        {
                //            FullName = "Producer 5",
                //            Bio = "This is the Bio of the second actor",
                //            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                //        }
                //    });
                //    context.SaveChanges();
                //}
                //Rooms
                if (!context.Rooms.Any())
                {
                   context.Rooms.AddRange(new List<Room>()
                  {
                       new Room()
                       {
                          NomRoom = "ROOM1",
                          DateDebut = DateTime.Now.AddDays(10),
                          NombreParticipants = 4,
                          Timeur = 10,
                           MontantEnchére = 120,
                           DernierMise = 4,
                           FraisRoom = 3,
                           MontantLancement = 3,
                            MontantInitial = 5,
                            MontantEnchéreFinal= 8  ,
                            IdArticle=1

                       },
                        new Room()
                       {
                          NomRoom = "ROOM3",
                          DateDebut = DateTime.Now.AddDays(10),
                          NombreParticipants = 4,
                          Timeur = 10,
                           MontantEnchére = 120,
                           DernierMise = 4,
                           FraisRoom = 3,
                           MontantLancement = 3,
                            MontantInitial = 5,
                            MontantEnchéreFinal= 8  ,
                            IdArticle=2

                       },
                      new Room()
                       {
                          NomRoom = "ROOM4",
                          DateDebut = DateTime.Now.AddDays(10),
                          NombreParticipants = 4,
                          Timeur = 10,
                           MontantEnchére = 120,
                           DernierMise = 4,
                           FraisRoom = 3,
                           MontantLancement = 3,
                            MontantInitial = 5,
                            MontantEnchéreFinal= 8  ,
                            IdArticle=3

                       },
                        new Room()
                       {
                          NomRoom = "ROOM5",
                          DateDebut = DateTime.Now.AddDays(10),
                          NombreParticipants = 4,
                          Timeur = 10,
                           MontantEnchére = 120,
                           DernierMise = 4,
                           FraisRoom = 3,
                           MontantLancement = 3,
                            MontantInitial = 5,
                            MontantEnchéreFinal= 8  ,
                            IdArticle=3

                       },
                        new Room()
                       {
                          NomRoom = "ROOM5",
                          DateDebut = DateTime.Now.AddDays(10),
                          NombreParticipants = 4,
                          Timeur = 10,
                           MontantEnchére = 120,
                           DernierMise = 4,
                           FraisRoom = 3,
                           MontantLancement = 3,
                            MontantInitial = 5,
                            MontantEnchéreFinal= 8  ,
                            IdArticle=4

                       },

                   });
                   context.SaveChanges();
                }
                ////Actors & Movies
                //if (!context.Actors_Movies.Any())
                //{
                //    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                //    {
                //        new Actor_Movie()
                //        {
                //            ActorId = 1,
                //            MovieId = 1
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 3,
                //            MovieId = 1
                //        },

                //         new Actor_Movie()
                //        {
                //            ActorId = 1,
                //            MovieId = 2
                //        },
                //         new Actor_Movie()
                //        {
                //            ActorId = 4,
                //            MovieId = 2
                //        },

                //        new Actor_Movie()
                //        {
                //            ActorId = 1,
                //            MovieId = 3
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 2,
                //            MovieId = 3
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 5,
                //            MovieId = 3
                //        },


                //        new Actor_Movie()
                //        {
                //            ActorId = 2,
                //            MovieId = 4
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 3,
                //            MovieId = 4
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 4,
                //            MovieId = 4
                //        },


                //        new Actor_Movie()
                //        {
                //            ActorId = 2,
                //            MovieId = 5
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 3,
                //            MovieId = 5
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 4,
                //            MovieId = 5
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 5,
                //            MovieId = 5
                //        },


                //        new Actor_Movie()
                //        {
                //            ActorId = 3,
                //            MovieId = 6
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 4,
                //            MovieId = 6
                //        },
                //        new Actor_Movie()
                //        {
                //            ActorId = 5,
                //            MovieId = 6
                //        },
                //    });
                //    context.SaveChanges();
                //}
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
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //        string adminUserEmail = "admin@etickets.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new ApplicationUser()
        //            {
        //                FullName = "Admin User",
        //                UserName = "admin-user",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }


        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new ApplicationUser()
        //            {
        //                FullName = "Application User",
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}
