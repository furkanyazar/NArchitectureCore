namespace Core.Http.RestSharpImplementations;

public class RequestHeader
{
    public string Key { get; set; }
    public string Value { get; set; }

    public RequestHeader()
    {
        Key = string.Empty;
        Value = string.Empty;
    }

    public RequestHeader(string key, string value)
    {
        Key = key;
        Value = value;
    }
}
