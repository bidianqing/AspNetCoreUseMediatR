using MediatR;
using System.Text.Json.Nodes;

namespace Domain.Commands.GitHub
{
    public class GetUserCommand : IRequest<JsonNode>
    {
        public string AccountId { get; set; }
    }
}
