using System.Collections.Generic;
using BookMe.Database.Entities;

namespace BookMe.Database.Repositories.Interfaces
{
    public interface IClubsRepository
    {
        IEnumerable<Club> GetAllClubs();
        int AddClub(Club club);
        Club GetClub(int id);
    }
}