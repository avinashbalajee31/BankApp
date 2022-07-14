using Microsoft.EntityFrameworkCore;

namespace BankApp.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerModel> Customers { get; set; }

    }
}

