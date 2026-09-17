using Microsoft.Data.Sqlite;
using PhotographyStudioManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhotographyStudioManagement
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the client name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter the phone number.");
                return;
            }

            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
            INSERT INTO Clients (Name, Phone, Email)
            VALUES (@Name, @Phone, @Email);";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Name", txtName.Text.Trim());

                command.Parameters.AddWithValue(
                    "@Phone", txtPhone.Text.Trim());

                command.Parameters.AddWithValue(
                    "@Email", txtEmail.Text.Trim());

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Client saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();

                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving client: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtName.Focus();
        }
    }
}
