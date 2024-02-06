using MediatR;

namespace Domain
{
    public class OneWay : IRequest
    {

    }

    public class OneWayHandler : IRequestHandler<OneWay>
    {
        public async Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync("OneWayHandler");
        }
    }
}