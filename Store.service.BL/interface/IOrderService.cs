using StoreModel.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.BL
{
    public interface IOrderService
    {
        bool? AddOrder(Order order);
        //bool RemoveOrder(string TZ);
        List<Order> GetAll();
        //Order GetOrder(string TZ);
    }
}
