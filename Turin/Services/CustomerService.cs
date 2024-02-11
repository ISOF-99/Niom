using ConsoleApp.Repositories;
using Turin.Entity;

namespace Turin.Services
{
    internal class CustomerService
    {
        private readonly CustomerRepository customerRepository;
        private readonly AddressService addressService;
        private readonly RoleService roleService;

        public CustomerService(CustomerRepository customerRepository, AddressService addressService, RoleService roleService)
        {
            this.customerRepository = customerRepository;
            this.addressService = addressService;
            this.roleService = roleService;
        }

        public CustomerEntity CreateCustomer(string firstName, string lastName, string email, string roleName, string streetName, string postalCode, string city)
        {
            var roleEntity = roleService.CreateRole(roleName);
            var adressEntity = addressService.CreateAdress(streetName, postalCode, city);

            var customerEntity = new CustomerEntity
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                RoleId = roleEntity.Id,
                AddressId = adressEntity.Id
            };

            customerEntity = customerRepository.Create(customerEntity);

            return customerEntity;
        }

        public CustomerEntity GetCustomerByEmail(string email)
        {
            var customerEntity = customerRepository.Get(x => x.Email == email);
            return customerEntity;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            var customerEntity = customerRepository.Get(x => x.Id == id);
            return customerEntity;
        }

        public IEnumerable<CustomerEntity> GetCustomers()
        {
            var customers = customerRepository.GetAll();
            return customers;
        }

        public CustomerEntity UpdateCustomer(CustomerEntity customerEntity)
        {
            var updatedCustomerEntity = customerRepository.Update(x => x.Id == customerEntity.Id, customerEntity);
            return updatedCustomerEntity;
        }

        public void DeleteCustomer(int id)
        {
            customerRepository.Delete(x => x.Id == id);
        }
    }
}
