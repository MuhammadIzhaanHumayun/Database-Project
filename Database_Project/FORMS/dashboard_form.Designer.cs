namespace Database_Project.FORMS
{
    partial class dashboard_form
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            button1 = new Button();
            buttonpanel = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            items_btn = new Button();
            user_btn = new Button();
            logout_btn = new Button();
            user_panel = new Panel();
            label10 = new Label();
            label4 = new Label();
            id = new TextBox();
            delete_btn = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            name = new TextBox();
            userdataGridView = new DataGridView();
            pos_panel = new Panel();
            button4 = new Button();
            label16 = new Label();
            label_total = new Label();
            button_createorder = new Button();
            label15 = new Label();
            comboBox_items = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            date_label = new Label();
            textBox_ordernumber = new TextBox();
            button3 = new Button();
            addtoorder_btn = new Button();
            textBox_quantity = new TextBox();
            label12 = new Label();
            label11 = new Label();
            orderdataGridView = new DataGridView();
            menudataGridView = new DataGridView();
            Items_panel = new Panel();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            textBox_category = new TextBox();
            textBox_name = new TextBox();
            textBox_price = new TextBox();
            textBox_id = new TextBox();
            itemsdataGridView1 = new DataGridView();
            buttonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            user_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userdataGridView).BeginInit();
            pos_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menudataGridView).BeginInit();
            Items_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lato Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(994, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 39);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonpanel
            // 
            buttonpanel.BackColor = SystemColors.ActiveCaption;
            buttonpanel.Controls.Add(pictureBox1);
            buttonpanel.Controls.Add(panel2);
            buttonpanel.Controls.Add(items_btn);
            buttonpanel.Controls.Add(user_btn);
            buttonpanel.Controls.Add(logout_btn);
            buttonpanel.Location = new Point(0, 0);
            buttonpanel.Name = "buttonpanel";
            buttonpanel.Size = new Size(221, 775);
            buttonpanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Project_logo;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(219, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 775);
            panel2.TabIndex = 2;
            // 
            // items_btn
            // 
            items_btn.BackColor = Color.LightGray;
            items_btn.Cursor = Cursors.Hand;
            items_btn.FlatAppearance.BorderSize = 0;
            items_btn.FlatStyle = FlatStyle.Flat;
            items_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            items_btn.ForeColor = Color.Purple;
            items_btn.Location = new Point(3, 414);
            items_btn.Name = "items_btn";
            items_btn.Size = new Size(218, 54);
            items_btn.TabIndex = 4;
            items_btn.Text = "Items";
            items_btn.UseVisualStyleBackColor = false;
            items_btn.Click += items_btn_Click;
            // 
            // user_btn
            // 
            user_btn.BackColor = Color.LightGray;
            user_btn.Cursor = Cursors.Hand;
            user_btn.FlatAppearance.BorderSize = 0;
            user_btn.FlatStyle = FlatStyle.Flat;
            user_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_btn.ForeColor = Color.Purple;
            user_btn.Location = new Point(0, 307);
            user_btn.Name = "user_btn";
            user_btn.Size = new Size(221, 54);
            user_btn.TabIndex = 3;
            user_btn.Text = "Users";
            user_btn.UseVisualStyleBackColor = false;
            user_btn.Click += user_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Transparent;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.Purple;
            logout_btn.Location = new Point(0, 675);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(221, 56);
            logout_btn.TabIndex = 0;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // user_panel
            // 
            user_panel.BackColor = Color.Transparent;
            user_panel.Controls.Add(label10);
            user_panel.Controls.Add(label4);
            user_panel.Controls.Add(button1);
            user_panel.Controls.Add(id);
            user_panel.Controls.Add(delete_btn);
            user_panel.Controls.Add(edit_btn);
            user_panel.Controls.Add(add_btn);
            user_panel.Controls.Add(label3);
            user_panel.Controls.Add(label2);
            user_panel.Controls.Add(password);
            user_panel.Controls.Add(name);
            user_panel.Controls.Add(userdataGridView);
            user_panel.Location = new Point(222, 0);
            user_panel.Name = "user_panel";
            user_panel.Size = new Size(1033, 775);
            user_panel.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Purple;
            label10.Location = new Point(459, 26);
            label10.Name = "label10";
            label10.Size = new Size(117, 45);
            label10.TabIndex = 10;
            label10.Text = "USERS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(33, 140);
            label4.Name = "label4";
            label4.Size = new Size(35, 30);
            label4.TabIndex = 9;
            label4.Text = "ID";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(104, 141);
            id.Name = "id";
            id.Size = new Size(186, 31);
            id.TabIndex = 8;
            // 
            // delete_btn
            // 
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatAppearance.BorderSize = 2;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 11F);
            delete_btn.ForeColor = Color.Purple;
            delete_btn.Location = new Point(104, 661);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(115, 52);
            delete_btn.TabIndex = 7;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Cursor = Cursors.Hand;
            edit_btn.FlatAppearance.BorderSize = 2;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Font = new Font("Segoe UI", 11F);
            edit_btn.ForeColor = Color.Purple;
            edit_btn.Location = new Point(104, 573);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(115, 52);
            edit_btn.TabIndex = 6;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatAppearance.BorderSize = 2;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 11F);
            add_btn.ForeColor = Color.Purple;
            add_btn.Location = new Point(104, 481);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(112, 52);
            add_btn.TabIndex = 5;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(31, 311);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(33, 204);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // password
            // 
            password.Location = new Point(37, 344);
            password.Name = "password";
            password.Size = new Size(253, 31);
            password.TabIndex = 2;
            // 
            // name
            // 
            name.Location = new Point(37, 237);
            name.Name = "name";
            name.Size = new Size(253, 31);
            name.TabIndex = 1;
            // 
            // userdataGridView
            // 
            userdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userdataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            userdataGridView.EnableHeadersVisualStyles = false;
            userdataGridView.Location = new Point(324, 99);
            userdataGridView.Name = "userdataGridView";
            userdataGridView.RowHeadersWidth = 62;
            userdataGridView.Size = new Size(665, 329);
            userdataGridView.TabIndex = 0;
            userdataGridView.CellClick += userdataGridView_CellClick;
            // 
            // pos_panel
            // 
            pos_panel.BackColor = Color.Transparent;
            pos_panel.Controls.Add(button4);
            pos_panel.Controls.Add(label16);
            pos_panel.Controls.Add(label_total);
            pos_panel.Controls.Add(button_createorder);
            pos_panel.Controls.Add(label15);
            pos_panel.Controls.Add(comboBox_items);
            pos_panel.Controls.Add(label14);
            pos_panel.Controls.Add(label13);
            pos_panel.Controls.Add(date_label);
            pos_panel.Controls.Add(textBox_ordernumber);
            pos_panel.Controls.Add(button3);
            pos_panel.Controls.Add(addtoorder_btn);
            pos_panel.Controls.Add(textBox_quantity);
            pos_panel.Controls.Add(label12);
            pos_panel.Controls.Add(label11);
            pos_panel.Controls.Add(orderdataGridView);
            pos_panel.Controls.Add(menudataGridView);
            pos_panel.Location = new Point(222, 0);
            pos_panel.Name = "pos_panel";
            pos_panel.Size = new Size(1033, 775);
            pos_panel.TabIndex = 11;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(475, 715);
            button4.Name = "button4";
            button4.Size = new Size(151, 47);
            button4.TabIndex = 16;
            button4.Text = "View Orders";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Purple;
            label16.Location = new Point(670, 723);
            label16.Name = "label16";
            label16.Size = new Size(70, 30);
            label16.TabIndex = 15;
            label16.Text = "Total:";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total.ForeColor = Color.Purple;
            label_total.Location = new Point(742, 723);
            label_total.Name = "label_total";
            label_total.Size = new Size(26, 30);
            label_total.TabIndex = 14;
            label_total.Text = "0";
            // 
            // button_createorder
            // 
            button_createorder.Cursor = Cursors.Hand;
            button_createorder.FlatAppearance.BorderSize = 2;
            button_createorder.FlatStyle = FlatStyle.Flat;
            button_createorder.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_createorder.ForeColor = Color.Purple;
            button_createorder.Location = new Point(845, 715);
            button_createorder.Name = "button_createorder";
            button_createorder.Size = new Size(151, 47);
            button_createorder.TabIndex = 13;
            button_createorder.Text = "Create Order";
            button_createorder.UseVisualStyleBackColor = true;
            button_createorder.Click += button_createorder_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Purple;
            label15.Location = new Point(324, 69);
            label15.Name = "label15";
            label15.Size = new Size(84, 25);
            label15.TabIndex = 12;
            label15.Text = "Category";
            // 
            // comboBox_items
            // 
            comboBox_items.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_items.FormattingEnabled = true;
            comboBox_items.Location = new Point(421, 69);
            comboBox_items.Name = "comboBox_items";
            comboBox_items.Size = new Size(182, 29);
            comboBox_items.TabIndex = 11;
            comboBox_items.SelectedIndexChanged += comboBox_items_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Purple;
            label14.Location = new Point(52, 198);
            label14.Name = "label14";
            label14.Size = new Size(176, 30);
            label14.TabIndex = 10;
            label14.Text = "ORDER NUMBER";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Purple;
            label13.Location = new Point(37, 110);
            label13.Name = "label13";
            label13.Size = new Size(67, 30);
            label13.TabIndex = 9;
            label13.Text = "DATE:";
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_label.ForeColor = Color.Purple;
            date_label.Location = new Point(116, 110);
            date_label.Name = "date_label";
            date_label.Size = new Size(103, 30);
            date_label.TabIndex = 8;
            date_label.Text = "20-03-25";
            // 
            // textBox_ordernumber
            // 
            textBox_ordernumber.Enabled = false;
            textBox_ordernumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ordernumber.Location = new Point(33, 231);
            textBox_ordernumber.Name = "textBox_ordernumber";
            textBox_ordernumber.Size = new Size(212, 37);
            textBox_ordernumber.TabIndex = 7;
            textBox_ordernumber.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Lato Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(994, 0);
            button3.Name = "button3";
            button3.Size = new Size(39, 39);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // addtoorder_btn
            // 
            addtoorder_btn.Cursor = Cursors.Hand;
            addtoorder_btn.FlatAppearance.BorderSize = 2;
            addtoorder_btn.FlatStyle = FlatStyle.Flat;
            addtoorder_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addtoorder_btn.ForeColor = Color.Purple;
            addtoorder_btn.Location = new Point(754, 394);
            addtoorder_btn.Name = "addtoorder_btn";
            addtoorder_btn.Size = new Size(159, 54);
            addtoorder_btn.TabIndex = 5;
            addtoorder_btn.Text = "Add To Order";
            addtoorder_btn.UseVisualStyleBackColor = true;
            addtoorder_btn.Click += addtoorder_btn_Click;
            // 
            // textBox_quantity
            // 
            textBox_quantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_quantity.Location = new Point(558, 403);
            textBox_quantity.Name = "textBox_quantity";
            textBox_quantity.PlaceholderText = "Quanitity";
            textBox_quantity.Size = new Size(150, 37);
            textBox_quantity.TabIndex = 4;
            textBox_quantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Purple;
            label12.Location = new Point(457, 460);
            label12.Name = "label12";
            label12.Size = new Size(91, 32);
            label12.TabIndex = 3;
            label12.Text = "ORDER";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Purple;
            label11.Location = new Point(587, 30);
            label11.Name = "label11";
            label11.Size = new Size(83, 32);
            label11.TabIndex = 2;
            label11.Text = "MENU";
            // 
            // orderdataGridView
            // 
            orderdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Purple;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            orderdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            orderdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            orderdataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            orderdataGridView.EnableHeadersVisualStyles = false;
            orderdataGridView.Location = new Point(31, 495);
            orderdataGridView.Name = "orderdataGridView";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            orderdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            orderdataGridView.RowHeadersWidth = 62;
            orderdataGridView.Size = new Size(965, 205);
            orderdataGridView.TabIndex = 1;
            orderdataGridView.CellDoubleClick += orderdataGridView_CellDoubleClick;
            // 
            // menudataGridView
            // 
            menudataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menudataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Purple;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            menudataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            menudataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menudataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            menudataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            menudataGridView.EnableHeadersVisualStyles = false;
            menudataGridView.Location = new Point(296, 99);
            menudataGridView.Name = "menudataGridView";
            menudataGridView.RowHeadersWidth = 62;
            menudataGridView.Size = new Size(700, 276);
            menudataGridView.TabIndex = 0;
            menudataGridView.CellClick += menudataGridView_CellClick;
            // 
            // Items_panel
            // 
            Items_panel.BackColor = Color.Transparent;
            Items_panel.Controls.Add(button2);
            Items_panel.Controls.Add(label9);
            Items_panel.Controls.Add(label8);
            Items_panel.Controls.Add(label7);
            Items_panel.Controls.Add(label6);
            Items_panel.Controls.Add(label5);
            Items_panel.Controls.Add(btn_edit);
            Items_panel.Controls.Add(btn_delete);
            Items_panel.Controls.Add(btn_add);
            Items_panel.Controls.Add(textBox_category);
            Items_panel.Controls.Add(textBox_name);
            Items_panel.Controls.Add(textBox_price);
            Items_panel.Controls.Add(textBox_id);
            Items_panel.Controls.Add(itemsdataGridView1);
            Items_panel.Dock = DockStyle.Right;
            Items_panel.Location = new Point(219, 0);
            Items_panel.Name = "Items_panel";
            Items_panel.Size = new Size(1036, 774);
            Items_panel.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lato Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(997, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 39);
            button2.TabIndex = 15;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Purple;
            label9.Location = new Point(460, 26);
            label9.Name = "label9";
            label9.Size = new Size(115, 45);
            label9.TabIndex = 14;
            label9.Text = "ITEMS\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.ForeColor = Color.Purple;
            label8.Location = new Point(588, 476);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 13;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(123, 595);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 12;
            label7.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(561, 589);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 11;
            label6.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(185, 476);
            label5.Name = "label5";
            label5.Size = new Size(32, 28);
            label5.TabIndex = 10;
            label5.Text = "ID";
            // 
            // btn_edit
            // 
            btn_edit.Cursor = Cursors.Hand;
            btn_edit.FlatAppearance.BorderSize = 2;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_edit.ForeColor = Color.Purple;
            btn_edit.Location = new Point(478, 685);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(128, 49);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderSize = 2;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_delete.ForeColor = Color.Purple;
            btn_delete.Location = new Point(695, 685);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(128, 49);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Transparent;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderSize = 2;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_add.ForeColor = Color.Purple;
            btn_add.Location = new Point(246, 685);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(128, 49);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // textBox_category
            // 
            textBox_category.Location = new Point(246, 589);
            textBox_category.Name = "textBox_category";
            textBox_category.Size = new Size(150, 31);
            textBox_category.TabIndex = 6;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(673, 476);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(150, 31);
            textBox_name.TabIndex = 5;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(673, 589);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(150, 31);
            textBox_price.TabIndex = 4;
            // 
            // textBox_id
            // 
            textBox_id.Enabled = false;
            textBox_id.Location = new Point(246, 476);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(150, 31);
            textBox_id.TabIndex = 1;
            // 
            // itemsdataGridView1
            // 
            itemsdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemsdataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Purple;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            itemsdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            itemsdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsdataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            itemsdataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            itemsdataGridView1.EnableHeadersVisualStyles = false;
            itemsdataGridView1.Location = new Point(36, 90);
            itemsdataGridView1.Name = "itemsdataGridView1";
            itemsdataGridView1.RowHeadersWidth = 62;
            itemsdataGridView1.Size = new Size(963, 348);
            itemsdataGridView1.TabIndex = 0;
            itemsdataGridView1.CellClick += itemsdataGridView1_CellClick;
            // 
            // dashboard_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 774);
            Controls.Add(buttonpanel);
            Controls.Add(Items_panel);
            Controls.Add(pos_panel);
            Controls.Add(user_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard_form";
            Load += dashboard_form_Load;
            buttonpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            user_panel.ResumeLayout(false);
            user_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userdataGridView).EndInit();
            pos_panel.ResumeLayout(false);
            pos_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)menudataGridView).EndInit();
            Items_panel.ResumeLayout(false);
            Items_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemsdataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel buttonpanel;
        private Button logout_btn;
        private Button items_btn;
        private Button user_btn;
        private Panel panel2;
        private Panel user_panel;
        private Label label3;
        private Label label2;
        private TextBox password;
        private TextBox name;
        private DataGridView userdataGridView;
        private Button delete_btn;
        private Button edit_btn;
        private Button add_btn;
        private Label label4;
        private TextBox id;
        private Panel Items_panel;
        private DataGridView itemsdataGridView1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_add;
        private TextBox textBox_category;
        private TextBox textBox_name;
        private TextBox textBox_price;
        private TextBox textBox_id;
        private Label label10;
        private Button button2;
        private Panel pos_panel;
        private DataGridView orderdataGridView;
        private DataGridView menudataGridView;
        private Label label12;
        private Label label11;
        private TextBox textBox_quantity;
        private Button addtoorder_btn;
        private Button button3;
        private Label date_label;
        private TextBox textBox_ordernumber;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox comboBox_items;
        private Label label_total;
        private Button button_createorder;
        private Label label16;
        private Button button4;
        private PictureBox pictureBox1;
    }
}