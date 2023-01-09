using Microsoft.EntityFrameworkCore;

namespace Shop.Data;

internal interface IRepository<T> where T : class
{
    DbSet<T> Set { get; set; }

    T? FindById(long id);
    IEnumerable<T> GetAll();
    void Save(T entity, params T[] entities);
}