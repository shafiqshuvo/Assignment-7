using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment6.Repository
{
    public class CustomerRepository
    {
        public bool isNameExist(string name)
        {
            bool isExist = false;

            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Customer_Table WHERE Customer_Name = '" + name + "' ";
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
                //MessageBox.Show(exception.Message);
            }
            return isExist;
        }
        public bool AddData(string customerName, string contactNumber)
        {
            bool isAdded = false;
            try
            {

                //Connection Establish
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"INSERT INTO Customer_Table (Customer_Name, Contact_No) VALUES ('" + customerName + "', '" + contactNumber + "')";
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

        public bool isUpdateExist(string id)
        {
            bool isExist = false;

            try
            {

                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Customer_Table WHERE Customer_Id  = '" + id + "' ";
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
                //MessageBox.Show(exception.Message);
            }

            return isExist;
        }
        public bool UpdateData(string name, string mobileNumber, string id)
        {
            bool isUpdated = false;
            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command establish
                string commandString = @"UPDATE Customer_Table SET Customer_Name = '" + name + "',  Contact_No = '" + mobileNumber + "' WHERE Customer_Id= " + id + " ";
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


        public bool DeleteData(string name)
        {
            bool isDeleted = false;

            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish
            string commandString = @"DELETE FROM Customer_Table WHERE  customer_Name = '" + name + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute
            int isExecuted = sqlCommand.ExecuteNonQuery();

            if (isExecuted > 0)
            {
                isDeleted = true;
            }


            sqlConnection.Close();

            return isDeleted;

        }

        public DataTable ShowData()
        {

            //Connection Establish
            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish
            string commandString = @"SELECT * FROM Customer_Table";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //{
            //    //customerDetailsDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    customerDetailsDataGridView.DataSource = null;
            //    MessageBox.Show("No data Found!!");
            //}


            sqlConnection.Close();
            return dataTable;

        }

        public bool isSearchExist(string name)
        {
            bool isExist = false;

            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Customer_Table WHERE Customer_Name = '" + name + "' ";
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
                //MessageBox.Show(exception.Message);
            }
            return isExist;
        }

        public DataTable SearchData(string name)
        {
            
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Customer_Table WHERE Customer_Name = '" + name + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    //customerDetailsDataGridView.DataSource = dataTable;
                //    isSearchExist = true;
                //}

                sqlConnection.Close();
          
               return dataTable;
        }
    }
}
