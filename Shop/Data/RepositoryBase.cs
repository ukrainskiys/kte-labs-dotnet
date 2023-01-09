using Microsoft.EntityFrameworkCore;

namespace Shop.Data;

public abstract class RepositoryBase<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext Db;
    public DbSet<T> Set { get; set; }

    protected RepositoryBase(ApplicationDbContext applicationDbContext)
    {
        Db = applicationDbContext;
        Set = applicationDbContext.Set<T>();
    }

    public T? FindById(long id) => Set.Find(id);

    public IEnumerable<T> GetAll() => Set.ToList();

    public void Save(T entity, params T[] entities)
    {
        Set.Add(entity);
        Set.AddRange(entities);
        Db.SaveChangesAsync();
    }
}