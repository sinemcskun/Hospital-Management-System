using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class nurse : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public nurse()
        {
            InitializeComponent();
        }

        private void nurse_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadNurseData();
        }

        private void ConfigureDataGridView()
        {
            nurse_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nurse_datagridview.ReadOnly = true;
            nurse_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            nurse_datagridview.AllowUserToAddRows = false;
        }

        private void LoadNurseData(string filter = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "s.firstname AS \"Name\", " +
                                   "s.lastname AS \"Surname\", " +
                                   "d.departmentname AS \"Department\", " +
                                   "s.nationalid AS \"National ID\", " +
                                   "s.email AS \"Email\", " +
                                   "s.phone AS \"Phone Number\", " +
                                   "s.address AS \"Address\", " +
                                   "s.salary AS \"Salary\" " +
                                   "FROM staff s " +
                                   "JOIN department d ON s.departmentid = d.departmentid " +
                                   "WHERE s.roleid = 2";

                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += " AND (s.firstname ILIKE @Name OR s.lastname ILIKE @Name)";
                    }

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + filter + "%");
                    }

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    nurse_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void nurse_name_button_Click(object sender, EventArgs e)
        {
            string searchTerm = nurse_name_textbox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadNurseData(searchTerm); 
            }
            else
            {
                MessageBox.Show("Please enter your first or last name.");
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            LoadNurseData(); 
        }
    }
}
