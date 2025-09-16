using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project.CLASSES
{
    internal class items
    {
        database db = new database();
        public Boolean addItem(string name, string category, int price)
        {
            string query = "INSERT INTO menu(m_name,m_category,m_price) VALUES (@name,@category,@price)";


            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new SqlParameter("@category", SqlDbType.VarChar);
            parameters[1].Value = category;

            parameters[2] = new SqlParameter("@price", SqlDbType.Int);
            parameters[2].Value = price;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable ItemList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT m_id as ID, m_name as NAME, m_category as CATEGORY, m_price as PRICE FROM menu", null);
            return table;
        }
        public Boolean editItems(int id, string name, string category, int price)
        {
            string query = "update menu set m_name = @name,m_category = @category,m_price = @price where m_id = @id";


            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new SqlParameter("@category", SqlDbType.VarChar);
            parameters[1].Value = category;

            parameters[2] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[2].Value = id;

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar);
            parameters[3].Value = price;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean deleteItems(int id)
        {
            string query = "delete from menu where m_id = @id";


            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[0].Value = id;

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
