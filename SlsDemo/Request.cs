using System.Text.Json.Serialization;

namespace SlsDemo;

[method: JsonConstructor]
public class Request(
    String httpMethod,
    Dictionary<string, string> headers,
    String url,
    Dictionary<string, string> queryStringParameters,
    String body,
    bool isBase64Encoded)
{
    public String httpMethod { get; set; } = httpMethod;
    public Dictionary<string, string> headers { get; set; } = headers;
    public String url { get; set; } = url;
    public Dictionary<string, string> queryStringParameters { get; set; } = queryStringParameters;
    public String body { get; set; } = body;
    public bool isBase64Encoded { get; set; } = isBase64Encoded;
}