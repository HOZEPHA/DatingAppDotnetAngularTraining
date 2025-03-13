using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
       CreateMap<AppUser, MemberDto>()
          .ForMember(x => x.Age, o => o.MapFrom(d => d.DateOfBirth.CalculateAge()))
          .ForMember(x => x.PhotoUrl, o => 
         o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain)!.Url));
       CreateMap<Photo, PhotoDto>();
    }
}
