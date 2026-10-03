namespace PhotographyStudioManagement
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddClient = new Button();
            btnViewClients = new Button();
            btnAddbooking = new Button();
            btnViewBookings = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(269, 247);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(94, 29);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnViewClients
            // 
            btnViewClients.Location = new Point(269, 299);
            btnViewClients.Name = "btnViewClients";
            btnViewClients.Size = new Size(124, 29);
            btnViewClients.TabIndex = 1;
            btnViewClients.Text = "View Clients";
            btnViewClients.UseVisualStyleBackColor = true;
            btnViewClients.Click += btnViewClients_Click;
            // 
            // btnAddbooking
            // 
            btnAddbooking.Location = new Point(409, 247);
            btnAddbooking.Name = "btnAddbooking";
            btnAddbooking.Size = new Size(133, 29);
            btnAddbooking.TabIndex = 2;
            btnAddbooking.Text = "Add Booking";
            btnAddbooking.UseVisualStyleBackColor = true;
            btnAddbooking.Click += btnAddbooking_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.Location = new Point(409, 299);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(133, 29);
            btnViewBookings.TabIndex = 3;
            btnViewBookings.Text = "View Bookings";
            btnViewBookings.UseVisualStyleBackColor = true;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 164);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(882, 503);
            Controls.Add(label1);
            Controls.Add(btnViewBookings);
            Controls.Add(btnAddbooking);
            Controls.Add(btnViewClients);
            Controls.Add(btnAddClient);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Photography Studio Management System";
            Load += this.Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnAddClient;
        private Button btnViewClients;
        private Button btnAddbooking;
        private Button btnViewBookings;
        private Label label1;
    }
}
