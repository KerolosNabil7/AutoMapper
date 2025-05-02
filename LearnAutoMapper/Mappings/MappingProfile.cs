using AutoMapper;
using LearnAutoMapper.Models;

namespace LearnAutoMapper.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Map from Developer Object to DeveloperDTO Object
            CreateMap<Developer, DeveloperDTO>();
        }
    }
}
