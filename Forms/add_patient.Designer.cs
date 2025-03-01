namespace hospital_management_system.Forms
{
    partial class add_patient
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            textBox2 = new TextBox();
            e_mail_textbox = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            phone_number = new Label();
            e_mail = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            age_textbox = new TextBox();
            ssn_textbox = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            age = new Label();
            ssn = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            name_textbox = new TextBox();
            surname_textbox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            name = new Label();
            surname = new Label();
            address_textbox = new TextBox();
            address = new Label();
            upload_photo_button = new Button();
            save_button = new Button();
            patient_picture_box = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patient_picture_box).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(address_textbox, 1, 4);
            tableLayoutPanel1.Controls.Add(address, 0, 4);
            tableLayoutPanel1.Controls.Add(upload_photo_button, 0, 5);
            tableLayoutPanel1.Controls.Add(save_button, 0, 6);
            tableLayoutPanel1.Controls.Add(patient_picture_box, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(957, 578);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel10.Controls.Add(e_mail_textbox, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(481, 249);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(473, 76);
            tableLayoutPanel10.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(3, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // e_mail_textbox
            // 
            e_mail_textbox.Anchor = AnchorStyles.Left;
            e_mail_textbox.Location = new Point(3, 43);
            e_mail_textbox.Name = "e_mail_textbox";
            e_mail_textbox.Size = new Size(125, 27);
            e_mail_textbox.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(phone_number, 0, 0);
            tableLayoutPanel9.Controls.Add(e_mail, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 249);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(472, 76);
            tableLayoutPanel9.TabIndex = 25;
            // 
            // phone_number
            // 
            phone_number.Anchor = AnchorStyles.Right;
            phone_number.AutoSize = true;
            phone_number.Location = new Point(361, 9);
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(108, 20);
            phone_number.TabIndex = 10;
            phone_number.Text = "Phone Number";
            // 
            // e_mail
            // 
            e_mail.Anchor = AnchorStyles.Right;
            e_mail.AutoSize = true;
            e_mail.Location = new Point(417, 47);
            e_mail.Name = "e_mail";
            e_mail.Size = new Size(52, 20);
            e_mail.TabIndex = 11;
            e_mail.Text = "E-mail";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(age_textbox, 0, 0);
            tableLayoutPanel7.Controls.Add(ssn_textbox, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(481, 167);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(473, 76);
            tableLayoutPanel7.TabIndex = 21;
            // 
            // age_textbox
            // 
            age_textbox.Anchor = AnchorStyles.Left;
            age_textbox.Location = new Point(3, 5);
            age_textbox.Name = "age_textbox";
            age_textbox.Size = new Size(125, 27);
            age_textbox.TabIndex = 2;
            // 
            // ssn_textbox
            // 
            ssn_textbox.Anchor = AnchorStyles.Left;
            ssn_textbox.Location = new Point(3, 43);
            ssn_textbox.Name = "ssn_textbox";
            ssn_textbox.Size = new Size(125, 27);
            ssn_textbox.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(age, 0, 0);
            tableLayoutPanel6.Controls.Add(ssn, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 167);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(472, 76);
            tableLayoutPanel6.TabIndex = 20;
            // 
            // age
            // 
            age.Anchor = AnchorStyles.Right;
            age.AutoSize = true;
            age.Location = new Point(433, 9);
            age.Name = "age";
            age.Size = new Size(36, 20);
            age.TabIndex = 10;
            age.Text = "Age";
            // 
            // ssn
            // 
            ssn.Anchor = AnchorStyles.Right;
            ssn.AutoSize = true;
            ssn.Location = new Point(433, 47);
            ssn.Name = "ssn";
            ssn.Size = new Size(36, 20);
            ssn.TabIndex = 11;
            ssn.Text = "SSN";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(name_textbox, 0, 0);
            tableLayoutPanel5.Controls.Add(surname_textbox, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(481, 85);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(473, 76);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // name_textbox
            // 
            name_textbox.Anchor = AnchorStyles.Left;
            name_textbox.Location = new Point(3, 5);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(125, 27);
            name_textbox.TabIndex = 2;
            // 
            // surname_textbox
            // 
            surname_textbox.Anchor = AnchorStyles.Left;
            surname_textbox.Location = new Point(3, 43);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(125, 27);
            surname_textbox.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(name, 0, 0);
            tableLayoutPanel4.Controls.Add(surname, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 85);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(472, 76);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Right;
            name.AutoSize = true;
            name.Location = new Point(420, 9);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 10;
            name.Text = "Name";
            // 
            // surname
            // 
            surname.Anchor = AnchorStyles.Right;
            surname.AutoSize = true;
            surname.Location = new Point(402, 47);
            surname.Name = "surname";
            surname.Size = new Size(67, 20);
            surname.TabIndex = 11;
            surname.Text = "Surname";
            // 
            // address_textbox
            // 
            address_textbox.Anchor = AnchorStyles.Left;
            address_textbox.Location = new Point(481, 355);
            address_textbox.Name = "address_textbox";
            address_textbox.Size = new Size(125, 27);
            address_textbox.TabIndex = 22;
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Right;
            address.AutoSize = true;
            address.Location = new Point(413, 359);
            address.Name = "address";
            address.Size = new Size(62, 20);
            address.TabIndex = 11;
            address.Text = "Address";
            // 
            // upload_photo_button
            // 
            upload_photo_button.Anchor = AnchorStyles.Right;
            upload_photo_button.Location = new Point(346, 436);
            upload_photo_button.Name = "upload_photo_button";
            upload_photo_button.Size = new Size(129, 29);
            upload_photo_button.TabIndex = 27;
            upload_photo_button.Text = "Upload Photo";
            upload_photo_button.UseVisualStyleBackColor = true;
            upload_photo_button.Click += upload_photo_button_Click;
            // 
            // save_button
            // 
            save_button.Anchor = AnchorStyles.Right;
            save_button.Location = new Point(383, 520);
            save_button.Name = "save_button";
            save_button.Size = new Size(92, 29);
            save_button.TabIndex = 7;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // patient_picture_box
            // 
            patient_picture_box.Dock = DockStyle.Left;
            patient_picture_box.Location = new Point(481, 413);
            patient_picture_box.Name = "patient_picture_box";
            patient_picture_box.Size = new Size(125, 76);
            patient_picture_box.SizeMode = PictureBoxSizeMode.Zoom;
            patient_picture_box.TabIndex = 28;
            patient_picture_box.TabStop = false;
            // 
            // add_patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(tableLayoutPanel1);
            Name = "add_patient";
            Text = "add_patient";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patient_picture_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox e_mail_textbox;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private Label e_mail;
        private Label phone_number;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox ssn_textbox;
        private TextBox age_textbox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label ssn;
        private Label age;
        private TextBox surname_textbox;
        private TextBox name_textbox;
        private Label surname;
        private Label name;
        private Label address;
        private Button save_button;
        private TextBox address_textbox;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel9;
        private Button upload_photo_button;
        private PictureBox patient_picture_box;
    }
}