
using CaseCustomerDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaseCustomerData.Context
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}