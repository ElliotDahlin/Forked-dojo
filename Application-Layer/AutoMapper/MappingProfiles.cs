using Application_Layer.DTO_s;
using AutoMapper;
using Domain_Layer.Models.CourseModel;
using Domain_Layer.Models.UserModel;

namespace Application_Layer.AutoMaper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<RegisterUserDTO, UserModel>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            CreateMap<UpdatingUserDTO, UserModel>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));
            CreateMap<CreateCourseDTO, CourseModel>();
            CreateMap<SearchCriteriaDTO, CourseModel>()
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.CategoryOrSubject, opt => opt.MapFrom(src => src.CategoryOrSubject))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language));
            CreateMap<SearchCriteriaDTO, UserModel>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));
        }
    }
}
