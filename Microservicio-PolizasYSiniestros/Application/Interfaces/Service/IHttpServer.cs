namespace Application.Interfaces.Service
{
    public interface IHttpServer
    {
        Task<T> GetAsync<T>(string uri);

    }
}
