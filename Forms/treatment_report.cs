using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class treatment_report : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public treatment_report()
        {
            InitializeComponent();
        }

        private void treatment_report_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadTreatmentData();
        }

        private void ConfigureDataGridView()
        {
            treatment_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            treatment_datagridview.ReadOnly = true;
            treatment_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            treatment_datagridview.AllowUserToAddRows = false;
        }

        private void LoadTreatmentData(string patientNameFilter = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string query = "SELECT " +
                       "CONCAT(p.firstname, ' ', p.lastname) AS \"Patient Name - Surname\", " +
                       "CONCAT(s.firstname, ' ', s.lastname) AS \"Doctor Name - Surname\", " + 
                       "t.diagnosis AS \"Diagnosis\", " +
                       "t.treatment AS \"Treatment Details\", " +
                       "t.treatmentdate AS \"Treatment Date\" " +
                       "FROM treatment t " +
                       "JOIN staff s ON t.staffid = s.staffid " +
                       "JOIN patient p ON t.patientid = p.patientid";

                    if (!string.IsNullOrEmpty(patientNameFilter))
                    {
                        query += " WHERE p.firstname ILIKE @PatientName OR p.lastname ILIKE @PatientName";
                    }


                    NpgsqlCommand command = new NpgsqlCommand(query, connection);


                    if (!string.IsNullOrEmpty(patientNameFilter))
                    {
                        command.Parameters.AddWithValue("@PatientName", "%" + patientNameFilter + "%");
                    }

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    treatment_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void patient_name_button_Click_1(object sender, EventArgs e)
        {
            string searchTerm = patient_name_textbox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadTreatmentData(searchTerm);
            }
            else
            {
                MessageBox.Show("Please enter your first or last name.");
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            LoadTreatmentData();
        }
    }
}
