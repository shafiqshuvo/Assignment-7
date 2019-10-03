using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Repository;

namespace Assignment6.Manager
{
    public class ItemManager
    {
        //ItemManager _itemManager = new ItemManager();
        ItemRepository _itemRepository = new ItemRepository();

        public bool isNameExist(string name)
        {

            return _itemRepository.isNameExist(name);
        }

        public bool AddData(string name, double price)
        {
           return  _itemRepository.AddData( name, price);
        }

        public bool DeleteData(string name)
        {
            return _itemRepository.DeleteData(name);
        }

        public DataTable ShowData()
        {
            return _itemRepository.ShowData();
        }

        public bool UpdateData(string name, string price, string id)
        {
            return _itemRepository.UpdateData(name, price, id);
        }
        public bool isUpdateExist(string id)
        {
            return _itemRepository.isUpdateExist(id);
        }
        public bool isSearchExist(string name)
        {
            return _itemRepository.isSearchExist(name);
        }

        public DataTable SearchData(string name)
        {
            return _itemRepository.SearchData(name);
        }
    }
  
    
}
