using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Assignment6.Repository;

namespace Assignment6.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();


        public bool isNameExist(string name)

        {
            return _customerRepository.isNameExist(name);
        }
        public bool AddData(string customerName, string contactNumber)
        {
            return _customerRepository.AddData(customerName,contactNumber);
        }


        public bool isUpdateExist(string id)
        {
            return _customerRepository.isUpdateExist(id);
        }
        public bool UpdateData(string name, string mobileNumber, string id)
        {
            return _customerRepository.UpdateData(name, mobileNumber, id);

        }

        public bool DeleteData(string name)
        {
            return _customerRepository.DeleteData(name);

        }

        public DataTable ShowData()

        {

            return _customerRepository.ShowData();
        }


        public bool isSearchExist(string name)
        {
            return _customerRepository.isSearchExist(name);
           
        }
        public DataTable SearchData(string name)
        {
            return _customerRepository.SearchData(name);

        }


    }
}
