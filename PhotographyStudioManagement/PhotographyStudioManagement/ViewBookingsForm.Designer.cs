namespace PhotographyStudioManagement
{
    partial class ViewBookingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSearch = new TextBox();
            cmbStatusFilter = new ComboBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvBookings = new DataGridView();
            btnDeleteBooking = new Button();
            btnEditBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 74);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "Booking list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 127);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 193);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(133, 120);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 3;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(133, 190);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(151, 28);
            cmbStatusFilter.TabIndex = 4;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(304, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(330, 190);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(37, 225);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(996, 325);
            dgvBookings.TabIndex = 7;
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.Location = new Point(496, 562);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(94, 29);
            btnDeleteBooking.TabIndex = 8;
            btnDeleteBooking.Text = "Delete Booking";
            btnDeleteBooking.UseVisualStyleBackColor = true;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            // 
            // btnEditBooking
            // 
            btnEditBooking.Location = new Point(365, 562);
            btnEditBooking.Name = "btnEditBooking";
            btnEditBooking.Size = new Size(94, 29);
            btnEditBooking.TabIndex = 9;
            btnEditBooking.Text = "Edit Booking";
            btnEditBooking.UseVisualStyleBackColor = true;
            btnEditBooking.Click += btnEditBooking_Click;
            // 
            // ViewBookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(btnEditBooking);
            Controls.Add(btnDeleteBooking);
            Controls.Add(dgvBookings);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(cmbStatusFilter);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewBookingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Bookings";
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearch;
        private ComboBox cmbStatusFilter;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvBookings;
        private Button btnDeleteBooking;
        private Button btnEditBooking;
    }
}