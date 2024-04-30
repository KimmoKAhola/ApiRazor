namespace ApiRazor.KrisInfo;

public interface IHttpService<T>
{
    Task<T> Get(int id);
    Task<T> Get(string id);
    Task<List<T>> GetAll(int numberOfDays);
    Task<T> GetAll();
}