using CustomerEvidenceApp.Data.Factories;
using CustomerEvidenceApp.Data.Models;

namespace CustomerEvidenceApp.Data.Seeders
{
    public class CustomerSeeder : BaseSeeder<Customer>
    {
        private readonly SQLiteDbContext _context;

        public CustomerSeeder(SQLiteDbContext context) : base(context, new CustomerFactory())
        {
            _context = context;
        }

        public override async Task SeedAsync(int? count = null)
        {
            var customers = Factory.Generate(count ?? DefaultCount);
            await SaveChangesWithIdentityInsertAsync(_context.Customers, customers);
        }
    }
}
