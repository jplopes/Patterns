namespace Domain
{
    // Adapter
    using System.Collections.Generic;

    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
    }
}