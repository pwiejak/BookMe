using System;
using System.Collections.Generic;
using AutoMapper;
using BookMe.BusinessLogic.Model;
using BookMe.BusinessLogic.Services.Interfaces;
using BookMe.Database.Repositories;
using BookMe.Database.Repositories.Interfaces;

namespace BookMe.BusinessLogic.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubsRepository _clubsRepository;
        public ClubService()
        {
            _clubsRepository = new ClubsRepository();
        }
        public IEnumerable<Club> GetAllClubs()
        {
            var clubs = _clubsRepository.GetAllClubs();
            var clubsModel = Mapper.Map<IEnumerable<Club>>(clubs);

            return clubsModel;
        }

        public int SaveClub(Club club)
        {
            var clubEntity = Mapper.Map<Database.Entities.Club>(club);
            return _clubsRepository.AddClub(clubEntity);
        }

        public Club GetClub(int id)
        {
            var clubEntity = _clubsRepository.GetClub(id);
            var club = Mapper.Map<Club>(clubEntity);
            return club;
        }
    }
}