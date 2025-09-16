using Database_Project.CLASSES;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Database_Project.FORMS
{
    public partial class view_orders_form : Form
    {
        CLASSES.database db = new database();
        CLASSES.orders order = new CLASSES.orders();
        FORMS.dashboard_form dash = new FORMS.dashboard_form();
        public view_orders_form()
        {
            InitializeComponent();
        }

        private void view_orders_form_Load(object sender, EventArgs e)
        {
            orderdataGridView.DataSource = order.CreatedOrderList();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int ordernumber { get; set; }
        public string item { get; set; }
        public int quantity { get; set; }
        public int ordertotal { get; set; }
        public int total { get; set; }
        public DateTime date { get; set; }
        List<(string, int, int)> printItems;
        private void orderdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(orderdataGridView.CurrentRow.Cells[0].Value) == null)
            {
                ordernumber = 0;
            }
            else
            {
                ordernumber = Convert.ToInt32(orderdataGridView.CurrentRow.Cells[0].Value);
            }
        }

        public void getorderforprint()
        {
            printItems = new List<(string, int, int)>();
            db.openConnection();

            string query = "SELECT item.name, item.quantity, item.Total FROM createdorders CROSS APPLY OPENJSON(createdorders.order_items) WITH (name NVARCHAR(100), quantity INT, Total INT) AS item WHERE createdorders.order_number = @ordernumber";

            SqlCommand cmd = new SqlCommand(query, db.getConnection());
            cmd.Parameters.AddWithValue("@ordernumber", ordernumber);


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    item = reader["name"].ToString();
                    quantity = Convert.ToInt32(reader["quantity"]);
                    total = Convert.ToInt32(reader["Total"]);
                    printItems.Add((item, quantity, total));

                }
            }


            string query2 = "SELECT order_date AS date, order_total AS ordertotal FROM createdorders WHERE order_number = @ordernumber";
            SqlCommand cmd2 = new SqlCommand(query2, db.getConnection());
            cmd2.Parameters.AddWithValue("@ordernumber", ordernumber);

            using (SqlDataReader reader2 = cmd2.ExecuteReader())
            {
                if (reader2.Read())
                {
                    date = (DateTime)reader2["date"];
                    ordertotal = Convert.ToInt32(reader2["ordertotal"]);
                }
            }

            db.closeConnection();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            getorderforprint();
            Font font = new Font("Courier New", 10);
            float lineHeight = font.GetHeight(e.Graphics);
            float x = 10;
            float y = 10;

            e.Graphics.DrawString("   My Restaurant Receipt", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString($"Order Number: {ordernumber}", font, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Date: {date}", font, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString($"  item\t\t\tqty\ttotal", font, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString("-----------------------------------", font, Brushes.Black, x, y);
            y += lineHeight;

            foreach (var (item, quantity, total) in printItems)
            {
                e.Graphics.DrawString($"{item} \t{quantity}\t{total}", font, Brushes.Black, x, y);
                y += lineHeight;
            }

            y += lineHeight;
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"Grand Total: {ordertotal} Rs", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString("Thank you for your order!", font, Brushes.Black, x, y);


        }
        private void SetupReceiptPage()
        {
            PaperSize receiptSize = new PaperSize("Receipt", 300, 1000);
            printDocument1.DefaultPageSettings.PaperSize = receiptSize;
            printDocument1.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
        }
        private void print_btn_Click(object sender, EventArgs e)
        {
            SetupReceiptPage();

            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = printDocument1;
                previewDialog.ShowDialog();
            }
        }

        private void orderdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ordernumber = Convert.ToInt32(orderdataGridView.CurrentRow.Cells[0].Value);
                if (order.deleteorder(ordernumber))
                {
                    MessageBox.Show("Order Deleted Successfully", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    orderdataGridView.DataSource = order.CreatedOrderList();
                    dash.increamnetordernumber();
                }
                else
                {
                    MessageBox.Show("Order Not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
