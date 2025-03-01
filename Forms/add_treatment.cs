using Npgsql;

namespace hospital_management_system.Forms
{
    public partial class add_treatment : Form
    {
        string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public add_treatment()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string staffName = staff_name_textbox.Text.Trim();
            string staffSurname = staff_surname_textbox.Text.Trim();
            string patientName = patient_name_textbox.Text.Trim();
            string patientSurname = patient_surname_textbox.Text.Trim();
            string diagnosis = diagnosis_textbox.Text.Trim();
            string treatment = treatment_textbox.Text.Trim();
            DateTime treatmentDate;

            if (!DateTime.TryParse(dateTimePicker1.Text, out treatmentDate))
            {
                MessageBox.Show("Select a valid treatment date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(staffName) || string.IsNullOrEmpty(staffSurname) ||
        string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(patientSurname) ||
        string.IsNullOrEmpty(diagnosis) || string.IsNullOrEmpty(treatment))
            {
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (var command = new NpgsqlCommand("CALL create_treatment(@patient_name, @staff_name, @diagnosis, @treatment, @treatment_date,@treatment_picture )", connection))
                    {

                        command.Parameters.AddWithValue("patient_name", patientName + " " + patientSurname);
                        command.Parameters.AddWithValue("staff_name", staffName + " " + staffSurname);
                        command.Parameters.AddWithValue("diagnosis", diagnosis);
                        command.Parameters.AddWithValue("treatment", treatment);
                        command.Parameters.AddWithValue("treatment_date", treatmentDate);
                        command.Parameters.AddWithValue("treatment_picture", TempImageBytes ?? (object)DBNull.Value);


                        command.ExecuteNonQuery();
                        MessageBox.Show("The treatment record has been successfully created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            staff_name_textbox.Clear();
            staff_surname_textbox.Clear();
            patient_name_textbox.Clear();
            patient_surname_textbox.Clear();
            diagnosis_textbox.Clear();
            treatment_textbox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            treatment_picture_box.Image = null;
            TempImageBytes = null;
        }
        private byte[] TempImageBytes = null;

        private void Photo_upload_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = openFileDialog.FileName;


                    if (treatment_picture_box.Image == null) 
                    {
                        treatment_picture_box.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        MessageBox.Show("This PictureBox is already full.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                    TempImageBytes = File.ReadAllBytes(filePath);
                }
            }
        }
    }
}
