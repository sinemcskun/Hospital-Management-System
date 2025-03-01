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
    public partial class leave_report : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public leave_report()
        {
            InitializeComponent();
        }

        private void leave_report_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadLeaveData();
        }

        private void ConfigureDataGridView()
        {
            leave_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            leave_datagridview.ReadOnly = true;
            leave_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leave_datagridview.AllowUserToAddRows = false;
        }

        private void LoadLeaveData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "CONCAT(s.firstname, ' ', s.lastname) AS \"Staff Name - Surname\", " +
                                   "l.leavetype AS \"Leave Type\", " +
                                   "l.startdate AS \"Start Date\", " +
                                   "l.enddate AS \"End Date\", " +
                                   "l.reason AS \"Reason for Leave\" " +
                                   "FROM leave l " +
                                   "JOIN staff s ON l.staffid = s.staffid";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    leave_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SearchLeaveDataByName(string name)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "CONCAT(s.firstname, ' ', s.lastname) AS \"Staff Name\", " +
                                   "l.leavetype AS \"Leave Type\", " +
                                   "l.startdate AS \"Start Date\", " +
                                   "l.enddate AS \"End Date\", " +
                                   "l.reason AS \"Reason for Leave\" " +
                                   "FROM leave l " +
                                   "JOIN staff s ON l.staffid = s.staffid " +
                                   "WHERE s.firstname ILIKE @Name OR s.lastname ILIKE @Name";

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", "%" + name + "%");

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    leave_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void leave_name_button_grid_Click(object sender, EventArgs e)
        {
            string searchTerm = leave_name_textbox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                SearchLeaveDataByName(searchTerm);
            }
            else
            {
                MessageBox.Show("Please enter a first or last name.");
            }
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            LoadLeaveData();
        }
    }
}

