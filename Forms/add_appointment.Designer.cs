namespace hospital_management_system.Forms
{
    partial class add_appointment
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
            Label department_name;
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            patient_name_textbox = new TextBox();
            patient_surname_textbox = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            date_picker = new DateTimePicker();
            tableLayoutPanel7 = new TableLayoutPanel();
            reason_textbox = new TextBox();
            status_combobox = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            staff_name_textbox = new TextBox();
            staff_surname_textbox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            staff_name = new Label();
            staff_surname = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            reason = new Label();
            status = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label4 = new Label();
            save_button = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            patient_name = new Label();
            patient_surname = new Label();
            department_name_combobox = new ComboBox();
            department_name = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // department_name
            // 
            department_name.Anchor = AnchorStyles.Right;
            department_name.AutoSize = true;
            department_name.Location = new Point(336, 9);
            department_name.Name = "department_name";
            department_name.Size = new Size(133, 20);
            department_name.TabIndex = 10;
            department_name.Text = "Department Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel11, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel1.Controls.Add(save_button, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 0, 2);
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
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Controls.Add(patient_name_textbox, 0, 0);
            tableLayoutPanel11.Controls.Add(patient_surname_textbox, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(481, 167);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(473, 76);
            tableLayoutPanel11.TabIndex = 25;
            // 
            // patient_name_textbox
            // 
            patient_name_textbox.Anchor = AnchorStyles.Left;
            patient_name_textbox.Location = new Point(3, 5);
            patient_name_textbox.Name = "patient_name_textbox";
            patient_name_textbox.Size = new Size(125, 27);
            patient_name_textbox.TabIndex = 2;
            // 
            // patient_surname_textbox
            // 
            patient_surname_textbox.Anchor = AnchorStyles.Left;
            patient_surname_textbox.Location = new Point(3, 43);
            patient_surname_textbox.Name = "patient_surname_textbox";
            patient_surname_textbox.Size = new Size(125, 27);
            patient_surname_textbox.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(date_picker, 0, 1);
            tableLayoutPanel9.Controls.Add(department_name_combobox, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(481, 249);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(473, 76);
            tableLayoutPanel9.TabIndex = 23;
            // 
            // date_picker
            // 
            date_picker.Anchor = AnchorStyles.Left;
            date_picker.Location = new Point(3, 43);
            date_picker.MinDate = new DateTime(2024, 12, 20, 0, 0, 0, 0);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(250, 27);
            date_picker.TabIndex = 5;
            date_picker.Value = new DateTime(2024, 12, 23, 14, 19, 44, 0);
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(reason_textbox, 0, 0);
            tableLayoutPanel7.Controls.Add(status_combobox, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(481, 331);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(473, 76);
            tableLayoutPanel7.TabIndex = 21;
            // 
            // reason_textbox
            // 
            reason_textbox.Anchor = AnchorStyles.Left;
            reason_textbox.Location = new Point(3, 5);
            reason_textbox.Name = "reason_textbox";
            reason_textbox.Size = new Size(250, 27);
            reason_textbox.TabIndex = 6;
            // 
            // status_combobox
            // 
            status_combobox.Anchor = AnchorStyles.Left;
            status_combobox.FormattingEnabled = true;
            status_combobox.Items.AddRange(new object[] { "Planned" });
            status_combobox.Location = new Point(3, 43);
            status_combobox.Name = "status_combobox";
            status_combobox.Size = new Size(151, 28);
            status_combobox.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(staff_name_textbox, 0, 0);
            tableLayoutPanel5.Controls.Add(staff_surname_textbox, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(481, 85);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(473, 76);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // staff_name_textbox
            // 
            staff_name_textbox.Anchor = AnchorStyles.Left;
            staff_name_textbox.Location = new Point(3, 5);
            staff_name_textbox.Name = "staff_name_textbox";
            staff_name_textbox.Size = new Size(125, 27);
            staff_name_textbox.TabIndex = 2;
            // 
            // staff_surname_textbox
            // 
            staff_surname_textbox.Anchor = AnchorStyles.Left;
            staff_surname_textbox.Location = new Point(3, 43);
            staff_surname_textbox.Name = "staff_surname_textbox";
            staff_surname_textbox.Size = new Size(125, 27);
            staff_surname_textbox.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(staff_name, 0, 0);
            tableLayoutPanel4.Controls.Add(staff_surname, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 85);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(472, 76);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // staff_name
            // 
            staff_name.Anchor = AnchorStyles.Right;
            staff_name.AutoSize = true;
            staff_name.Location = new Point(370, 9);
            staff_name.Name = "staff_name";
            staff_name.Size = new Size(99, 20);
            staff_name.TabIndex = 10;
            staff_name.Text = "Doctor Name";
            // 
            // staff_surname
            // 
            staff_surname.Anchor = AnchorStyles.Right;
            staff_surname.AutoSize = true;
            staff_surname.Location = new Point(352, 47);
            staff_surname.Name = "staff_surname";
            staff_surname.Size = new Size(117, 20);
            staff_surname.TabIndex = 11;
            staff_surname.Text = "Doctor Surname";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(reason, 0, 0);
            tableLayoutPanel6.Controls.Add(status, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 331);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(472, 76);
            tableLayoutPanel6.TabIndex = 20;
            // 
            // reason
            // 
            reason.Anchor = AnchorStyles.Right;
            reason.AutoSize = true;
            reason.Location = new Point(412, 9);
            reason.Name = "reason";
            reason.Size = new Size(57, 20);
            reason.TabIndex = 12;
            reason.Text = "Reason";
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Right;
            status.AutoSize = true;
            status.Location = new Point(420, 47);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 13;
            status.Text = "Status";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(department_name, 0, 0);
            tableLayoutPanel8.Controls.Add(label4, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 249);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(472, 76);
            tableLayoutPanel8.TabIndex = 22;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(428, 47);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 11;
            label4.Text = "Date";
            // 
            // save_button
            // 
            save_button.Anchor = AnchorStyles.Left;
            save_button.Location = new Point(481, 436);
            save_button.Name = "save_button";
            save_button.Size = new Size(94, 29);
            save_button.TabIndex = 7;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(patient_name, 0, 0);
            tableLayoutPanel10.Controls.Add(patient_surname, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 167);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(472, 76);
            tableLayoutPanel10.TabIndex = 24;
            // 
            // patient_name
            // 
            patient_name.Anchor = AnchorStyles.Right;
            patient_name.AutoSize = true;
            patient_name.Location = new Point(371, 9);
            patient_name.Name = "patient_name";
            patient_name.Size = new Size(98, 20);
            patient_name.TabIndex = 10;
            patient_name.Text = "Patient Name";
            // 
            // patient_surname
            // 
            patient_surname.Anchor = AnchorStyles.Right;
            patient_surname.AutoSize = true;
            patient_surname.Location = new Point(353, 47);
            patient_surname.Name = "patient_surname";
            patient_surname.Size = new Size(116, 20);
            patient_surname.TabIndex = 11;
            patient_surname.Text = "Patient Surname";
            // 
            // department_name_combobox
            // 
            department_name_combobox.FormattingEnabled = true;
            department_name_combobox.Location = new Point(3, 3);
            department_name_combobox.Name = "department_name_combobox";
            department_name_combobox.Size = new Size(151, 28);
            department_name_combobox.TabIndex = 6;
            // 
            // add_appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(tableLayoutPanel1);
            Name = "add_appointment";
            Text = "appointment";
            Load += add_appointment_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label status;
        private Label label4;
        private Label department_name;
        private DateTimePicker date_picker;
        private ComboBox status_combobox;
        private Button save_button;
        private TextBox staff_surname_textbox;
        private TextBox staff_name_textbox;
        private Label staff_surname;
        private Label staff_name;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox patient_surname_textbox;
        private TextBox patient_name_textbox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label patient_surname;
        private Label patient_name;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox reason_textbox;
        private TableLayoutPanel tableLayoutPanel6;
        private Label reason;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel10;
        private ComboBox department_name_combobox;
    }
}