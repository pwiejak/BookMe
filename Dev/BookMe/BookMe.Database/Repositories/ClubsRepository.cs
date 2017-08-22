using System;
using System.Collections.Generic;
using System.Linq;
using BookMe.Database.Entities;
using BookMe.Database.Repositories.Interfaces;

namespace BookMe.Database.Repositories
{
    public class ClubsRepository : IClubsRepository
    {
        private readonly BookMeContext _context;

        public ClubsRepository()
        {
            _context = new BookMeContext();
        }

        public int AddClub(Club club)
        {
            _context.Clubs.Add(club);
            _context.SaveChanges();
            return club.Id;
        }

        public Club GetClub(int id)
        {
            return _context.Clubs.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Club> GetAllClubs()
        {
            return _context.Clubs.ToList();
        }
    }
}