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
    }
}
