using Microsoft.Data.Sqlite;
using PhotographyStudioManagement.Data;

namespace PhotographyStudioManagement
{
    public partial class EditClientForm : Form
    {
        private int clientID;

        public EditClientForm(
            int clientID,
            string name,
            string phone,
            string email)
        {
            InitializeComponent();

            this.clientID = clientID;

            txtName.Text = name;
            txtPhone.Text = phone;
            txtEmail.Text = email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter the client name.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter the phone number.");

                return;
            }

            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
                    UPDATE Clients
                    SET Name = @Name,
                        Phone = @Phone,
                        Email = @Email
                    WHERE ClientID = @ClientID;";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Name",
                    txtName.Text.Trim());

                command.Parameters.AddWithValue(
                    "@Phone",
                    txtPhone.Text.Trim());

                command.Parameters.AddWithValue(
                    "@Email",
                    txtEmail.Text.Trim());

                command.Parameters.AddWithValue(
                    "@ClientID",
                    clientID);

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Client updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating client: " +
                    ex.Message);
            }
        }

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}