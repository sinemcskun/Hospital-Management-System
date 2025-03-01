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
    public partial class add_patient : Form
    {
        string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public add_patient()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string firstName = name_textbox.Text.Trim();
            string lastName = surname_textbox.Text.Trim();
            string ageText = age_textbox.Text.Trim();
            string nationalId = ssn_textbox.Text.Trim();
            string phone = textBox2.Text.Trim();
            string email = e_mail_textbox.Text.Trim();
            string address = address_textbox.Text.Trim();


            int? age = null;
            if (!string.IsNullOrEmpty(ageText))
            {
                if (int.TryParse(ageText, out int parsedAge))
                {
                    if (parsedAge < 0 || parsedAge > 150)
                    {
                        MessageBox.Show("Invalid age! The age must be between 0 and 150.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    age = parsedAge;
                }
                else
                {
                    MessageBox.Show("Age should only be a numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (var command = new NpgsqlCommand("CALL insert_patient(@first_name, @last_name, @age, @national_id, @phone, @input_email, @address, @input_picture)", connection))
                    {
                        command.Parameters.AddWithValue("first_name", firstName);
                        command.Parameters.AddWithValue("last_name", lastName);
                        command.Parameters.AddWithValue("age", (object)age ?? DBNull.Value);
                        command.Parameters.AddWithValue("national_id", nationalId);
                        command.Parameters.AddWithValue("phone", phone);
                        command.Parameters.AddWithValue("input_email", email);
                        command.Parameters.AddWithValue("address", address);
                        command.Parameters.AddWithValue("input_picture", TempImageBytes ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Patient successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private byte[] TempImageBytes = null;

        private void upload_photo_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;


                    if (patient_picture_box.Image == null)
                    {
                        patient_picture_box.Image = Image.FromFile(filePath);
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
