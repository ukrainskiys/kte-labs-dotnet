using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class CustomerRepository : RepositoryBase<Customer>, IMappingRepository<Customer>
{
    public CustomerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public IEnumerable<TResult> GetAllWithMapper<TResult>(Func<Customer, TResult> func)
    {
        return Set.Select(func).ToList();
    }
}