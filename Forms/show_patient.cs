using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class show_patient : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public show_patient()
        {
            InitializeComponent();
        }

        private void show_patient_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadPatientData(); 
        }

        private void ConfigureDataGridView()
        {
            patient_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patient_datagridview.ReadOnly = true;
            patient_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patient_datagridview.AllowUserToAddRows = false;
        }

        private void LoadPatientData(string filter = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "CONCAT(firstname, ' ', lastname) AS \"Name - Surname\", " +
                                   "age AS \"Age\", " +
                                   "phone AS \"Phone Number\", " +
                                   "email AS \"Email Address\" " +
                                   "FROM patient";

                    
                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += " WHERE firstname ILIKE @Name OR lastname ILIKE @Name";
                    }

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                    
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + filter + "%");
                    }

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    patient_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void patient_name_button_Click(object sender, EventArgs e)
        {
            string searchTerm = patient_name_textbox.Text.Trim(); 
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadPatientData(searchTerm); 
            }
            else
            {
                MessageBox.Show("Please enter your first or last name."); 
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            LoadPatientData(); 
        }
    }
}
