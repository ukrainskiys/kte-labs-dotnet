using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repositories;

public interface IRepository<T> where T : class
{
    T? FindById(long id);
    IEnumerable<T> GetAll();
    DbSet<T> GetDbSet();
    void Save(T entity, params T[] entities);
}