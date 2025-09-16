using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project.CLASSES
{
    internal class User
    {
        database db = new database();
        public Boolean addUser(string name, string password)
        {
            if (name.ToLower() == "admin")
            {
                return false;
            }
            else
            {
                string query = "INSERT INTO users(usr_name,usr_role,usr_password) VALUES (@name,'User',@password)";


                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
                parameters[0].Value = name;

                parameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
                parameters[1].Value = password;

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
        public DataTable UserList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT usr_id as ID, usr_name as NAME, usr_role as ROLE, usr_password as PASSWORD FROM users", null);
            return table;
        }
        public Boolean editUser(int id, string name, string password)
        {
            string query = "update users set usr_name = @name,usr_password = @password where usr_id = @id";


            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            parameters[1].Value = password;

            parameters[2] = new SqlParameter("@id", SqlDbType.VarChar);
            parameters[2].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean deleteUser(int id)
        {
            if (id == 1)
            {
                return false;
            }
            string query = "delete from users where usr_id = @id";


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
