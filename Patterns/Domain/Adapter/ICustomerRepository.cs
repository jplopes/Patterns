namespace Domain.Adapter
{
    // Adapter
    using System.Collections.Generic;

    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
    }
}