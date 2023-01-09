using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class SaleFactRepository : RepositoryBase<SaleFact>
{
    public SaleFactRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
}