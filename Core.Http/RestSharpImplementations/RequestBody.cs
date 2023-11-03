using RestSharp;

namespace Core.Http.RestSharpImplementations;

public class RequestBody
{
    public object Body { get; set; }
    public ContentType ContentType { get; set; }

    public RequestBody()
    {
        Body = string.Empty;
        ContentType = ContentType.Undefined;
    }

    public RequestBody(object body, ContentType contentType)
    {
        Body = body;
        ContentType = contentType;
    }
}
