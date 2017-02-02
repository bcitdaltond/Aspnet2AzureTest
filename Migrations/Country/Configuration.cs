namespace Lab3.Migrations.Country
{
    using Models.Country;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Country";
        }

        protected override void Seed(Lab3.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Teams.AddOrUpdate(t => t.TeamName, getTeams().ToArray());
            //context.SaveChanges();
            context.Cities.AddOrUpdate(c => c.CityId, getCities().ToArray());
            context.SaveChanges();

            //context.Players.AddOrUpdate(p => p.JerseyNumber, getPlayers(context).ToArray());
            //context.SaveChanges();
            context.Provinces.AddOrUpdate(p => p.ProvinceCode, getProvinces().ToArray());
            context.SaveChanges();

        }

        /*
        private List<Team> getTeams()
        {
            List<Team> teams = new List<Team>();
            teams.Add(new Team()
            {
                TeamName = "Canucks", City = "Vancouver"
            });
            teams.Add(new Team()
            {
                TeamName = "Oilers",
                City = "Edmondton"
            });
            teams.Add(new Team()
            {
                TeamName = "Capitals",
                City = "Washington DC"
            });
            return teams;
        }
        */

        //Type Display Comment
        //ProvinceCode    String Province Code Key, Example: BC
        //ProvinceName    String Province    Example: British Columbia
        //Cities Collection      Example: Surrey, Richmond, Coquitlam, ...
        private List<Province> getProvinces()
        {
            List<Province> prov = new List<Province>();
            prov.Add(new Province()
            {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
                Cities = new List<City>()
                {
                    cities.First(c => c.CityId == 1),
                    cities.First(c => c.CityId == 2),
                    cities.First(c => c.CityId == 3)
                }
            });
            prov.Add(new Province()
            {
                ProvinceCode = "ON",
                ProvinceName = "Ontario",
                Cities = new List<City>()
                {
                    cities.First(c => c.CityId == 4),
                    cities.First(c => c.CityId == 5),
                    cities.First(c => c.CityId == 6)
                }
            });
            prov.Add(new Province()
            {
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
                Cities = new List<City>()
                {
                    cities.First(c => c.CityId == 7),
                    cities.First(c => c.CityId == 8),
                    cities.First(c => c.CityId == 9)
                }
            });
            return prov;
        }

        //Type Display Comment
        //CityId  Integer Key
        //CityName String  City Example: Surrey
        //Population  Integer Example: 300,000

        private List<City> cities = new List<City>()
        {
            new City()
            {
                CityId = 1,
                CityName = "Vancouver",
                Population = 1937390
            },
            new City()
            {
                CityId = 2,
                CityName = "Surrey",
                Population = 3482000
            },
            new City()
            {
                CityId = 3,
                CityName = "Langley",
                Population = 923211
            },
            new City()
            {
                CityId = 4,
                CityName = "Toronto",
                Population = 8923113
            },
            new City()
            {
                CityId = 5,
                CityName = "Thunderbay",
                Population = 1000
            },
            new City()
            {
                CityId = 6,
                CityName = "Montreal",
                Population = 4231142
            },
            new City()
            {
                CityId = 7,
                CityName = "Bamf",
                Population = 25000
            },
            new City()
            {
                CityId = 8,
                CityName = "Calgary",
                Population = 3231354
            },
            new City()
            {
                CityId = 9,
                CityName = "Edmonton",
                Population = 1103234
            },
        };

        private List<City> getCities()
        {
            return cities;
        }

    }
}
