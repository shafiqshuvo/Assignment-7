using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Repository;

namespace Assignment6.Manager
{
    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();


        public bool isOrderExist(int customerId, string item, int quantity)
        {
            return _orderRepository.isOrderExist(customerId, item, quantity);
        }

        public bool AddData(int customerId, string item, int quantity)
        {
            return _orderRepository.AddData(customerId, item, quantity);
        }


        public bool DeleteData(int customerId, string itemName)
        {
            return _orderRepository.DeleteData(customerId,itemName);
        }
   
        public bool isUpdateExist(int customerId)
        {
            return _orderRepository.isUpdateExist(customerId);
        }

        public bool UpdateData(int customerId, string item, int quantity)
        {
           return  _orderRepository.UpdateData(customerId, item, quantity);
        }

        public DataTable ShowData()
        {
            return _orderRepository.ShowData();
        }

        public bool isSearchExist(int customerId)
        {
            return _orderRepository.isSearchExist(customerId);
        }

        public DataTable SearchData(int customerId)
        {
            return _orderRepository.SearchData(customerId);
        }

        public DataTable CustomerDetails(string name)
        {
            return _orderRepository.CustomerDetails(name);
        }


    }
}
