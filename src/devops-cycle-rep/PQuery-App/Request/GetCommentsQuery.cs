﻿using Cmd.Common;
using MediatR;

namespace PQuery_App.Request
{
    public class GetCommentsQuery : IRequest<Result>
    {
        public int PostId { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}