using System.Text.Json;

namespace SlsDemo;

public class Handler
{
    public async Task<Response> FunctionHandler(Request request)
    {
        // Marshal the request object to json
        var body = JsonSerializer.Serialize(request);
        return new Response(200, body, new Dictionary<string, string>
        {
            { "Content-Type", "text/plain" }
        });
    }
}