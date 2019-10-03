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
    public partial class Form1 : Form
    {
        ItemManager _itemManager = new ItemManager();

        public Form1()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (_itemManager.isNameExist(itemNameTextBox.Text))
            {
                MessageBox.Show( itemNameTextBox.Text + " Already exist!!!");
                return ;
            }
            if (String.IsNullOrEmpty(itemPriceTextBox.Text))
            {
                MessageBox.Show( " Price must be Added !!!");
                return;
            }

            bool isAdded = _itemManager.AddData(itemNameTextBox.Text , Convert.ToDouble(itemPriceTextBox.Text));

            if (isAdded)
            {
                MessageBox.Show(" Saved.");
            }

            else
            {
                MessageBox.Show(" Not Saved !!!.");
            }

            showDataGridView.DataSource = _itemManager.ShowData();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            showDataGridView.DataSource = _itemManager.ShowData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (_itemManager.isSearchExist(itemNameTextBox.Text))
            {
                MessageBox.Show(itemNameTextBox.Text + "  exist!!!");
                showDataGridView.DataSource = _itemManager.SearchData(itemNameTextBox.Text);
                return;
            }
            else
            {
                MessageBox.Show(itemNameTextBox.Text + " Not Found!!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = _itemManager.DeleteData(itemNameTextBox.Text);

            if(isDeleted)
            {
                MessageBox.Show("Item Delated Successfully.");
            }
            else
            {
                MessageBox.Show(" Item Not Found !!.");
            }

            showDataGridView.DataSource = _itemManager.ShowData();
        }

        //
        private void updateButton_Click(object sender, EventArgs e)
        {
            //CHECK FOR ID VALIDATION
            if (_itemManager.isUpdateExist(itemIdTextBox.Text))
            {
                MessageBox.Show("ID  " + itemIdTextBox.Text + " will be updated!!!");

                if ( String.IsNullOrEmpty(itemPriceTextBox.Text) && String.IsNullOrEmpty(itemNameTextBox.Text))
                {
                    MessageBox.Show(" Name and Price must be required !!!");

                    return;
                }
               
               
            }
            else
            {
                MessageBox.Show(" ID " + itemIdTextBox.Text + " doesnot exist in the database!!!");
                itemIdTextBox.Clear();
                return;
            }

            //CALL UPDATE()
            bool isUpdated = _itemManager.UpdateData(itemNameTextBox.Text, itemPriceTextBox.Text, itemIdTextBox.Text);

            if (isUpdated)
            {
                MessageBox.Show(" Update successful ");
            }
            

            else
            {
                MessageBox.Show("SORRY !!! Can Not Update!!!.");
            }

            //show method in Ui 
            showDataGridView.DataSource = _itemManager.ShowData();
        }

        private void customerDetailsButton_Click(object sender, EventArgs e)
        {
            CustomerTable customerTable = new CustomerTable();
            this.Hide();
            customerTable.ShowDialog();
            this.Show();
            
        }

        
    }
}

