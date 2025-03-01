using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class add_appointment : Form
    {
        string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public add_appointment()
        {
            InitializeComponent();
        }

        private void add_appointment_Load(object sender, EventArgs e)
        {
            date_picker.MinDate = DateTime.Today; 
            date_picker.Value = DateTime.Today;
            PopulateDepartmentComboBox();
        }

        private void PopulateDepartmentComboBox()
        {

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT departmentname FROM department";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                department_name_combobox.Items.Add(reader["departmentname"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string staffName = staff_name_textbox.Text.Trim();
            string staffSurname = staff_surname_textbox.Text.Trim();
            string patientName = patient_name_textbox.Text.Trim();
            string patientSurname = patient_surname_textbox.Text.Trim();
            string departmentName = department_name_combobox.Text.Trim();
            string reason = reason_textbox.Text.Trim();

            DateTime appointmentDate;

            if (!DateTime.TryParse(date_picker.Value.ToString(), out appointmentDate))
            {
                MessageBox.Show("Select a valid date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrEmpty(staffName) || string.IsNullOrEmpty(staffSurname) ||
                string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(patientSurname))
            {
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (var command = new NpgsqlCommand("CALL create_appointment(@staff_name, @patient_name, @department_name, @appointment_date, @reason)", connection))
                    {

                        command.Parameters.AddWithValue("staff_name", staffName + " " + staffSurname);
                        command.Parameters.AddWithValue("patient_name", patientName + " " + patientSurname);
                        command.Parameters.AddWithValue("department_name", departmentName);
                        command.Parameters.AddWithValue("appointment_date", appointmentDate);
                        command.Parameters.AddWithValue("reason", reason);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Appointment created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
