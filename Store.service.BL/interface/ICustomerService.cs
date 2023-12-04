using StoreModel.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.BL
{
    public interface ICustomerService
    {
        bool? AddCustomer(Customer customer);
        public List<Customer> GetAll();
        bool RemoveCustomer(string CustomerName);
        Customer GetCustomer(string CustomerName);
        //void Add(int CustomerId, string CustomerName, string Adress, string PhoneNumber);
    }
}
