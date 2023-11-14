using RestSharp;

namespace BoletoOnlineAPI.BoletoOnline;
public abstract class ClientAbstrato : IDisposable
{
	protected readonly RestClient _client;

	public ClientAbstrato() =>
		_client = ObtenhaClient();

	protected abstract RestClient ObtenhaClient();

    protected abstract Task<T> ExecuteAsync<T>(RestRequest request);

	public void Dispose() => _client.Dispose();

    public Task<T> GetAsync<T>(string resource) =>
        ExecuteAsync<T>(new RestRequest(resource, Method.Get));

    public Task<T> Execute<T>(RestRequest restRequest) =>
        ExecuteAsync<T>(restRequest);

    public Task<T> PostAsync<T>(string resource, object body) =>
        ExecuteAsync<T>(new RestRequest(resource, Method.Post).AddJsonBody(body));

    public Task<T> PutAsync<T>(string resource, object body) =>
        ExecuteAsync<T>(new RestRequest(resource, Method.Put).AddJsonBody(body));

    public Task<T> DeleteAsync<T>(string resource) =>
        ExecuteAsync<T>(new RestRequest(resource, Method.Delete));

}
