using MediatR;
using Microsoft.Extensions.Logging;

namespace Domain
{
    public class Ping : IRequest<string>
    {

    }


    public class PingHandler : IRequestHandler<Ping, string>
    {
        private readonly ILogger<PingHandler> _logger;
        public PingHandler(ILogger<PingHandler> logger)
        {
            _logger = logger;
        }

        public async Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("pong");
            return await Task.FromResult("Pong");
        }
    }
}
