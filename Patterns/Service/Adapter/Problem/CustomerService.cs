namespace Service.Adapter.Problem
{
    using System.Collections.Generic;
    using System.Web;

    using Domain.Adapter;

    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IList<Customer> GetAllCustomers()
        {
            IList<Customer> customers;
            string storageKey = "GetAllCustomers";
            customers = (List<Customer>)HttpContext.Current.Cache.Get(storageKey);
            if (customers == null)
            {
                customers = this.customerRepository.GetCustomers();
                HttpContext.Current.Cache.Insert(storageKey, customers);
            }

            return customers;
        }
    }
}