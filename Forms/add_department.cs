using Npgsql;

namespace hospital_management_system.Forms
{
    public partial class add_department : Form
    {
        string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public add_department()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string department_name = department_name_textbox.Text.Trim();

            if (string.IsNullOrEmpty(department_name))
            {
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (var command = new NpgsqlCommand("CALL add_department(@departmentname)", connection))
                    {

                        command.Parameters.AddWithValue("departmentname", department_name);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Department successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
