using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Project.CLASSES
{
    internal class database
    {
        

        private SqlConnection connection = new SqlConnection("Data Source=IZHAAN;Initial Catalog=rms;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
        
        public DataTable getData(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int setData(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnection();
            int commandState = command.ExecuteNonQuery();
            closeConnection();
            return commandState;
        }
        public (string,int) setDataforAddtoOrder(string query, SqlParameter[] parameters, int menuID)
        {
            openConnection();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            string itemName= "";
            int itemPrice= 0;
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            
            itemName = reader["m_name"].ToString();
            itemPrice = Convert.ToInt32(reader["m_price"]);
            closeConnection();
            return (itemName,itemPrice);
        }

    }
}
