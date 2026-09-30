using Microsoft.Data.Sqlite;
using PhotographyStudioManagement.Data;
using System.Data;

namespace PhotographyStudioManagement
{
    public partial class ViewBookingsForm : Form
    {
        public ViewBookingsForm()
        {
            InitializeComponent();

            LoadStatusFilter();
            LoadBookings();
        }

        private void LoadStatusFilter()
        {
            cmbStatusFilter.Items.Clear();

            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Confirmed");
            cmbStatusFilter.Items.Add("Completed");
            cmbStatusFilter.Items.Add("Cancelled");

            cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadBookings(
            string searchTerm = "",
            string status = "All")
        {
            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
                    SELECT
                        b.BookingID AS 'Booking ID',
                        b.ClientID AS 'ClientID',
                        b.ServiceID AS 'ServiceID',
                        c.Name AS 'Client',
                        s.ServiceName AS 'Service',
                        b.BookingDate AS 'Booking Date',
                        b.Location,
                        b.Hours,
                        b.Price,
                        b.BookingStatus AS 'Booking Status',
                        b.PaymentStatus AS 'Payment Status',
                        b.AmountPaid AS 'Amount Paid',
                        b.Notes
                    FROM Bookings b
                    INNER JOIN Clients c
                        ON b.ClientID = c.ClientID
                    INNER JOIN Services s
                        ON b.ServiceID = s.ServiceID
                    WHERE
                    (
                        @Search = ''
                        OR c.Name LIKE @SearchPattern
                        OR s.ServiceName LIKE @SearchPattern
                        OR b.Location LIKE @SearchPattern
                        OR CAST(b.BookingID AS TEXT)
                           LIKE @SearchPattern
                    )
                    AND
                    (
                        @Status = 'All'
                        OR b.BookingStatus = @Status
                    )
                    ORDER BY b.BookingDate DESC;";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Search",
                    searchTerm.Trim());

                command.Parameters.AddWithValue(
                    "@SearchPattern",
                    "%" + searchTerm.Trim() + "%");

                command.Parameters.AddWithValue(
                    "@Status",
                    status);

                using SqliteDataReader reader =
                    command.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                dgvBookings.DataSource = table;
                dgvBookings.Columns["ClientID"].Visible = false;
                dgvBookings.Columns["ServiceID"].Visible = false;

                dgvBookings.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading bookings: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string status =
                cmbStatusFilter.SelectedItem?.ToString() ?? "All";

            LoadBookings(
                txtSearch.Text,
                status);
        }

        private void cmbStatusFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbStatusFilter.SelectedItem == null)
                return;

            LoadBookings(
                txtSearch.Text,
                cmbStatusFilter.SelectedItem.ToString()!);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            cmbStatusFilter.SelectedIndex = 0;

            LoadBookings();

            txtSearch.Focus();
        }
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int bookingID = Convert.ToInt32(
                dgvBookings.SelectedRows[0].Cells["Booking ID"].Value);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Booking #{bookingID}?",
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

                string sql = @"
            DELETE FROM Bookings
            WHERE BookingID = @BookingID;";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@BookingID",
                    bookingID);

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Booking deleted successfully!");

                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting booking: " + ex.Message);
            }
        }
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to edit.");
                return;
            }

            DataGridViewRow row =
                dgvBookings.SelectedRows[0];

            int bookingID =
                Convert.ToInt32(row.Cells["Booking ID"].Value);

            int clientID =
                Convert.ToInt32(row.Cells["ClientID"].Value);

            int serviceID =
                Convert.ToInt32(row.Cells["ServiceID"].Value);

            DateTime bookingDate =
                Convert.ToDateTime(row.Cells["Booking Date"].Value);

            string location =
                row.Cells["Location"].Value?.ToString() ?? "";

            int hours =
                Convert.ToInt32(row.Cells["Hours"].Value);

            decimal price =
                Convert.ToDecimal(row.Cells["Price"].Value);

            string bookingStatus =
                row.Cells["Booking Status"].Value?.ToString() ?? "Pending";

            string paymentStatus =
                row.Cells["Payment Status"].Value?.ToString() ?? "Unpaid";

            decimal amountPaid =
                Convert.ToDecimal(row.Cells["Amount Paid"].Value);

            string notes =
                row.Cells["Notes"].Value?.ToString() ?? "";

            using EditBookingForm form =
                new EditBookingForm(
                    bookingID,
                    clientID,
                    serviceID,
                    bookingDate,
                    location,
                    hours,
                    price,
                    bookingStatus,
                    paymentStatus,
                    amountPaid,
                    notes);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
            }
        }

    }
}