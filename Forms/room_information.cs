using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace hospital_management_system.Forms
{
    public partial class room_information : Form
    {
        private readonly string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";

        public room_information()
        {
            InitializeComponent();
        }

        private void room_information_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadRoomData();

            room_datagridview.CellFormatting += room_datagridview_CellFormatting;
        }

        private void ConfigureDataGridView()
        {
            room_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            room_datagridview.ReadOnly = true;
            room_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            room_datagridview.AllowUserToAddRows = false;
        }

        private void LoadRoomData(string roomNumberFilter = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "r.roomnumber AS \"Room Number\", " +
                                   "r.roomtype AS \"Room Type\", " +
                                   "CASE WHEN r.status = true THEN 'Occupied' ELSE 'Available' END AS \"Room Status\", " +
                                   "CONCAT(p.firstname, ' ', p.lastname) AS \"Patient Name - Surname\", " +
                                   "t.diagnosis AS \"Diagnosis\", " +
                                   "CONCAT(s.firstname, ' ', s.lastname) AS \"Doctor Name - Surname\", " +
                                   "dep.departmentname AS \"Doctor Department\", " +
                                   "r.entrydate AS \"Entry Date\", " +
                                   "r.dischargedate AS \"Discharge Date\" " +
                                   "FROM room r " +
                                   "LEFT JOIN patient p ON r.patientid = p.patientid " +
                                   "LEFT JOIN treatment t ON p.patientid = t.patientid " +
                                   "LEFT JOIN staff s ON t.staffid = s.staffid " +
                                   "LEFT JOIN department dep ON s.departmentid = dep.departmentid";


                    if (!string.IsNullOrEmpty(roomNumberFilter))
                    {
                        query += " WHERE r.roomnumber::TEXT ILIKE @RoomNumber";
                    }

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);


                    if (!string.IsNullOrEmpty(roomNumberFilter))
                    {
                        command.Parameters.AddWithValue("@RoomNumber", "%" + roomNumberFilter + "%");
                    }

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    room_datagridview.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void room_datagridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            var cellValue = room_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            
            if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrWhiteSpace(cellValue.ToString()))
            {
                e.CellStyle.BackColor = Color.LightGreen; 
            }
            else
            {
                e.CellStyle.BackColor = Color.White; 
            }
        }


        private void room_number_button_Click(object sender, EventArgs e)
        {
            string searchTerm = room_number_textbox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadRoomData(searchTerm); 
            }
            else
            {
                MessageBox.Show("Please enter a room number.");
            }
        }

        private void show_all_button_Click_1(object sender, EventArgs e)
        {
            LoadRoomData(); 
        }

       
    }
}
