using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
