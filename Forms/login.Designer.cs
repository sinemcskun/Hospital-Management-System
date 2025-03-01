namespace hospital_management_system
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            user_name = new Label();
            user_name_textbox = new TextBox();
            user_password_textbox = new TextBox();
            user_password = new Label();
            login_button = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(957, 578);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.pathfinders_medical_center;
            pictureBox1.Location = new Point(321, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(user_name, 0, 0);
            tableLayoutPanel2.Controls.Add(user_name_textbox, 0, 1);
            tableLayoutPanel2.Controls.Add(user_password_textbox, 0, 3);
            tableLayoutPanel2.Controls.Add(user_password, 0, 2);
            tableLayoutPanel2.Controls.Add(login_button, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(321, 292);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.29926968F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5985394F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.29926968F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5985394F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0583935F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.1459846F));
            tableLayoutPanel2.Size = new Size(312, 283);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.Dock = DockStyle.Top;
            user_name.Location = new Point(3, 0);
            user_name.Name = "user_name";
            user_name.Size = new Size(306, 20);
            user_name.TabIndex = 0;
            user_name.Text = "Username";
            user_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // user_name_textbox
            // 
            user_name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_name_textbox.Location = new Point(3, 23);
            user_name_textbox.Name = "user_name_textbox";
            user_name_textbox.Size = new Size(306, 27);
            user_name_textbox.TabIndex = 1;
            // 
            // user_password_textbox
            // 
            user_password_textbox.Dock = DockStyle.Fill;
            user_password_textbox.Location = new Point(3, 84);
            user_password_textbox.Name = "user_password_textbox";
            user_password_textbox.PasswordChar = '*';
            user_password_textbox.Size = new Size(306, 27);
            user_password_textbox.TabIndex = 2;
            // 
            // user_password
            // 
            user_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_password.AutoSize = true;
            user_password.Location = new Point(3, 61);
            user_password.Name = "user_password";
            user_password.Size = new Size(306, 20);
            user_password.TabIndex = 3;
            user_password.Text = "Password";
            user_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_button.Location = new Point(3, 125);
            login_button.Name = "login_button";
            login_button.Size = new Size(306, 39);
            login_button.TabIndex = 4;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(tableLayoutPanel1);
            Name = "login";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label user_name;
        private TextBox user_name_textbox;
        private TextBox user_password_textbox;
        private Label user_password;
        private Button login_button;
    }
}
