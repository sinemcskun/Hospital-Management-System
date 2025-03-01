using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class shift_report : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public shift_report()
        {
            InitializeComponent();
        }

        private void shift_report_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadShiftData(); 
        }

        private void ConfigureDataGridView()
        {
            shift_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shift_datagridview.ReadOnly = true;
            shift_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shift_datagridview.AllowUserToAddRows = false;
        }

        private void LoadShiftData(string filter = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "CONCAT(s.firstname, ' ', s.lastname) AS \"Staff Name - Surname\", " +
                                   "dep.departmentname AS \"Department\", " +
                                   "sh.shiftstart AS \"Shift Start\", " +
                                   "sh.shiftend AS \"Shift End\" " +
                                   "FROM shift sh " +
                                   "JOIN staff s ON sh.staffid = s.staffid " +
                                   "JOIN department dep ON sh.departmentid = dep.departmentid";

                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += " WHERE s.firstname ILIKE @Name OR s.lastname ILIKE @Name";
                    }

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                    // Eğer filtre varsa parametre ekle
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + filter + "%");
                    }

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    shift_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string searchTerm = shift_name_textbox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadShiftData(searchTerm); 
            }
            else
            {
                MessageBox.Show("Please enter your first or last name."); 
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            LoadShiftData(); 
        }
    }
}
