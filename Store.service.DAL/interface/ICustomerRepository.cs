using StoreModel.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.DAL
{
    public interface ICustomerRepository
    {
        bool AddCustomer(Customer customer);
        List<Customer> GetAll();
        //void Add(Customer customer);
        Customer GetCustomer(string CustomerName);
        bool RemoveCustomer(string CustomerName);

    }
}
