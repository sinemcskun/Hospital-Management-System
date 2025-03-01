namespace hospital_management_system.Forms
{
    partial class room_information
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
            tableLayoutPanel3 = new TableLayoutPanel();
            show_all_button = new Button();
            room_number_button = new Button();
            doctor_name = new Label();
            room_number_textbox = new TextBox();
            room_datagridview = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)room_datagridview).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(room_datagridview, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.Size = new Size(957, 578);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel2.Controls.Add(doctor_name, 0, 0);
            tableLayoutPanel2.Controls.Add(room_number_textbox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(951, 90);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(show_all_button, 1, 0);
            tableLayoutPanel3.Controls.Add(room_number_button, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(635, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(313, 39);
            tableLayoutPanel3.TabIndex = 4;
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
            show_all_button.Click += show_all_button_Click_1;
            // 
            // room_number_button
            // 
            room_number_button.Anchor = AnchorStyles.Left;
            room_number_button.Location = new Point(3, 5);
            room_number_button.Name = "room_number_button";
            room_number_button.Size = new Size(94, 28);
            room_number_button.TabIndex = 2;
            room_number_button.Text = "Search";
            room_number_button.UseVisualStyleBackColor = true;
            room_number_button.Click += room_number_button_Click;
            // 
            // doctor_name
            // 
            doctor_name.Anchor = AnchorStyles.Right;
            doctor_name.AutoSize = true;
            doctor_name.Location = new Point(206, 12);
            doctor_name.Name = "doctor_name";
            doctor_name.Size = new Size(107, 20);
            doctor_name.TabIndex = 0;
            doctor_name.Text = "Room Number";
            // 
            // room_number_textbox
            // 
            room_number_textbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            room_number_textbox.Location = new Point(319, 9);
            room_number_textbox.Name = "room_number_textbox";
            room_number_textbox.Size = new Size(310, 27);
            room_number_textbox.TabIndex = 1;
            // 
            // room_datagridview
            // 
            room_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            room_datagridview.Dock = DockStyle.Fill;
            room_datagridview.Location = new Point(3, 99);
            room_datagridview.Name = "room_datagridview";
            room_datagridview.RowHeadersWidth = 51;
            room_datagridview.Size = new Size(951, 476);
            room_datagridview.TabIndex = 1;
            // 
            // room_information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(tableLayoutPanel1);
            Name = "room_information";
            Text = "room_information";
            Load += room_information_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)room_datagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label doctor_name;
        private TextBox room_number_textbox;
        private Button room_number_button;
        private DataGridView room_datagridview;
        private TableLayoutPanel tableLayoutPanel3;
        private Button show_all_button;
    }
}