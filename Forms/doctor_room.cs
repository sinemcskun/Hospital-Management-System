using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class doctor_room : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public doctor_room()
        {
            InitializeComponent();
        }

        private void doctor_room_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadDoctorRoomData(); 
        }

        private void ConfigureDataGridView()
        {
            doctor_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctor_datagridview.ReadOnly = true;
            doctor_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctor_datagridview.AllowUserToAddRows = false;
        }

        private void LoadDoctorRoomData(string filter = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "CONCAT(s.firstname, ' ', s.lastname) AS \"Doctor Name - Surname\", " +
                                   "d.roomnumber AS \"Room Number\", " +
                                   "d.internalnumber AS \"Internal Extension\", " +
                                   "dep.departmentname AS \"Department\" " +
                                   "FROM doctor d " +
                                   "JOIN staff s ON d.staffid = s.staffid " +
                                   "JOIN department dep ON s.departmentid = dep.departmentid";

                    
                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += " WHERE s.firstname ILIKE @Name OR s.lastname ILIKE @Name";
                    }

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                   
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + filter + "%");
                    }

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    doctor_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void doctor_name_button_Click(object sender, EventArgs e)
        {
            string searchTerm = doctor_name_textbox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadDoctorRoomData(searchTerm); 
            }
            else
            {
                MessageBox.Show("Please enter a first or last name.");
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            LoadDoctorRoomData(); 
        }
    }
}
