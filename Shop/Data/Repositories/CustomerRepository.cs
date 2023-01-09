using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class CustomerRepository : RepositoryBase<Customer>
{
    public CustomerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
}