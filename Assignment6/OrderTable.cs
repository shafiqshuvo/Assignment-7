using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment6.Manager;

namespace Assignment6
{
    public partial class OrderTable : Form

    {
        OrderManager _orderManager = new OrderManager();

        public OrderTable()
        {
            InitializeComponent();
        }

    
        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerIdTextBox.Text) || String.IsNullOrEmpty(itemNameTextBox.Text) || String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Field  Cant be Empty!");
                return;
            }
           
            if (_orderManager.isOrderExist(Convert.ToInt32(customerIdTextBox.Text), itemNameTextBox.Text, Convert.ToInt32(quantityTextBox.Text)))
            {
                MessageBox.Show("Order Alredy Taken!!!");
                return;
            }
            

            bool isAdded = _orderManager.AddData(Convert.ToInt32(customerIdTextBox.Text), itemNameTextBox.Text, Convert.ToInt32 (quantityTextBox.Text));
           if (isAdded)
            {
                MessageBox.Show("Order is Successful.");
            }
            else
            {
                MessageBox.Show("Order cant taken. ");
            }

            showOrderGridView.DataSource = _orderManager.ShowData();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            showOrderGridView.DataSource = _orderManager.ShowData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (_orderManager.isUpdateExist(Convert.ToInt32(customerIdTextBox.Text)))
            {
                MessageBox.Show("Customer ID  " + customerIdTextBox.Text + "  will be updated!!!");

                if (String.IsNullOrEmpty(quantityTextBox.Text) || String.IsNullOrEmpty(itemNameTextBox.Text))
                {
                    MessageBox.Show("  Quantity and Item Name Must be required !!!");

                    return;
                }
              

            }

            else
            {
                MessageBox.Show(" Customer ID " + customerIdTextBox.Text + " doesnot exist in the database!!!");

                return;
            }

            bool isUpdated = _orderManager.UpdateData(Convert.ToInt32(customerIdTextBox.Text), itemNameTextBox.Text, Convert.ToInt32(quantityTextBox.Text));

            if (isUpdated)
            {
                MessageBox.Show("Update Successful");
            }

            else
            {
                MessageBox.Show(" SORRY Can't   Update");

            }

            showOrderGridView.DataSource = _orderManager.ShowData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = _orderManager.DeleteData(Convert.ToInt32(customerIdTextBox.Text),itemNameTextBox.Text);

            if (isDeleted)
            {
                MessageBox.Show("Item Delated Successfully.");
            }
            else
            {
                MessageBox.Show(" Item Not Found !!.");
            }

            showOrderGridView.DataSource = _orderManager.ShowData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            showOrderGridView.DataSource = _orderManager.SearchData(Convert.ToInt32(idSearchTextBox.Text));

            if (_orderManager.isSearchExist(Convert.ToInt32(idSearchTextBox.Text)))
            {
               MessageBox.Show("Customer  " + idSearchTextBox.Text + " Found");

                
            }
            else
            {
                
               MessageBox.Show("Customer  " + idSearchTextBox.Text + " Not Found");
                
            }

          
        }

        private void customerDetails_Click(object sender, EventArgs e)
        {    
          
            showOrderGridView.DataSource = _orderManager.CustomerDetails(nameSearchTextBox.Text);
           
        }
    }
}

