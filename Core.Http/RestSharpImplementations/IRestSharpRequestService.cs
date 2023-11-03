using RestSharp;

namespace Core.Http.RestSharpImplementations;

public interface IRestSharpRequestService
{
    RestResponse SendRequest(RequestOptions options);

    Task<RestResponse> SendRequestAsync(RequestOptions options);
}
