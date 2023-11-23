using RestSharp;

namespace Core.Http.RestSharpImplementations;

public class RequestParameter
{
    public string Key { get; set; }
    public string Value { get; set; }

    public RequestParameter()
    {
        Key = string.Empty;
        Value = string.Empty;
    }

    public RequestParameter(string key, string value)
    {
        Key = key;
        Value = value;
    }
}
