using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repositories;

public abstract class RepositoryBase<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext ApplicationDbContext;

    protected RepositoryBase(ApplicationDbContext applicationDbContext)
    {
        ApplicationDbContext = applicationDbContext;
    }

    public virtual T? FindById(long id)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public virtual DbSet<T> GetDbSet()
    {
        throw new NotImplementedException();
    }

    public virtual void Save(T entity, params T[] entities)
    {
        throw new NotImplementedException();
    }
}