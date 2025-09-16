using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project.FORMS
{
    public partial class login_form : Form
    {
        dashboard_form dash = new dashboard_form();
        public login_form()
        {
            
            InitializeComponent();
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../../IMAGES/login_pic.jpg");
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            CLASSES.database db = new CLASSES.database();
            string user = username.Text;
            string pass = password.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT usr_role FROM users WHERE usr_name = @usn AND usr_password= @pass;", db.getConnection());
            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            try
            {
                if (table.Rows.Count > 0)
                {
                    string role = Convert.ToString(table.Rows[0]["usr_role"]);

                    if (role == "admin") 
                    {
                        
                        this.Hide();
                        dash.Show();
                        dash.admin();
                    }
                    else  
                    {
                        this.Hide();
                       
                        dash.Show();
                        dash.user();
                    }
                }
                else
                {
                    if (user.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter your username to login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (pass.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter your password to login", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            } 
        }

        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.White;
            login_btn.BackColor = Color.Indigo;
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Transparent;
            login_btn.ForeColor = Color.Indigo;
        }
    }
}
