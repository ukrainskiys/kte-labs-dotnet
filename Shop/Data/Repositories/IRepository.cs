using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shop.Domain.Models;

namespace Shop.Data;

public interface IRepository<T> where T : class
{
    T? FindById(long id);
    IEnumerable<T> GetAll();
    DbSet<T> GetDbSet();
    void Save(T entity, params T[] entities);
}