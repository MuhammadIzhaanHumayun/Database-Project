using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database_Project.CLASSES
{
    internal class orders
    {
        CLASSES.database db = new CLASSES.database();
        public DataTable CreatedOrderList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT order_number as ORDER_NO, order_date as DATE, order_total as TOTAL FROM createdorders where order_number != 999", null);
            return table;
        }
        public Boolean deleteorder(int number)
        {
            string query = "delete from createdorders where order_number = @number";


            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@number", SqlDbType.VarChar);
            parameters[0].Value = number;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
