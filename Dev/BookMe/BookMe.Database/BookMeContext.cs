using System.Data.Entity;
using BookMe.Database.Entities;

namespace BookMe.Database
{
    public class BookMeContext : DbContext
    {
        public BookMeContext() : base("BookMeContext")
        {
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Court> Courts { get; set; }
    }
}
