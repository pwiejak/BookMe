using System.Collections.Generic;
using System.Data.Entity.Migrations;
using BookMe.Database.Entities;

namespace BookMe.Database.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BookMe.Database.BookMeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookMeContext context)
        {
            var clubs = new List<Club>
            {
                new Club
                {
                    Email = "tennisClub@courts.com",
                    Name = "Tennis club"
                },
                new Club
                {
                    Email = "squashClub@courts.com",
                    Name = "Squash club"
                },
                new Club
                {
                    Email = "basketball@courts.com",
                    Name = "Basketball club"
                },
                new Club
                {
                    Email = "footballClub@courts.com",
                    Name = "Football club"
                }
            };

            clubs.ForEach(c => context.Clubs.Add(c));
            context.SaveChanges();

            foreach (var club in clubs)
            {
                var courts = new List<Court>
                {
                    new Court
                    {
                        ClubId = club.Id,
                        Number = 1
                    },
                    new Court
                    {
                        ClubId = club.Id,
                        Number = 2
                    },
                    new Court
                    {
                        ClubId = club.Id,
                        Number = 3
                    },
                    new Court
                    {
                        ClubId = club.Id,
                        Number = 4
                    },
                    new Court
                    {
                        ClubId = club.Id,
                        Number = 5
                    }
                };

                courts.ForEach(c => context.Courts.Add(c));
                context.SaveChanges();
            }
        }
    }
}