using AutoMapper;
using BookMe.Database.Entities;

namespace BookMe.BusinessLogic
{
    public class Mappings
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Club, Model.Club>();
            Mapper.CreateMap<Model.Club, Club>();
        }
    }
}