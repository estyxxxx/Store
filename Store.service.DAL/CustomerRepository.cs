using StoreModel;
using StoreModel.data;

namespace Store.service.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly StoreContext _storeContext;
        public CustomerRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public bool AddCustomer(Customer customer)
        {
            try
            {
                _storeContext.Add(customer);
                _storeContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Customer> GetAll()
        {
            return _storeContext.Customer.ToList();
        }

        public Customer GetCustomer(string CustomerName)
        {
            return _storeContext.Customer.Where(c => c.CustomerName == CustomerName).FirstOrDefault();
        }

        public bool RemoveCustomer(string CustomerName)
        {
            try
            {
                Customer c = _storeContext.Customer.Where(c => c.CustomerName == CustomerName).FirstOrDefault();
                if (c != null)
                {
                    _storeContext.Remove(c);
                    _storeContext.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public void Add(Customer customer)
        //{
        //    _storeContext.Add(customer);
        //    _storeContext.SaveChanges();
        //}
    }
}