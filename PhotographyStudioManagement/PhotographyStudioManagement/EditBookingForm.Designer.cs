namespace PhotographyStudioManagement
{
    partial class EditBookingForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cmbClient = new ComboBox();
            cmbPaymentStatus = new ComboBox();
            cmbBookingStatus = new ComboBox();
            cmbService = new ComboBox();
            dtpBookingDate = new DateTimePicker();
            txtLocation = new TextBox();
            txtPrice = new TextBox();
            txtAmountPaid = new TextBox();
            txtNotes = new TextBox();
            numHours = new NumericUpDown();
            btnCalculate = new Button();
            btnUpdateBooking = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Client:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 53);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Service:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Booking Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 117);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 150);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Hours:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 183);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 217);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 6;
            label7.Text = "Booking Status:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 251);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 7;
            label8.Text = "Payment Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 285);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 8;
            label9.Text = "Amount Paid:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 321);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 9;
            label10.Text = "Notes:";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(143, 11);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(151, 28);
            cmbClient.TabIndex = 10;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(145, 243);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(151, 28);
            cmbPaymentStatus.TabIndex = 11;
            // 
            // cmbBookingStatus
            // 
            cmbBookingStatus.FormattingEnabled = true;
            cmbBookingStatus.Location = new Point(144, 209);
            cmbBookingStatus.Name = "cmbBookingStatus";
            cmbBookingStatus.Size = new Size(151, 28);
            cmbBookingStatus.TabIndex = 12;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(144, 45);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(151, 28);
            cmbService.TabIndex = 13;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Location = new Point(145, 77);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(250, 27);
            dtpBookingDate.TabIndex = 14;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(145, 110);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(144, 176);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 17;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Location = new Point(145, 278);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(125, 27);
            txtAmountPaid.TabIndex = 18;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(145, 314);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(125, 27);
            txtNotes.TabIndex = 19;
            // 
            // numHours
            // 
            numHours.Location = new Point(144, 143);
            numHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.Size = new Size(150, 27);
            numHours.TabIndex = 20;
            numHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(103, 372);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 21;
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnUpdateBooking
            // 
            btnUpdateBooking.Location = new Point(228, 372);
            btnUpdateBooking.Name = "btnUpdateBooking";
            btnUpdateBooking.Size = new Size(154, 29);
            btnUpdateBooking.TabIndex = 22;
            btnUpdateBooking.Text = "Update Booking";
            btnUpdateBooking.UseVisualStyleBackColor = true;
            btnUpdateBooking.Click += btnUpdateBooking_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(103, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 653);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateBooking);
            Controls.Add(btnCalculate);
            Controls.Add(numHours);
            Controls.Add(txtNotes);
            Controls.Add(txtAmountPaid);
            Controls.Add(txtPrice);
            Controls.Add(txtLocation);
            Controls.Add(dtpBookingDate);
            Controls.Add(cmbService);
            Controls.Add(cmbBookingStatus);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(cmbClient);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditBookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Booking";
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cmbClient;
        private ComboBox cmbPaymentStatus;
        private ComboBox cmbBookingStatus;
        private ComboBox cmbService;
        private DateTimePicker dtpBookingDate;
        private TextBox txtLocation;
        private TextBox txtPrice;
        private TextBox txtAmountPaid;
        private TextBox txtNotes;
        private NumericUpDown numHours;
        private Button btnCalculate;
        private Button btnUpdateBooking;
        private Button btnCancel;
    }
}