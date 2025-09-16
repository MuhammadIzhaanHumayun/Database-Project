using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;


namespace Database_Project.CLASSES
{
    internal class menu
    {
        CLASSES.database db = new CLASSES.database();
        public DataTable menuList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT m_id as ID, m_name as NAME, m_category as CATEGORY, m_price as PRICE FROM menu", null);
            return table;
        }
        public DataTable OrderList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT ord_id as S_NO, ord_name as ITEMS, ord_price as UNIT_PRICE, ord_quantity as QUANTITY, ord_total as TOTAL FROM orders", null);
            return table;
        }
        public DataTable EmptyOrder()
        {
            DataTable table = new DataTable();
            table = db.getData("truncate table orders", null);
            return table;
        }
        public Boolean addtoorder(int menuID,int quantity)
        {
            string query = "SELECT m_name, m_price FROM menu WHERE m_id = @MenuId";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MenuId", SqlDbType.Int);
            parameter[0].Value = menuID;
            var (itemName, itemPrice) = db.setDataforAddtoOrder(query, parameter, menuID);
            int total = itemPrice * quantity;

            string query2 = "insert into orders(ord_name,ord_price,ord_quantity,ord_total) values(@name, @price, @quantity, @total)";
                
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            parameters[0].Value = itemName;

            parameters[1] = new SqlParameter("@price", SqlDbType.Int);
            parameters[1].Value = itemPrice;

            parameters[2] = new SqlParameter("@quantity", SqlDbType.Int);
            parameters[2].Value = quantity;

            parameters[3] = new SqlParameter("@total", SqlDbType.Int);
            parameters[3].Value = total;
                
            if (db.setData(query2, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        public Boolean deletefromorder(int id)
        {
            string query = "delete from orders where ord_id = @id";


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
        public int returntotal(DataGridView grid)
        {
            int total = 0;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells["TOTAL"].Value != null)
                {
                    int value;
                    if (int.TryParse(row.Cells["TOTAL"].Value.ToString(), out value))
                    {
                        total += value;
                    }
                }
            }
            

            return total;
        }

        public string storeordernumber()
        {
            db.openConnection();
            string query = "select order_number from createdorders order by order_number desc";
            SqlCommand cmd = new SqlCommand(query, db.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string number = reader["order_number"].ToString();
            db.closeConnection();
            return number;
        }

        public Boolean CreateOrder(DataGridView grid, int number, DateTime date,int total)
        {
            

            List<object> orderItems = new List<object>();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                var item = new
                {
                    name = row.Cells["ITEMS"].Value.ToString(),
                    quantity = row.Cells["QUANTITY"].Value.ToString(),
                    Total = row.Cells["TOTAL"].Value.ToString()
                };

                orderItems.Add(item);
            }
            string itemsJson = JsonSerializer.Serialize(orderItems);

            string query = "insert into createdorders(order_number,order_date,order_items,order_total) values(@ord_number,@ord_date,@ord_items,@ord_total)";

            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@ord_number", SqlDbType.Int);
            parameters[0].Value = number;

            parameters[1] = new SqlParameter("@ord_date", SqlDbType.DateTime);
            parameters[1].Value = date;

            parameters[2] = new SqlParameter("@ord_items", SqlDbType.NVarChar);
            parameters[2].Value = itemsJson;

            parameters[3] = new SqlParameter("@ord_total", SqlDbType.Int);
            parameters[3].Value = total;

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
