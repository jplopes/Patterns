namespace Service
{
    // Adapter
    using System.Collections.Generic;

    using Domain;

    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        private readonly ICacheStorage _cacheStorage;

        public CustomerService(ICustomerRepository customerRepository, ICacheStorage cacheStorage)
        {
            this._customerRepository = customerRepository;
            this._cacheStorage = cacheStorage;
        }

        public IList<Customer> GetAllCustomers()
        {
            IList<Customer> customers;
            string storageKey = "GetAllCustomers";
            customers = this._cacheStorage.Retrieve<List<Customer>>(storageKey);
            if (customers == null)
            {
                customers = this._customerRepository.GetCustomers();
                this._cacheStorage.Store(storageKey, customers);
            }

            return customers;
        }
    }
}