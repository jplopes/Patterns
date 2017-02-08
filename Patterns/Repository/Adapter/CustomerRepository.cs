namespace Repository.Adapter
{
    using System.Collections.Generic;

    using Domain.Adapter;

    public class CustomerRepository : ICustomerRepository
    {
        public IList<Customer> GetCustomers()
        {
            throw new System.NotImplementedException();
        }
    }
}