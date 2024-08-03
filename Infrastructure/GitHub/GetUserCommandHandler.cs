using Domain.Commands.GitHub;
using MediatR;
using System.Text.Json.Nodes;

namespace Infrastructure.GitHub
{
    public class GetUserCommandHandler : IRequestHandler<GetUserCommand, JsonNode>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public GetUserCommandHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<JsonNode> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient("github");
 
            var url = $"https://api.github.com/users/{request.AccountId}";
            var httpResponseMessage = await client.GetAsync(url);

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                return null;
            }

            var response = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonObject.Parse(response);
        }
    }
}
