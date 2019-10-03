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
    public partial class CustomerTable : Form
    {
        CustomerManager _customerManager = new CustomerManager();

        public CustomerTable()
        {
            InitializeComponent();
        }

       

        private void addButton_Click(object sender, EventArgs e)
        {
           if(_customerManager.isNameExist(customerNameTextBox.Text))
            {
                MessageBox.Show("Customer Name Is ALREADY Exists!!!");
                return;
            }
            if (String.IsNullOrEmpty(customerNameTextBox.Text) || (String.IsNullOrEmpty(contactNumberTextBox.Text)))
            {
                MessageBox.Show("Name and Mobile Number Must be Added!!!");
                return;
            }

            bool added = _customerManager.AddData(customerNameTextBox.Text, contactNumberTextBox.Text);
            if(added)
            {
                MessageBox.Show("Successfully added.");
            }
            else
            {
                MessageBox.Show("Can't be added.");
            }

            customerDetailsDataGridView.DataSource = _customerManager.ShowData();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customerDetailsDataGridView.DataSource = _customerManager.ShowData();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            customerDetailsDataGridView.DataSource =  _customerManager.SearchData(customerNameTextBox.Text);

            //bool isSearchExist 

             if (_customerManager.isSearchExist(customerNameTextBox.Text))
             {
                 MessageBox.Show("Seach successful ");
             }
             else
             {
                MessageBox.Show("Seach Data not Found ");
             }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (_customerManager.isUpdateExist(customerIdTextBox.Text))
            {
                MessageBox.Show("Customer ID  " + customerIdTextBox.Text + "  will be updated!!!");

                if (String.IsNullOrEmpty(contactNumberTextBox.Text) )
                {
                    MessageBox.Show("  Customer Mobile Numbermust be required !!!");

                    return;
                }
                if (String.IsNullOrEmpty(customerNameTextBox.Text))
                {
                    MessageBox.Show("Customer Name Customer Mobile Number must be required !!!");

                    return;
                }


            }

            else
            {
                MessageBox.Show(" ID " + customerIdTextBox.Text + " doesnot exist in the database!!!");
                
                return;
            }

            //CALL UPDATE()
            bool isUpdated = _customerManager.UpdateData(customerNameTextBox.Text, contactNumberTextBox.Text , customerIdTextBox.Text);

            if (isUpdated)
            {
                MessageBox.Show(" Update successful ");
            }


            else
            {
                MessageBox.Show("SORRY !!! Can Not Update!!!.");
            }

            customerDetailsDataGridView.DataSource = _customerManager.ShowData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = _customerManager.DeleteData(customerNameTextBox.Text);

            if (isDeleted)
            {
                MessageBox.Show(customerNameTextBox.Text + " is Delated Successfully.");
            }
            else
            {
                MessageBox.Show(customerNameTextBox.Text+ " Not Found !!.");
            }

            customerDetailsDataGridView.DataSource = _customerManager.ShowData();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            OrderTable orderTable = new OrderTable();
            this.Hide();
            orderTable.ShowDialog();
            this.Show();
        }
    }
}
