﻿using AppCitas.DTOs;
using AppCitas.Extensions;
using AppCItas.Entities;
using AutoMapper;

namespace AppCitas.Helpers;

public class AutoMapperProfiles:Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser, MemberDto>()
            .ForMember(dest => dest.PhotoUrl,
            opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
           // .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DameLaEdad()));
           .ForMember(dest => dest.Age,
           opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

        CreateMap<Photo,PhotoDto>();
    }

}
