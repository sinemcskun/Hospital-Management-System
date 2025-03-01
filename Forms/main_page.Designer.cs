namespace hospital_management_system
{
    partial class main_page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            menuStrip = new MenuStrip();
            staff_menu = new ToolStripMenuItem();
            doctor_menu = new ToolStripMenuItem();
            doctor_room_menu = new ToolStripMenuItem();
            nurse_menu = new ToolStripMenuItem();
            wardboy_menu = new ToolStripMenuItem();
            add_update_staff_menu = new ToolStripMenuItem();
            leave_menu = new ToolStripMenuItem();
            leave_report_menu = new ToolStripMenuItem();
            shift_menu = new ToolStripMenuItem();
            shift_report_menu = new ToolStripMenuItem();
            petient_menu = new ToolStripMenuItem();
            add_patient_menu = new ToolStripMenuItem();
            show_patient_menu = new ToolStripMenuItem();
            treatment_menu = new ToolStripMenuItem();
            addtreatment_menu = new ToolStripMenuItem();
            treatment_report = new ToolStripMenuItem();
            appointment_menu = new ToolStripMenuItem();
            add_appointment_menu = new ToolStripMenuItem();
            room_menu = new ToolStripMenuItem();
            room_information_menu = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            pictureBox1 = new PictureBox();
            dEPARTMENTToolStripMenuItem = new ToolStripMenuItem();
            addDepartmentToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { staff_menu, leave_menu, shift_menu, petient_menu, treatment_menu, appointment_menu, room_menu, dEPARTMENTToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(957, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // staff_menu
            // 
            staff_menu.DropDownItems.AddRange(new ToolStripItem[] { doctor_menu, doctor_room_menu, nurse_menu, wardboy_menu, add_update_staff_menu });
            staff_menu.Name = "staff_menu";
            staff_menu.Size = new Size(62, 24);
            staff_menu.Text = "STAFF";
            // 
            // doctor_menu
            // 
            doctor_menu.Name = "doctor_menu";
            doctor_menu.Size = new Size(210, 26);
            doctor_menu.Text = "Doctor";
            doctor_menu.Click += doctor_menu_Click;
            // 
            // doctor_room_menu
            // 
            doctor_room_menu.Name = "doctor_room_menu";
            doctor_room_menu.Size = new Size(210, 26);
            doctor_room_menu.Text = "Doctor Room";
            doctor_room_menu.Click += doctor_room_menu_Click;
            // 
            // nurse_menu
            // 
            nurse_menu.Name = "nurse_menu";
            nurse_menu.Size = new Size(210, 26);
            nurse_menu.Text = "Nurse";
            nurse_menu.Click += nurse_menu_Click;
            // 
            // wardboy_menu
            // 
            wardboy_menu.Name = "wardboy_menu";
            wardboy_menu.Size = new Size(210, 26);
            wardboy_menu.Text = "Ward Boy";
            wardboy_menu.Click += wardboy_menu_Click;
            // 
            // add_update_staff_menu
            // 
            add_update_staff_menu.Name = "add_update_staff_menu";
            add_update_staff_menu.Size = new Size(210, 26);
            add_update_staff_menu.Text = "Add/Update Staff";
            add_update_staff_menu.Click += add_update_staff_menu_Click;
            // 
            // leave_menu
            // 
            leave_menu.DropDownItems.AddRange(new ToolStripItem[] { leave_report_menu });
            leave_menu.Name = "leave_menu";
            leave_menu.Size = new Size(64, 24);
            leave_menu.Text = "LEAVE";
            // 
            // leave_report_menu
            // 
            leave_report_menu.Name = "leave_report_menu";
            leave_report_menu.Size = new Size(179, 26);
            leave_report_menu.Text = "Leave Report";
            leave_report_menu.Click += leave_report_menu_Click;
            // 
            // shift_menu
            // 
            shift_menu.DropDownItems.AddRange(new ToolStripItem[] { shift_report_menu });
            shift_menu.Name = "shift_menu";
            shift_menu.Size = new Size(61, 24);
            shift_menu.Text = "SHIFT";
            // 
            // shift_report_menu
            // 
            shift_report_menu.Name = "shift_report_menu";
            shift_report_menu.Size = new Size(171, 26);
            shift_report_menu.Text = "Shift Report";
            shift_report_menu.Click += shift_report_menu_Click;
            // 
            // petient_menu
            // 
            petient_menu.DropDownItems.AddRange(new ToolStripItem[] { add_patient_menu, show_patient_menu });
            petient_menu.Name = "petient_menu";
            petient_menu.Size = new Size(78, 24);
            petient_menu.Text = "PATIENT";
            // 
            // add_patient_menu
            // 
            add_patient_menu.Name = "add_patient_menu";
            add_patient_menu.Size = new Size(177, 26);
            add_patient_menu.Text = "Add Patient";
            add_patient_menu.Click += add_patient_menu_Click;
            // 
            // show_patient_menu
            // 
            show_patient_menu.Name = "show_patient_menu";
            show_patient_menu.Size = new Size(177, 26);
            show_patient_menu.Text = "Show Patient";
            show_patient_menu.Click += show_patient_menu_Click;
            // 
            // treatment_menu
            // 
            treatment_menu.DropDownItems.AddRange(new ToolStripItem[] { addtreatment_menu, treatment_report });
            treatment_menu.Name = "treatment_menu";
            treatment_menu.Size = new Size(105, 24);
            treatment_menu.Text = "TREATMENT";
            // 
            // addtreatment_menu
            // 
            addtreatment_menu.Name = "addtreatment_menu";
            addtreatment_menu.Size = new Size(208, 26);
            addtreatment_menu.Text = "Add Treatment";
            addtreatment_menu.Click += addtreatment_menu_Click;
            // 
            // treatment_report
            // 
            treatment_report.Name = "treatment_report";
            treatment_report.Size = new Size(208, 26);
            treatment_report.Text = "Treatment Report";
            treatment_report.Click += treatment_report_Click;
            // 
            // appointment_menu
            // 
            appointment_menu.DropDownItems.AddRange(new ToolStripItem[] { add_appointment_menu });
            appointment_menu.Name = "appointment_menu";
            appointment_menu.Size = new Size(123, 24);
            appointment_menu.Text = "APPOINTMENT";
            // 
            // add_appointment_menu
            // 
            add_appointment_menu.Name = "add_appointment_menu";
            add_appointment_menu.Size = new Size(212, 26);
            add_appointment_menu.Text = "Add Appointment";
            add_appointment_menu.Click += add_appointment_menu_Click;
            // 
            // room_menu
            // 
            room_menu.DropDownItems.AddRange(new ToolStripItem[] { room_information_menu });
            room_menu.Name = "room_menu";
            room_menu.Size = new Size(67, 24);
            room_menu.Text = "ROOM";
            // 
            // room_information_menu
            // 
            room_information_menu.Name = "room_information_menu";
            room_information_menu.Size = new Size(224, 26);
            room_information_menu.Text = "Room Information";
            room_information_menu.Click += room_information_menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(957, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dEPARTMENTToolStripMenuItem
            // 
            dEPARTMENTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDepartmentToolStripMenuItem });
            dEPARTMENTToolStripMenuItem.Name = "dEPARTMENTToolStripMenuItem";
            dEPARTMENTToolStripMenuItem.Size = new Size(115, 24);
            dEPARTMENTToolStripMenuItem.Text = "DEPARTMENT";
            // 
            // addDepartmentToolStripMenuItem
            // 
            addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            addDepartmentToolStripMenuItem.Size = new Size(224, 26);
            addDepartmentToolStripMenuItem.Text = "Add Department";
            addDepartmentToolStripMenuItem.Click += addDepartmentToolStripMenuItem_Click;
            // 
            // main_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 578);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "main_page";
            Text = "main_page";
            FormClosing += main_page_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem staff_menu;
        private ToolStripMenuItem doctor_menu;
        private ToolStripMenuItem nurse_menu;
        private ToolStripMenuItem wardboy_menu;
        private ToolStripMenuItem shift_menu;
        private ToolStripMenuItem leave_menu;
        private ToolStripMenuItem petient_menu;
        private ToolStripMenuItem room_menu;
        private ToolStripMenuItem appointment_menu;
        private ToolStripMenuItem treatment_menu;
        private PictureBox pictureBox1;
        private ToolStripMenuItem add_update_staff_menu;
        private ToolStripMenuItem addtreatment_menu;
        private ToolStripMenuItem treatment_report;
        private ToolStripMenuItem add_patient_menu;
        private ToolStripMenuItem show_patient_menu;
        private ToolStripMenuItem add_appointment_menu;
        private ToolStripMenuItem room_information_menu;
        private ToolStripMenuItem leave_report_menu;
        private ToolStripMenuItem doctor_room_menu;
        private ToolStripMenuItem shift_report_menu;
        private ToolStripMenuItem dEPARTMENTToolStripMenuItem;
        private ToolStripMenuItem addDepartmentToolStripMenuItem;
    }
}



