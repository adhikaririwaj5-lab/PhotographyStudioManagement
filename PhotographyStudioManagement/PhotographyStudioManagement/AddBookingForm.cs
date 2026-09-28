using Microsoft.Data.Sqlite;
using PhotographyStudioManagement.Data;
using PhotographyStudioManagement.Models;

namespace PhotographyStudioManagement
{
    public partial class AddBookingForm : Form
    {
        private List<Service> services = new List<Service>();

        public AddBookingForm()
        {
            InitializeComponent();

            LoadClients();
            LoadServices();
            LoadStatusOptions();

            txtAmountPaid.Text = "0";
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
                    Client client = new Client(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.IsDBNull(3) ? "" : reader.GetString(3)
                    );

                    clients.Add(client);
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

            cmbBookingStatus.SelectedIndex = 0;
            cmbPaymentStatus.SelectedIndex = 0;
        }

        private decimal CalculateSelectedServicePrice()
        {
            if (cmbService.SelectedItem is not Service selectedService)
            {
                return 0;
            }

            int hours = (int)numHours.Value;

            return selectedService.CalculatePrice(hours);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal price = CalculateSelectedServicePrice();

            txtPrice.Text = price.ToString("0.00");
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedItem == null)
            {
                MessageBox.Show("Please select a client.");
                return;
            }

            if (cmbService.SelectedItem == null)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the booking location.");
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

            if (amountPaid < 0)
            {
                MessageBox.Show(
                    "Amount paid cannot be negative.");
                return;
            }

            try
            {
                Client selectedClient =
                    (Client)cmbClient.SelectedItem;

                Service selectedService =
                    (Service)cmbService.SelectedItem;

                decimal price =
                    CalculateSelectedServicePrice();

                if (amountPaid > price)
                {
                    MessageBox.Show(
                        "Amount paid cannot be greater than the booking price.");
                    return;
                }

                txtPrice.Text = price.ToString("0.00");

                using SqliteConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string sql = @"
                    INSERT INTO Bookings
                    (
                        ClientID,
                        ServiceID,
                        BookingDate,
                        Location,
                        Hours,
                        Price,
                        BookingStatus,
                        PaymentStatus,
                        AmountPaid,
                        Notes
                    )
                    VALUES
                    (
                        @ClientID,
                        @ServiceID,
                        @BookingDate,
                        @Location,
                        @Hours,
                        @Price,
                        @BookingStatus,
                        @PaymentStatus,
                        @AmountPaid,
                        @Notes
                    );";

                using SqliteCommand command =
                    new SqliteCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@ClientID",
                    selectedClient.ClientID);

                command.Parameters.AddWithValue(
                    "@ServiceID",
                    selectedService.ServiceID);

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

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Booking saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving booking: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            if (cmbClient.Items.Count > 0)
                cmbClient.SelectedIndex = 0;

            if (cmbService.Items.Count > 0)
                cmbService.SelectedIndex = 0;

            dtpBookingDate.Value = DateTime.Now;

            txtLocation.Clear();

            numHours.Value = 1;

            txtPrice.Clear();

            cmbBookingStatus.SelectedIndex = 0;
            cmbPaymentStatus.SelectedIndex = 0;

            txtAmountPaid.Text = "0";

            txtNotes.Clear();

            txtLocation.Focus();
        }
    }
}