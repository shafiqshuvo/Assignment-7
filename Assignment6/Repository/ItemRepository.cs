using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment6.Repository
{
    public class ItemRepository
    {

        public bool AddData(string name, double price)
        {

            bool isAdded = false;

            try
            {


                //Connection Establish
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"INSERT INTO Item_Table (Item_Name, Item_Price) VALUES( '" + name + " ', " + price + ")";
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
        public bool isNameExist(string name)
        {
            bool isExist = false;

            try
            {

                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Item_Table WHERE Item_Name  = '" + name + "' ";
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
               // MessageBox.Show(exception.Message);
            }

            return isExist;
        }

        public bool isSearchExist(string name)
        {
            bool isExist = false;

            try
            {

                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Item_Table WHERE Item_Name  = '" + name + "' ";
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
                // MessageBox.Show(exception.Message);
            }

            return isExist;
        }

        public DataTable SearchData(string name)
        {
           
            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish
            string commandString = @"SELECT * FROM Item_Table WHERE Item_Name = '" + name + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            //Sql command Execute
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           
                
            sqlConnection.Close();

            return dataTable ;

        }

        public bool DeleteData(string name)

        {
            bool isDeleted = false;

            string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Comand establish
            string commandString = @"DELETE FROM Item_Table WHERE  Item_Name = '" + name + "' ";
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
                string commandString = @"SELECT * FROM Item_Table";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);


                //if (dataTable.Rows.Count > 0)
                //{
                //    //showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    //showDataGridView.DataSource = null;
                //    //MessageBox.Show("No data Found!!");
                //}


                sqlConnection.Close();
                return dataTable;
            }

        public bool isUpdateExist(string id)
        {
            bool isExist = false;

            try
            {

                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Comand establish
                string commandString = @"SELECT * FROM Item_Table WHERE Item_Id  = '" + id + "' ";
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
        public bool UpdateData(string name, string price, string id)
        {
            //check for existing name CANT BE UPDATED
            bool isUpdate = false;
            try
            {
                string connectionString = @"Server=FATEMA; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command establish
                string commandString = @"UPDATE Item_Table SET Item_Name = '" + name + "',  Item_Price = " + price + "  WHERE Item_Id = " + id + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                //Sql command Execute
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    isUpdate = true;
                }

                sqlConnection.Close();

            }

            catch (Exception exception)

            {
                //MessageBox.Show(exception.Message);
            }

            return isUpdate;
        }


    }
}

