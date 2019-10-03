using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Repository
{

    public class OrderRepository
    {
        public bool isOrderExist(int customerId, string item, int quantity)
        {
            bool isExist = false;

            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Order_Table WHERE Customer_Id = " + customerId + " and Item_Name = '" + item + "' and Quantity = " + quantity + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }

                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message);
            }

            return isExist;
        }

        public bool AddData(int customerId, string item, int quantity)
        {
            bool isAdded = false;
            try
            {

                //Connection Establish
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"INSERT INTO Order_Table (Customer_Id, Item_Name, Quantity ) VALUES( " + customerId + ",'" + item + "', " + quantity + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    isAdded = true;
                }


                sqlConnection.Close();


            }
            catch (Exception exception)
            {
                // MessageBox.Show(exception.Message);
            }

            return isAdded;
        }


        public bool DeleteData(int customerId, string itemName)
        {
            bool isDeleted = false;
            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"DELETE FROM Order_Table WHERE Customer_Id = " + customerId + " and Item_Name = '" + itemName + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    isDeleted = true;
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return isDeleted;
        }

        public bool isUpdateExist(int customerId)
        {
            bool isExist = false;

            try
            {

                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Order_Table WHERE Customer_Id  = " + customerId + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Ckeck for uniqueness
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;

                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message);
            }

            return isExist;
        }

        public bool UpdateData(int customerId, string item, int quantity)
        {
            bool isUpdated = false;
            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command establish
                string commandString = @"UPDATE Order_Table SET  Quantity = " + quantity + " , Item_Name = '" + item + "' WHERE Customer_Id = " + customerId + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isUpdated = true;
                }

                sqlConnection.Close();

            }

            catch (Exception exception)

            {
                //MessageBox.Show(exception.Message);
            }

            return isUpdated;
        }

        public DataTable ShowData()
        {
            //Connection Establish
            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish
            string commandString = @"SELECT * FROM Order_Table";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //{
            //    showOrderGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    showOrderGridView.DataSource = null;
            //    MessageBox.Show("No data Found!!");
            //}


            sqlConnection.Close();
            return dataTable;

        }

        public bool isSearchExist(int customerId)
        {
            bool isExist = false;

            try
            {

                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Order_Table WHERE Customer_Id  = " + customerId + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //Ckeck for uniqueness
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;

                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message);
            }

            return isExist;

        }
        public DataTable SearchData(int customerId)
        {

            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish

            //string commandString = @"SELECT * FROM Order_Table WHERE ID  = " + nameSearchTextBox.Text + " ";
            /*string commandString = @"SELECT Customer_Name, Item_Name, Price  FROM Order_Table
            JOIN Customer_Table ON Order_Table.Customer_Id = Customer_Table.Customer_Id 
            JOIN Item_Table ON Order_Table.Item_Id = Item_Table.Item_Id  WHERE Customer_Name  =  '" + nameSearchTextBox.Text + "' ";*/

            string commandString = @"SELECT * FROM Order_Table WHERE Customer_Id  = " + customerId + " ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{

            //    showOrderGridView.DataSource = dataTable;
            //    isExist = true;
            //}


            sqlConnection.Close();
            return dataTable;
        }

        public DataTable CustomerDetails(string name)
        {

            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT Customer_Name, Item_Price, Total_price = (Item_Price * Quantity), Contact_No 
            FROM Order_Table 
            JOIN Customer_Table ON Order_Table.Customer_Id = Customer_Table.Customer_Id 
            JOIN Item_Table ON Order_Table.Item_Name = Item_Table.Item_Name WHERE Customer_Name  =  '" + name + "' ";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    showOrderGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    showOrderGridView.DataSource = null;
            //    MessageBox.Show("No data Found!!");
            //}

            sqlConnection.Close();
            return dataTable;


        }

    }
}
