using AutoMapper;
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
                .ForMember(dest => dest.Compensation, source => source.MapFrom(source => source.Salary));
        }
    }
}
