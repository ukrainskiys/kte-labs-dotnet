namespace Shop.Data;

public interface IMappingRepository<out T> where T : class
{
    IEnumerable<TResult> GetAllWithMapper<TResult>(Func<T, TResult> func);
}