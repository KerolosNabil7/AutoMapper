using AutoMapper;
using LearnAutoMapper.DTO;
using LearnAutoMapper.Models;

namespace LearnAutoMapper.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Map from Developer Object to DeveloperDTO Object
            //Compensation in DeveloperDTO is mapped from Salary in Developer
            CreateMap<Developer, DeveloperDTO>()
                //Specific Mapping
                .ForMember(dest => dest.Compensation, source => source.MapFrom(source => source.Salary))
                //Conditional Mapping
                .ForMember(dest => dest.IsEmployed, source => source.MapFrom(source => source.Salary > 0 ? true : false))
                //Reverse Mapping
                .ReverseMap();
        }
    }
}
