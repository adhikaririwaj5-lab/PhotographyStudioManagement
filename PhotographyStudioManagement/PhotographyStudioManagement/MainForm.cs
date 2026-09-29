namespace PhotographyStudioManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (AddClientForm form = new AddClientForm())
            {
                form.ShowDialog();
            }
        }

        private void btnViewClients_Click(object sender, EventArgs e)
        {
            using (ViewClientsForm form = new ViewClientsForm())
            {
                form.ShowDialog();
            }
        }

        private void btnAddbooking_Click(object sender, EventArgs e)
        {
            using AddBookingForm form = new AddBookingForm();
            form.ShowDialog();
        }
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            using ViewBookingsForm form =
                new ViewBookingsForm();

            form.ShowDialog();
        }
    }
}
