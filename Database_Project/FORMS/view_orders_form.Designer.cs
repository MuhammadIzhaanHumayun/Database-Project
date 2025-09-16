namespace Database_Project.FORMS
{
    partial class view_orders_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_orders_form));
            Close_btn = new Button();
            orderdataGridView = new DataGridView();
            label1 = new Label();
            print_btn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)orderdataGridView).BeginInit();
            SuspendLayout();
            // 
            // Close_btn
            // 
            Close_btn.BackColor = Color.Red;
            Close_btn.Cursor = Cursors.Hand;
            Close_btn.FlatStyle = FlatStyle.Flat;
            Close_btn.Font = new Font("Lato Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_btn.ForeColor = SystemColors.ButtonHighlight;
            Close_btn.Location = new Point(597, 0);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(39, 39);
            Close_btn.TabIndex = 7;
            Close_btn.Text = "X";
            Close_btn.UseVisualStyleBackColor = false;
            Close_btn.Click += Close_btn_Click;
            // 
            // orderdataGridView
            // 
            orderdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            orderdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderdataGridView.ColumnHeadersHeight = 34;
            orderdataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            orderdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            orderdataGridView.EnableHeadersVisualStyles = false;
            orderdataGridView.Location = new Point(33, 60);
            orderdataGridView.Name = "orderdataGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            orderdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            orderdataGridView.RowHeadersWidth = 62;
            orderdataGridView.ShowRowErrors = false;
            orderdataGridView.Size = new Size(564, 314);
            orderdataGridView.TabIndex = 8;
            orderdataGridView.CellClick += orderdataGridView_CellClick;
            orderdataGridView.CellDoubleClick += orderdataGridView_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(253, 11);
            label1.Name = "label1";
            label1.Size = new Size(126, 38);
            label1.TabIndex = 9;
            label1.Text = "ORDERS";
            // 
            // print_btn
            // 
            print_btn.Cursor = Cursors.Hand;
            print_btn.FlatAppearance.BorderSize = 2;
            print_btn.FlatStyle = FlatStyle.Flat;
            print_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            print_btn.ForeColor = Color.Purple;
            print_btn.Location = new Point(243, 396);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(150, 55);
            print_btn.TabIndex = 10;
            print_btn.Text = "Print Receipt";
            print_btn.UseVisualStyleBackColor = true;
            print_btn.Click += print_btn_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // view_orders_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(636, 463);
            Controls.Add(print_btn);
            Controls.Add(label1);
            Controls.Add(orderdataGridView);
            Controls.Add(Close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "view_orders_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "view_orders_form";
            Load += view_orders_form_Load;
            ((System.ComponentModel.ISupportInitialize)orderdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close_btn;
        private DataGridView orderdataGridView;
        private Label label1;
        private Button print_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}