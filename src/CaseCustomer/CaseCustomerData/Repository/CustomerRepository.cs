using CaseCustomerData.Context;
using CaseCustomerDomain.Entities;
using CaseCustomerDomain.Interfaces;

namespace CaseCustomerData.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext context) : base(context) { }
    }
}
