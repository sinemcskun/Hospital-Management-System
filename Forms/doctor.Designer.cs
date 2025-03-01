namespace hospital_management_system.Forms
{
    partial class doctor
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
            tableLayoutPanel2 = new TableLayoutPanel();
            doctor_name = new Label();
            doctor_name_textbox = new TextBox();
            doctor_name_button = new Button();
            doctor_datagridview = new DataGridView();
            show_all_button = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctor_datagridview).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(doctor_datagridview, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.Size = new Size(957, 578);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(doctor_name, 0, 0);
            tableLayoutPanel2.Controls.Add(doctor_name_textbox, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(951, 90);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // doctor_name
            // 
            doctor_name.Anchor = AnchorStyles.Right;
            doctor_name.AutoSize = true;
            doctor_name.Location = new Point(200, 12);
            doctor_name.Name = "doctor_name";
            doctor_name.Size = new Size(113, 20);
            doctor_name.TabIndex = 0;
            doctor_name.Text = "Name/Surname";
            // 
            // doctor_name_textbox
            // 
            doctor_name_textbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctor_name_textbox.Location = new Point(319, 9);
            doctor_name_textbox.Name = "doctor_name_textbox";
            doctor_name_textbox.Size = new Size(310, 27);
            doctor_name_textbox.TabIndex = 1;
            // 
            // doctor_name_button
            // 
            doctor_name_button.Anchor = AnchorStyles.Left;
            doctor_name_button.Location = new Point(3, 5);
            doctor_name_button.Name = "doctor_name_button";
            doctor_name_button.Size = new Size(94, 28);
            doctor_name_button.TabIndex = 2;
            doctor_name_button.Text = "Search";
            doctor_name_button.UseVisualStyleBackColor = true;
            doctor_name_button.Click += doctor_name_button_Click;
            // 
            // doctor_datagridview
            // 
            doctor_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctor_datagridview.Dock = DockStyle.Fill;
            doctor_datagridview.Location = new Point(3, 99);
            doctor_datagridview.Name = "doctor_datagridview";
            doctor_datagridview.RowHeadersWidth = 51;
            doctor_datagridview.Size = new Size(951, 476);
            doctor_datagridview.TabIndex = 1;
            // 
            // show_all_button
            // 
            show_all_button.Anchor = AnchorStyles.Left;
            show_all_button.Location = new Point(159, 5);
            show_all_button.Name = "show_all_button";
            show_all_button.Size = new Size(94, 28);
            show_all_button.TabIndex = 3;
            show_all_button.Text = "Show All";
            show_all_button.UseVisualStyleBackColor = true;
            show_all_button.Click += show_all_button_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(doctor_name_button, 0, 0);
            tableLayoutPanel3.Controls.Add(show_all_button, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(635, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(313, 39);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(tableLayoutPanel1);
            Name = "doctor";
            Text = "doctor";
            Load += doctor_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctor_datagridview).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label doctor_name;
        private TextBox doctor_name_textbox;
        private Button doctor_name_button;
        private DataGridView doctor_datagridview;
        private TableLayoutPanel tableLayoutPanel3;
        private Button show_all_button;
    }
}