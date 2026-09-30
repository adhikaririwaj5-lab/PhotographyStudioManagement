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

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dvgClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            int clientID = Convert.ToInt32(
                dvgClients.SelectedRows[0].Cells["ClientID"].Value);

            string clientName =
                dvgClients.SelectedRows[0].Cells["Name"].Value.ToString() ?? "";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {clientName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                // Do not delete a client who already has bookings
                string checkSql = @"
            SELECT COUNT(*)
            FROM Bookings
            WHERE ClientID = @ClientID;";

                using SqliteCommand checkCommand =
                    new SqliteCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue(
                    "@ClientID",
                    clientID);

                long bookingCount =
                    (long)checkCommand.ExecuteScalar()!;

                if (bookingCount > 0)
                {
                    MessageBox.Show(
                        "This client cannot be deleted because they have existing bookings.");

                    return;
                }

                string deleteSql = @"
            DELETE FROM Clients
            WHERE ClientID = @ClientID;";

                using SqliteCommand deleteCommand =
                    new SqliteCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue(
                    "@ClientID",
                    clientID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show(
                    "Client deleted successfully!");

                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting client: " + ex.Message);
            }
        }
        private void btnEditClient_Click(
    object sender,
    EventArgs e)
        {
            if (dvgClients.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a client to edit.");

                return;
            }

            DataGridViewRow row =
                dvgClients.SelectedRows[0];

            int clientID =
                Convert.ToInt32(
                    row.Cells["ClientID"].Value);

            string name =
                row.Cells["Name"].Value?.ToString() ?? "";

            string phone =
                row.Cells["Phone"].Value?.ToString() ?? "";

            string email =
                row.Cells["Email"].Value?.ToString() ?? "";

            using EditClientForm form =
                new EditClientForm(
                    clientID,
                    name,
                    phone,
                    email);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }
    }
}