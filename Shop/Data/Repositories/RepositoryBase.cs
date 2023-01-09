using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repositories;

public abstract class RepositoryBase<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext Db;
    public DbSet<T> Set { get; set; }

    protected RepositoryBase(ApplicationDbContext applicationDbContext)
    {
        Db = applicationDbContext;
        Set = applicationDbContext.Set<T>();
    }

    public virtual T? FindById(long id) => Set.Find(id);

    public virtual IEnumerable<T> GetAll() => Set.ToList();

    public virtual void Save(T entity, params T[] entities)
    {
        Set.Add(entity);
        Set.AddRange(entities);
        Db.SaveChangesAsync();
    }
}