using Domain;
using Domain.Commands.GitHub;
using Domain.Events;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace AspNetCoreUseMediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<JsonNode> Get()
        {
            var result = await _mediator.Send(new Ping());
            _logger.LogInformation(result);

            await _mediator.Send(new OneWay());

            await _mediator.Publish(new OrderCancelledDomainEvent(1));

            var user = await _mediator.Send(new GetUserCommand
            {
                AccountId = "bidianqing"
            });

            return user;
        }
    }
}