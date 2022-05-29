using AutoMapper;
using RefitUsage.Contract.Model;
using RefitUsage.Server.Dto;

namespace RefitUsage.Server.Mapper;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, User>();
        CreateMap<User, UserDto>();

        CreateMap<WriterDto, Writer>();
        CreateMap<Writer, WriterDto>();
        
    }
}