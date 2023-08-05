using AutoMapper;
using Data.Model;
using PCommand_App.Request;

namespace PCommand_App.MapperProfile
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<AddCommentCommand, Comment>()
                .ForMember(d => d.CommentText, s => s.MapFrom(map => map.CommentText))
                .ForMember(d => d.PostId, s => s.MapFrom(map => map.PostId))
                .ForMember(d => d.IsConfierm, s => s.MapFrom(map => true))
                .ForMember(d => d.IsActive, s => s.MapFrom(map => true))
                .ForMember(d => d.ModifiedDate, s => s.MapFrom(map => DateTime.MinValue))
                .ForMember(d => d.CreatedDate, s => s.MapFrom(map => DateTime.UtcNow))
                .ForMember(d => d.CommentType, s => s.MapFrom(map => "Post"))
                .ForMember(d => d.Id, s => s.MapFrom(map => Guid.NewGuid()));

            CreateMap<UpdateCommentCommand, Comment>()
                .ForMember(d => d.CommentText, s => s.MapFrom(map => map.CommentText))
                .ForMember(d => d.Id, s => s.MapFrom(map => map.CommentId))
                .ForMember(d => d.ModifiedDate, s => s.MapFrom(map => DateTime.UtcNow))
                .ForMember(d => d.PostId, s => s.UseDestinationValue())
                .ForMember(d => d.IsConfierm, s => s.UseDestinationValue())
                .ForMember(d => d.IsActive, s => s.UseDestinationValue())
                .ForMember(d => d.CreatedDate, s => s.UseDestinationValue())
                .ForMember(d => d.CommentType, s => s.UseDestinationValue());
        }
    }
}