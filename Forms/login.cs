using Npgsql;
namespace hospital_management_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=192.168.123.183;Port=6000;Username=postgres;Password=yaren;Database=hospital_ms";
            string username = user_name_textbox.Text.Trim();
            string password = user_password_textbox.Text.Trim();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    
                    conn.Open();

                    
                    string query = "SELECT * FROM login WHERE username = @username AND password = @password";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Entry successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                                this.Hide(); 
                                main_page mainPage = new main_page(); 
                                mainPage.Show(); 
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
