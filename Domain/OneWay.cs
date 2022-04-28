using MediatR;

namespace Domain
{
    public class OneWay : IRequest
    {

    }

    public class OneWayHandler : AsyncRequestHandler<OneWay>
    {
        protected override async Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync("OneWayHandler");
        }
    }
}