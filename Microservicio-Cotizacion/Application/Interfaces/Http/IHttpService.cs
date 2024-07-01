namespace Application.Interfaces.Http
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(string uri);
    }
}
