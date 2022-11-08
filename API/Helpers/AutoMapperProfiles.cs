using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTo>()
            .ForMember(destination => destination.PhotoUrl, opt => opt
            .MapFrom(source => source.Photos
            .FirstOrDefault(x => x.IsMain).Url));
            CreateMap<Photo, PhotoDTo>();
        }
    }
}