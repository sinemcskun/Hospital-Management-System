namespace hospital_management_system.Forms
{
    partial class add_treatment
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
            tableLayoutPanel11 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel10 = new TableLayoutPanel();
            treatment_date = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            treatment_textbox = new TextBox();
            diagnosis_textbox = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            treatment = new Label();
            diagnosis = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            staff_name_textbox = new TextBox();
            staff_surname_textbox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            staff_name = new Label();
            staff_surname = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            patient_surname = new Label();
            patient_name = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            patient_name_textbox = new TextBox();
            patient_surname_textbox = new TextBox();
            Photo_upload_button = new Button();
            save_button = new Button();
            treatment_picture_box = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)treatment_picture_box).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel11, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel1.Controls.Add(Photo_upload_button, 0, 5);
            tableLayoutPanel1.Controls.Add(save_button, 0, 6);
            tableLayoutPanel1.Controls.Add(treatment_picture_box, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.333334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5555553F));
            tableLayoutPanel1.Size = new Size(957, 578);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(481, 331);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(473, 76);
            tableLayoutPanel11.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(treatment_date, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 331);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(472, 76);
            tableLayoutPanel10.TabIndex = 24;
            // 
            // treatment_date
            // 
            treatment_date.Anchor = AnchorStyles.Right;
            treatment_date.AutoSize = true;
            treatment_date.Location = new Point(357, 9);
            treatment_date.Name = "treatment_date";
            treatment_date.Size = new Size(112, 20);
            treatment_date.TabIndex = 11;
            treatment_date.Text = "Treatment Date";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(treatment_textbox, 0, 1);
            tableLayoutPanel9.Controls.Add(diagnosis_textbox, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(481, 249);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(473, 76);
            tableLayoutPanel9.TabIndex = 23;
            // 
            // treatment_textbox
            // 
            treatment_textbox.Anchor = AnchorStyles.Left;
            treatment_textbox.Location = new Point(3, 43);
            treatment_textbox.Name = "treatment_textbox";
            treatment_textbox.Size = new Size(125, 27);
            treatment_textbox.TabIndex = 4;
            // 
            // diagnosis_textbox
            // 
            diagnosis_textbox.Anchor = AnchorStyles.Left;
            diagnosis_textbox.Location = new Point(3, 5);
            diagnosis_textbox.Name = "diagnosis_textbox";
            diagnosis_textbox.Size = new Size(125, 27);
            diagnosis_textbox.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(treatment, 0, 1);
            tableLayoutPanel8.Controls.Add(diagnosis, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 249);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(472, 76);
            tableLayoutPanel8.TabIndex = 22;
            // 
            // treatment
            // 
            treatment.Anchor = AnchorStyles.Right;
            treatment.AutoSize = true;
            treatment.Location = new Point(393, 47);
            treatment.Name = "treatment";
            treatment.Size = new Size(76, 20);
            treatment.TabIndex = 12;
            treatment.Text = "Treatment";
            // 
            // diagnosis
            // 
            diagnosis.Anchor = AnchorStyles.Right;
            diagnosis.AutoSize = true;
            diagnosis.Location = new Point(395, 9);
            diagnosis.Name = "diagnosis";
            diagnosis.Size = new Size(74, 20);
            diagnosis.TabIndex = 11;
            diagnosis.Text = "Diagnosis";
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(481, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(473, 76);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(472, 76);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(patient_surname, 0, 1);
            tableLayoutPanel6.Controls.Add(patient_name, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 167);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(472, 76);
            tableLayoutPanel6.TabIndex = 20;
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
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(patient_name_textbox, 0, 0);
            tableLayoutPanel7.Controls.Add(patient_surname_textbox, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(481, 167);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(473, 76);
            tableLayoutPanel7.TabIndex = 21;
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
            // Photo_upload_button
            // 
            Photo_upload_button.Anchor = AnchorStyles.Right;
            Photo_upload_button.Location = new Point(323, 445);
            Photo_upload_button.Name = "Photo_upload_button";
            Photo_upload_button.Size = new Size(152, 29);
            Photo_upload_button.TabIndex = 20;
            Photo_upload_button.Text = "Photo Upload";
            Photo_upload_button.UseVisualStyleBackColor = true;
            Photo_upload_button.Click += Photo_upload_button_Click;
            // 
            // save_button
            // 
            save_button.Anchor = AnchorStyles.Right;
            save_button.Location = new Point(323, 529);
            save_button.Name = "save_button";
            save_button.Size = new Size(152, 29);
            save_button.TabIndex = 21;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // treatment_picture_box
            // 
            treatment_picture_box.Dock = DockStyle.Left;
            treatment_picture_box.Location = new Point(481, 413);
            treatment_picture_box.Name = "treatment_picture_box";
            treatment_picture_box.Size = new Size(125, 93);
            treatment_picture_box.SizeMode = PictureBoxSizeMode.Zoom;
            treatment_picture_box.TabIndex = 26;
            treatment_picture_box.TabStop = false;
            // 
            // add_treatment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(tableLayoutPanel1);
            Name = "add_treatment";
            Text = "add_treatment";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)treatment_picture_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel10;
        private Label treatment_date;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox treatment_textbox;
        private TextBox diagnosis_textbox;
        private TableLayoutPanel tableLayoutPanel8;
        private Label treatment;
        private Label diagnosis;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox staff_name_textbox;
        private TextBox staff_surname_textbox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label staff_name;
        private Label staff_surname;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label patient_surname;
        private Label patient_name;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox patient_name_textbox;
        private TextBox patient_surname_textbox;
        private Button save_button;
        private Button Photo_upload_button;
        private DateTimePicker dateTimePicker1;
        private PictureBox treatment_picture_box;
    }
}