using AutoMapper;
using Cmd.Common;
using Data.DataAccess.Contract;
using Data.Model;
using MediatR;
using PCommand_App.Request;
using System.Net;

namespace PCommand_App.Handler
{
    public class AddCommentCommandHandler : IRequestHandler<AddCommentCommand, Result>
    {
        private readonly IElasticsearchDataAccess _elasticsearchDataAccess;
        private readonly IMapper _mapper;

        public AddCommentCommandHandler(IElasticsearchDataAccess elasticsearchDataAccess, IMapper mapper)
        {
            _elasticsearchDataAccess = elasticsearchDataAccess;
            _mapper = mapper;
        }


        public async Task<Result> Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            await _elasticsearchDataAccess.CreateIndexIfNotExists(nameof(Comment));
            var comment = _mapper.Map<Comment>(request);

            var result = await _elasticsearchDataAccess.AddOrUpdate<Comment>(comment);

            return AppResult.OkIf(result, HttpStatusCode.ServiceUnavailable, "ServiceUnavailable");
        }
    }
}