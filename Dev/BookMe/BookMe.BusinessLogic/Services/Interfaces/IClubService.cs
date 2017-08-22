using System.Collections.Generic;
using BookMe.BusinessLogic.Model;

namespace BookMe.BusinessLogic.Services.Interfaces
{
    public interface IClubService
    {
        IEnumerable<Club> GetAllClubs();
        int SaveClub(Club club);
        Club GetClub(int id);
    }
}