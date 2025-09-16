



namespace Database_Project.FORMS
{
    partial class login_form
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
            login_btn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            close_btn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Transparent;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 2;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(208, 431);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(175, 54);
            login_btn.TabIndex = 2;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            login_btn.MouseLeave += login_btn_MouseLeave;
            login_btn.MouseHover += login_btn_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 215);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 322);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(close_btn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 523);
            panel2.TabIndex = 7;
            // 
            // password
            // 
            password.BackColor = Color.WhiteSmoke;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Arial Rounded MT Bold", 12F);
            password.ForeColor = Color.Indigo;
            password.Location = new Point(21, 353);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(260, 28);
            password.TabIndex = 1;
            // 
            // username
            // 
            username.BackColor = Color.WhiteSmoke;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Arial Rounded MT Bold", 12F);
            username.ForeColor = Color.Indigo;
            username.Location = new Point(21, 246);
            username.Name = "username";
            username.Size = new Size(260, 28);
            username.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 10);
            label1.Name = "label1";
            label1.Size = new Size(551, 118);
            label1.TabIndex = 0;
            label1.Text = "Restraunt Management System ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Red;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = SystemColors.ButtonHighlight;
            close_btn.Location = new Point(583, 0);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(38, 38);
            close_btn.TabIndex = 4;
            close_btn.Text = "X";
            close_btn.TextAlign = ContentAlignment.TopCenter;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 521);
            Controls.Add(login_btn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login_form";
            Load += Login_Form_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button login_btn;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Button close_btn;
        private TextBox password;
        private TextBox username;
    }
}