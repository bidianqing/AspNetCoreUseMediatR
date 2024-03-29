﻿using MediatR;

namespace Domain
{
    public class Ping : IRequest<string>
    {

    }


    public class PingHandler : IRequestHandler<Ping, string>
    {
        public async Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return await Task.FromResult("Pong");
        }
    }
}
