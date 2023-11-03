using RestSharp;

namespace Core.Http.RestSharpImplementations;

public class RequestOptions
{
    public string BaseUrl { get; set; }
    public string SubUrl { get; set; }
    public Method Method { get; set; }
    public RequestBody? Body { get; set; }
    public List<RequestHeader>? Headers { get; set; }
    public List<RequestParameter>? Parameters { get; set; }

    public RequestOptions()
    {
        BaseUrl = string.Empty;
        SubUrl = string.Empty;
    }

    public RequestOptions(string baseUrl, string subUrl, Method method, RequestBody? body, List<RequestHeader>? headers)
    {
        BaseUrl = baseUrl;
        SubUrl = subUrl;
        Method = method;
        Body = body;
        Headers = headers;
    }
}
