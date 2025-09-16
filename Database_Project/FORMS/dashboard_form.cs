
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project.FORMS
{
    public partial class dashboard_form : Form
    {
        CLASSES.User User = new CLASSES.User();
        CLASSES.items items = new CLASSES.items();
        CLASSES.database db = new CLASSES.database();
        CLASSES.menu menu = new CLASSES.menu();

        public dashboard_form()
        {
            InitializeComponent();
            user_panel.Visible = true;
            user_panel.BringToFront();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            login_form lgf = new login_form();
            lgf.Show();
            this.Close();
        }
        public void admin()
        {
            user_btn.PerformClick();
            pos_panel.Visible = false;


        }
        public void user()
        {
            Items_panel.Visible = false;
            user_panel.Visible = false;
            user_btn.Visible = false;
            items_btn.Visible = false;
            pos_panel.Visible = true;
            pos_panel.BringToFront();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            try
            {
                string username = name.Text;
                string pass = password.Text;

                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the name", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (pass.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the password", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (User.addUser(username, pass))
                    {
                        MessageBox.Show("New User Added Successfully", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        userdataGridView.DataSource = User.UserList();
                    }
                    else
                    {
                        MessageBox.Show("User Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dashboard_form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../../IMAGES/Project_logo.png");
            menudataGridView.DataSource = menu.menuList();

            userdataGridView.DataSource = User.UserList();
            
            itemsdataGridView1.DataSource = items.ItemList();
            
            
            orderdataGridView.DataSource = menu.OrderList();
            
            date_label.Text = DateTime.Now.ToString("dd-MM-yy");
            LoadCategories();
            LoadItemsByCategory("All");
            increamnetordernumber();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {


            try
            {
                string username = name.Text;
                string pass = password.Text;
                int ID = Convert.ToInt32(id.Text);

                if (username.Trim().Equals("") || pass.Trim().Equals(""))
                {
                    MessageBox.Show("Field should not be empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                else
                {
                    if (User.editUser(ID, username, pass))
                    {
                        MessageBox.Show("User Edited Successfully", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        userdataGridView.DataSource = User.UserList();
                    }
                    else
                    {
                        MessageBox.Show("User Not Edited", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void userdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = userdataGridView.CurrentRow.Cells[1].Value.ToString();
            password.Text = userdataGridView.CurrentRow.Cells[3].Value.ToString();
            id.Text = userdataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(id.Text);

                if (User.deleteUser(ID))
                {
                    MessageBox.Show("User Deleted Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    userdataGridView.DataSource = User.UserList();
                }
                else
                {
                    MessageBox.Show("User Not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string name = textBox_name.Text;
            string cat = textBox_category.Text;
            int price = Convert.ToInt32(textBox_price.Text);

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter the item name", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cat.Trim().Equals(""))
            {
                MessageBox.Show("Enter the category", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (price < 0)
            {
                MessageBox.Show("Enter the price", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (items.addItem(name, cat, price))
                {
                    MessageBox.Show("New Item Added Successfully", "New Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    itemsdataGridView1.DataSource = items.ItemList();

                }
                else
                {
                    MessageBox.Show("Item Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SetButtonStyle(Button activeBtn, Button inactiveBtn)
        {
            activeBtn.BackColor = Color.Purple;
            activeBtn.ForeColor = Color.White;

            inactiveBtn.BackColor = Color.LightGray;
            inactiveBtn.ForeColor = Color.Red;
        }


        private void items_btn_Click(object sender, EventArgs e)
        {
            Items_panel.BringToFront();
            Items_panel.Visible = true;
            user_panel.Visible = false;
            SetButtonStyle(items_btn, user_btn);

        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            SetButtonStyle(user_btn, items_btn);
            user_panel.Visible = true;
            Items_panel.Visible = false;
        }

        private void itemsdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = itemsdataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = itemsdataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_category.Text = itemsdataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_price.Text = itemsdataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox_name.Text;
                string cat = textBox_category.Text;
                int price = Convert.ToInt32(textBox_price.Text);
                int id = Convert.ToInt32(textBox_id.Text);

                if (name.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the item name", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (cat.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the category", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (price < 0)
                {
                    MessageBox.Show("Enter the price", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (items.editItems(id, name, cat, price))
                    {
                        MessageBox.Show("New Item Edited Successfully", "Edit Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        itemsdataGridView1.DataSource = items.ItemList();

                    }
                    else
                    {
                        MessageBox.Show("Item Not Edited", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox_id.Text);

                if (items.deleteItems(ID))
                {
                    MessageBox.Show("Item Deleted Successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    itemsdataGridView1.DataSource = items.ItemList();
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int ID { get; set; }
        private void addtoorder_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox_quantity.Text);

                if (menu.addtoorder(ID, quantity))
                {
                    orderdataGridView.DataSource = menu.OrderList();
                    int total = menu.returntotal(orderdataGridView);
                    label_total.Text = total.ToString();

                }
                else
                {
                    MessageBox.Show("Error Occured While Inserting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Enter Quantity", "Error-Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void menudataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(menudataGridView.CurrentRow.Cells[0].Value);
        }





        private void LoadCategories()
        {
            string query = "SELECT DISTINCT m_category FROM menu";

            using (SqlConnection conn = db.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow allRow = dt.NewRow();
                allRow["m_category"] = "All";
                dt.Rows.InsertAt(allRow, 0);

                comboBox_items.DataSource = dt;
                comboBox_items.DisplayMember = "m_category";
                comboBox_items.ValueMember = "m_category";
            }
        }
        private void LoadItemsByCategory(string category)
        {

            string query;

            if (category == "All")
            {
                query = "SELECT m_id as ID, m_name NAME, m_category as CATEGORY, m_price as PRICE FROM menu";
            }
            else
            {
                query = "SELECT m_id as ID, m_name NAME, m_category as CATEGORY, m_price as PRICE FROM menu WHERE m_category = @Category";
            }

            using (SqlConnection conn = new SqlConnection("Data Source=IZHAAN;Initial Catalog=rms;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                if (category != "All")
                {

                    cmd.Parameters.AddWithValue("@Category", category);
                }
                adapter.Fill(dt);
                menudataGridView.DataSource = dt;

            }
        }

        private void comboBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_items.SelectedValue != null)
            {
                string selectedCategory = comboBox_items.SelectedValue.ToString();
                LoadItemsByCategory(selectedCategory);
            }
        }


        private void orderdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(orderdataGridView.CurrentRow.Cells[0].Value);
            menu.deletefromorder(id);
            orderdataGridView.DataSource = menu.OrderList();

        }
        public void increamnetordernumber()
        {
            int ordernumber = Convert.ToInt32(menu.storeordernumber());
            textBox_ordernumber.Text = Convert.ToString(ordernumber + 1);

        }

        private void button_createorder_Click(object sender, EventArgs e)
        {
            try
            {

                int number = Convert.ToInt32(textBox_ordernumber.Text);
                int total = Convert.ToInt32(label_total.Text);
                DateTime date = DateTime.Now;
                if (total == 0)
                {
                    MessageBox.Show("Order Not Created", "Create-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (menu.CreateOrder(orderdataGridView, number, date, total))
                    {
                        MessageBox.Show("Order Created Successfully", "Order Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        menu.EmptyOrder();
                        orderdataGridView.DataSource = menu.OrderList();
                        increamnetordernumber();
                    }
                    else
                    {
                        MessageBox.Show("Order Not Created", "Create-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fields Cannot Be Empty", "Error-Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_orders_form orderform = new view_orders_form();
            orderform.Show();
        }
    }
}