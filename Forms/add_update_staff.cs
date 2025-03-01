using Npgsql;

namespace hospital_management_system.Forms
{
    public partial class add_update_staff : Form
    {

        string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public add_update_staff()
        {
            InitializeComponent();
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
            string firstName = name_textbox.Text.Trim();
            string lastName = surname_textbox.Text.Trim();
            string departmentName = department_name_combobox.Text.Trim();
            string roleName = role_combobox.Text.Trim();
            string nationalId = ssn_textbox.Text.Trim();
            string salary = salary_textbox.Text.Trim();
            string email = e_mail_textbox.Text.Trim();
            string phone = phone_number_textbox.Text.Trim();
            string address = address_textbox.Text.Trim();


            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("CALL insert_staff_by_names(@role_name, @department_name, @first_name, @last_name, @national_id, @email, @phone, @address, @salary, @input_picture)", connection))
                    {
                        command.Parameters.AddWithValue("role_name", roleName);
                        command.Parameters.AddWithValue("department_name", departmentName);
                        command.Parameters.AddWithValue("first_name", firstName);
                        command.Parameters.AddWithValue("last_name", lastName);
                        command.Parameters.AddWithValue("national_id", nationalId);
                        command.Parameters.AddWithValue("email", email);
                        command.Parameters.AddWithValue("phone", phone);
                        command.Parameters.AddWithValue("address", address);
                        command.Parameters.AddWithValue("salary", Convert.ToDecimal(salary));
                        command.Parameters.AddWithValue("input_picture", TempImageBytes ?? (object)DBNull.Value);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Staff successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            name_textbox.Clear();
            surname_textbox.Clear();
            department_name_combobox.SelectedIndex = -1;
            role_combobox.SelectedIndex = -1;
            ssn_textbox.Clear();
            salary_textbox.Clear();
            address_textbox.Clear();
            phone_number_textbox.Clear();
            e_mail_textbox.Clear();
            
        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            string ssn = ssn_textbox.Text.Trim();
            string salary = salary_textbox.Text.Trim();
            string phone = phone_number_textbox.Text.Trim();
            string email = e_mail_textbox.Text.Trim();
            string address = address_textbox.Text.Trim();

            if (string.IsNullOrEmpty(ssn))
            {
                MessageBox.Show("Please enter a valid SSN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("CALL update_staff(@ssn, @new_phone, @new_email, @new_address, @new_salary)", connection))
                    {
                        command.Parameters.AddWithValue("ssn", ssn);
                        command.Parameters.AddWithValue("new_phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        command.Parameters.AddWithValue("new_email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        command.Parameters.AddWithValue("new_address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        command.Parameters.AddWithValue("new_salary", string.IsNullOrEmpty(salary) ? (object)DBNull.Value : Convert.ToDecimal(salary));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Personnel information has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_update_staff_Load(object sender, EventArgs e)
        {
            PopulateDepartmentComboBox();
        }

        private byte[] TempImageBytes = null;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;


                    if (staff_picture_box.Image == null)
                    {
                        staff_picture_box.Image = Image.FromFile(filePath);
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
