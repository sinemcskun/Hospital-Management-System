using hospital_management_system.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class main_page : Form
    {
        private int childFormNumber = 0;

        public main_page()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void add_appointment_menu_Click(object sender, EventArgs e)
        {
            add_appointment add_appointmentForm = new add_appointment();
            add_appointmentForm.Show();

        }

        private void room_information_menu_Click(object sender, EventArgs e)
        {
            room_information room_informationForm = new room_information();
            room_informationForm.Show();
        }

        private void addtreatment_menu_Click(object sender, EventArgs e)
        {
            add_treatment add_treatmentForm = new add_treatment();
            add_treatmentForm.Show();
        }

        private void treatment_report_Click(object sender, EventArgs e)
        {
            treatment_report treatment_reportForm = new treatment_report();
            treatment_reportForm.Show();
        }

        private void add_patient_menu_Click(object sender, EventArgs e)
        {
            add_patient add_patientForm = new add_patient();
            add_patientForm.Show();
        }

        private void show_patient_menu_Click(object sender, EventArgs e)
        {
            show_patient show_patientForm = new show_patient();
            show_patientForm.Show();
        }

        private void shift_report_menu_Click(object sender, EventArgs e)
        {
            shift_report shift_reportForm = new shift_report();
            shift_reportForm.Show();
        }

        private void leave_report_menu_Click(object sender, EventArgs e)
        {
            leave_report leave_reportForm = new leave_report();
            leave_reportForm.Show();
        }

        private void doctor_menu_Click(object sender, EventArgs e)
        {
            doctor doctorForm = new doctor();
            doctorForm.Show();
        }

        private void doctor_room_menu_Click(object sender, EventArgs e)
        {
            doctor_room doctor_roomForm = new doctor_room();
            doctor_roomForm.Show();
        }

        private void nurse_menu_Click(object sender, EventArgs e)
        {
            nurse nurseForm = new nurse();
            nurseForm.Show();
        }

        private void wardboy_menu_Click(object sender, EventArgs e)
        {
            wardboy wardboyForm = new wardboy();
            wardboyForm.Show();
        }

        private void add_update_staff_menu_Click(object sender, EventArgs e)
        {
            add_update_staff add_update_staffForm = new add_update_staff();
            add_update_staffForm.Show();
        }

        private void main_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_department add_DepartmentForm = new add_department();
            add_DepartmentForm.Show();
        }
    }
}
