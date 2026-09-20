using Microsoft.Data.Sqlite;
using PhotographyStudioManagement.Data;
using System.Data;

namespace PhotographyStudioManagement
{
    public partial class ViewClientsForm : Form
    {
        public ViewClientsForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients(string searchTerm = "")
        {
            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql;

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql = @"
                        SELECT ClientID, Name, Phone, Email
                        FROM Clients
                        ORDER BY Name;";
                }
                else
                {
                    sql = @"
                        SELECT ClientID, Name, Phone, Email
                        FROM Clients
                        WHERE Name LIKE @Search
                           OR Phone LIKE @Search
                           OR Email LIKE @Search
                        ORDER BY Name;";
                }

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    command.Parameters.AddWithValue(
                        "@Search",
                        "%" + searchTerm.Trim() + "%");
                }

                using SqliteDataReader reader =
                    command.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                dvgClients.DataSource = table;

                dvgClients.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading clients: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadClients(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadClients();
            txtSearch.Focus();
        }
    }
}