using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helpers
{
    public static class DbInitializer
    {
        public static void SeedCredentials(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credentials>().HasData(new Credentials[]
            {
                new Credentials
                {
                    Id = 1,
                    Email = "yrakhwas@gmail.com",
                    Login = "yrakhwas",
                    Name = "Yra",
                    Password = "Pass",
                    PhoneNumber = "0682882322"
                },
                new Credentials
                {
                    Id = 2,
                    Email = "yrakhwas1@gmail.com",
                    Login = "yrakhwas1",
                    Name = "Yra1",
                    Password = "Pass1",
                    PhoneNumber = "0682882323"
                },
            });
        }
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User{ CredentialsId = 1},
                new User { CredentialsId = 2}
            });
        }
        public static void SeedIngridients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingridient>().HasData(new Ingridient[]
            {
                new Ingridient
                {
                    Id = 1,
                    Name = "Ing1",
                    Price = 1
                },
                new Ingridient
                {
                    Id = 2,
                    Name = "Ing2",
                    Price = 2

                },
                new Ingridient
                {
                    Id = 3,
                    Name = "Ing3",
                    Price = 3

                },
                new Ingridient
                {
                    Id = 4,
                    Name = "Ing4",
                    Price = 4

                },
            });
        }
        public static void SeedPizzas(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(new Pizza[]
            {
                new Pizza
                {
                    Id = 1,
                    Name = "Piz1"
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Piz2"
                },

            });
        }
        public static void SeedSushis(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sushi>().HasData(new Sushi[]
            {
                new Sushi
                {
                    Id = 1,
                    Name = "Sushi1"
                },
                new Sushi
                {
                    Id = 2,
                    Name = "Sushi2"
                },

            });
        }
        public static void SeedSalads(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salad>().HasData(new Salad[]
            {
                new Salad
                {
                    Id = 1,
                    Name = "Salad1"
                },
                new Salad
                {
                    Id = 2,
                    Name = "Salad2"
                },

            });
        }
        public static void SeedPizzaIngridient(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaIngridients>().HasData(new PizzaIngridients[]
            {
                new PizzaIngridients
                {
                     IngridientId = 1,
                     PizzaId = 1
                },
                new PizzaIngridients
                {
                     IngridientId = 2,
                     PizzaId = 1
                },
                new PizzaIngridients
                {
                     IngridientId = 3,
                     PizzaId = 1
                },
                new PizzaIngridients
                {
                     IngridientId = 2,
                     PizzaId = 2
                },
                new PizzaIngridients
                {
                     IngridientId = 3,
                     PizzaId = 2
                },
                new PizzaIngridients
                {
                     IngridientId = 4,
                     PizzaId = 2
                }
            });
        }
        public static void SeedSushiIngridient(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SushiIngridients>().HasData(new SushiIngridients[]
            {
                new SushiIngridients
                {
                     IngridientId = 1,
                     SushiId = 1
                },
                new SushiIngridients
                {
                     IngridientId = 2,
                     SushiId = 1
                },
                new SushiIngridients
                {
                     IngridientId = 3,
                     SushiId = 1
                },
                new SushiIngridients
                {
                     IngridientId = 2,
                     SushiId = 2
                },
                new SushiIngridients
                {
                     IngridientId = 3,
                     SushiId = 2
                },
                new SushiIngridients
                {
                     IngridientId = 4,
                     SushiId = 2
                }
            });
        }
        public static void SeedSaladIngridient(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaladIngridients>().HasData(new SaladIngridients[]
            {
                new SaladIngridients
                {
                     IngridientId = 1,
                     SaladId = 1
                },
                new SaladIngridients
                {
                     IngridientId = 2,
                     SaladId = 1
                },
                new SaladIngridients
                {
                     IngridientId = 3,
                     SaladId = 1
                },
                new SaladIngridients
                {
                     IngridientId = 2,
                     SaladId = 2
                },
                new SaladIngridients
                {
                     IngridientId = 3,
                     SaladId = 2
                },
                new SaladIngridients
                {
                     IngridientId = 4,
                     SaladId = 2
                }
            });
        }
    }
}
