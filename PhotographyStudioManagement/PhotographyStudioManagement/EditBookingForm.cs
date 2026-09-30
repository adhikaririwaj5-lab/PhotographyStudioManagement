using Microsoft.Data.Sqlite;
using PhotographyStudioManagement.Data;
using PhotographyStudioManagement.Models;

namespace PhotographyStudioManagement
{
    public partial class EditBookingForm : Form
    {
        private int bookingID;
        private int currentClientID;
        private int currentServiceID;

        private List<Service> services = new List<Service>();

        public EditBookingForm(
            int bookingID,
            int clientID,
            int serviceID,
            DateTime bookingDate,
            string location,
            int hours,
            decimal price,
            string bookingStatus,
            string paymentStatus,
            decimal amountPaid,
            string notes)
        {
            InitializeComponent();

            this.bookingID = bookingID;
            currentClientID = clientID;
            currentServiceID = serviceID;

            LoadClients();
            LoadServices();
            LoadStatusOptions();

            dtpBookingDate.Value = bookingDate;
            txtLocation.Text = location;
            numHours.Value = hours;
            txtPrice.Text = price.ToString("0.00");
            cmbBookingStatus.SelectedItem = bookingStatus;
            cmbPaymentStatus.SelectedItem = paymentStatus;
            txtAmountPaid.Text = amountPaid.ToString("0.00");
            txtNotes.Text = notes;

            cmbClient.SelectedValue = currentClientID;
            cmbService.SelectedValue = currentServiceID;
        }

        private void LoadClients()
        {
            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
                    SELECT ClientID, Name, Phone, Email
                    FROM Clients
                    ORDER BY Name;";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                using SqliteDataReader reader =
                    command.ExecuteReader();

                List<Client> clients = new List<Client>();

                while (reader.Read())
                {
                    clients.Add(
                        new Client(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.IsDBNull(3) ? "" : reader.GetString(3)
                        ));
                }

                cmbClient.DataSource = clients;
                cmbClient.DisplayMember = "Name";
                cmbClient.ValueMember = "ClientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading clients: " + ex.Message);
            }
        }

        private void LoadServices()
        {
            try
            {
                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
                    SELECT ServiceID,
                           ServiceName,
                           ServiceType,
                           BasePrice,
                           EditingFee
                    FROM Services
                    ORDER BY ServiceName;";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                using SqliteDataReader reader =
                    command.ExecuteReader();

                services.Clear();

                while (reader.Read())
                {
                    int serviceID = reader.GetInt32(0);
                    string serviceName = reader.GetString(1);
                    string serviceType = reader.GetString(2);
                    decimal basePrice = reader.GetDecimal(3);
                    decimal editingFee = reader.GetDecimal(4);

                    Service service;

                    if (serviceType == "Videography")
                    {
                        service = new VideographyService(
                            serviceID,
                            serviceName,
                            basePrice,
                            editingFee);
                    }
                    else
                    {
                        service = new PhotographyService(
                            serviceID,
                            serviceName,
                            basePrice);
                    }

                    services.Add(service);
                }

                cmbService.DataSource = services;
                cmbService.DisplayMember = "ServiceName";
                cmbService.ValueMember = "ServiceID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading services: " + ex.Message);
            }
        }

        private void LoadStatusOptions()
        {
            cmbBookingStatus.Items.AddRange(
                new string[]
                {
                    "Pending",
                    "Confirmed",
                    "Completed",
                    "Cancelled"
                });

            cmbPaymentStatus.Items.AddRange(
                new string[]
                {
                    "Unpaid",
                    "Partially Paid",
                    "Paid"
                });
        }

        private decimal CalculatePrice()
        {
            if (cmbService.SelectedItem is not Service service)
                return 0;

            int hours = (int)numHours.Value;

            return service.CalculatePrice(hours);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal price = CalculatePrice();

            txtPrice.Text = price.ToString("0.00");
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedItem == null ||
                cmbService.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a client and service.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the booking location.");

                return;
            }

            if (!decimal.TryParse(
                txtAmountPaid.Text,
                out decimal amountPaid))
            {
                MessageBox.Show(
                    "Please enter a valid amount paid.");

                return;
            }

            decimal price = CalculatePrice();

            if (amountPaid < 0 || amountPaid > price)
            {
                MessageBox.Show(
                    "Amount paid must be between 0 and the booking price.");

                return;
            }

            try
            {
                Client client =
                    (Client)cmbClient.SelectedItem;

                Service service =
                    (Service)cmbService.SelectedItem;

                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
                    UPDATE Bookings
                    SET ClientID = @ClientID,
                        ServiceID = @ServiceID,
                        BookingDate = @BookingDate,
                        Location = @Location,
                        Hours = @Hours,
                        Price = @Price,
                        BookingStatus = @BookingStatus,
                        PaymentStatus = @PaymentStatus,
                        AmountPaid = @AmountPaid,
                        Notes = @Notes
                    WHERE BookingID = @BookingID;";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@ClientID", client.ClientID);

                command.Parameters.AddWithValue(
                    "@ServiceID", service.ServiceID);

                command.Parameters.AddWithValue(
                    "@BookingDate",
                    dtpBookingDate.Value.ToString(
                        "yyyy-MM-dd HH:mm:ss"));

                command.Parameters.AddWithValue(
                    "@Location",
                    txtLocation.Text.Trim());

                command.Parameters.AddWithValue(
                    "@Hours",
                    (int)numHours.Value);

                command.Parameters.AddWithValue(
                    "@Price",
                    price);

                command.Parameters.AddWithValue(
                    "@BookingStatus",
                    cmbBookingStatus.SelectedItem!.ToString());

                command.Parameters.AddWithValue(
                    "@PaymentStatus",
                    cmbPaymentStatus.SelectedItem!.ToString());

                command.Parameters.AddWithValue(
                    "@AmountPaid",
                    amountPaid);

                command.Parameters.AddWithValue(
                    "@Notes",
                    txtNotes.Text.Trim());

                command.Parameters.AddWithValue(
                    "@BookingID",
                    bookingID);

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Booking updated successfully!");

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating booking: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}