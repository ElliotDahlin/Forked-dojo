﻿using Application_Layer.DTO_s;
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
            CreateMap<CourseUpdateDTO, CourseModel>()
            .ForMember(dest => dest.CourseId, opt => opt.Ignore())
            .ForMember(dest => dest.UserId, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTimestamp, opt => opt.Ignore())
            .ForMember(dest => dest.LastModificationTimestamp, opt => opt.MapFrom(src => DateTime.UtcNow));
            CreateMap<CreateCourseDTO, CourseModel>();
        }
    }
}
