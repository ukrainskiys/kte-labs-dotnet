using Microsoft.EntityFrameworkCore;
using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class CustomerRepository : RepositoryBase<Customer>
{
    private readonly DbSet<Customer> _customers;

    public CustomerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
        _customers = applicationDbContext.Customers;
    }

    public override Customer? FindById(long id)
    {
        return _customers.Find(id);
    }

    public override IEnumerable<Customer> GetAll()
    {
        return _customers.ToList();
    }

    public override DbSet<Customer> GetDbSet()
    {
        return _customers;
    }

    public override void Save(Customer entity, params Customer[] entities)
    {
        _customers.Add(entity);
        _customers.AddRange(entities);
        Db.SaveChangesAsync();
    }
}