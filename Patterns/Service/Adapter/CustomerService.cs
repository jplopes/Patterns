namespace Service.Adapter
{
    using System.Collections.Generic;

    using Domain.Adapter;

    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        private readonly ICacheStorage cacheStorage;

        public CustomerService(ICustomerRepository customerRepository, ICacheStorage cacheStorage)
        {
            this.customerRepository = customerRepository;
            this.cacheStorage = cacheStorage;
        }

        public IList<Customer> GetAllCustomers()
        {
            IList<Customer> customers;
            string storageKey = "GetAllCustomers";
            customers = this.cacheStorage.Retrieve<List<Customer>>(storageKey);
            if (customers == null)
            {
                customers = this.customerRepository.GetCustomers();
                this.cacheStorage.Store(storageKey, customers);
            }

            return customers;
        }
    }
}