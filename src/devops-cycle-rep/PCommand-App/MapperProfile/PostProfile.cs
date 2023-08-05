using AutoMapper;
using Data.Model;
using PCommand_App.Request;

namespace PCommand_App.MapperProfile
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, AddPostCommand>()
                .ForMember(d => d.PostText, s => s.MapFrom(map => map.PostText))
                .ReverseMap();

            CreateMap<Post, UpdatePostCommand>()
                .ForMember(d => d.PostText, s => s.MapFrom(map => map.PostText))
                .ReverseMap();
        }
    }
}