namespace PhotographyStudioManagement
{
    partial class AddBookingForm
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
            cmbClient = new ComboBox();
            cmbService = new ComboBox();
            dtpBookingDate = new DateTimePicker();
            txtLocation = new TextBox();
            numHours = new NumericUpDown();
            txtPrice = new TextBox();
            cmbBookingStatus = new ComboBox();
            cmbPaymentStatus = new ComboBox();
            txtNotes = new TextBox();
            txtAmountPaid = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnSaveBooking = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            SuspendLayout();
            // 
            // cmbClient
            // 
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(164, 12);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(151, 28);
            cmbClient.TabIndex = 0;
            // 
            // cmbService
            // 
            cmbService.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(164, 46);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(151, 28);
            cmbService.TabIndex = 1;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Location = new Point(164, 89);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(250, 27);
            dtpBookingDate.TabIndex = 2;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(164, 122);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 3;
            // 
            // numHours
            // 
            numHours.Location = new Point(165, 155);
            numHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.Size = new Size(150, 27);
            numHours.TabIndex = 4;
            numHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(164, 195);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(125, 34);
            txtPrice.TabIndex = 5;
            // 
            // cmbBookingStatus
            // 
            cmbBookingStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingStatus.FormattingEnabled = true;
            cmbBookingStatus.Location = new Point(164, 244);
            cmbBookingStatus.Name = "cmbBookingStatus";
            cmbBookingStatus.Size = new Size(151, 28);
            cmbBookingStatus.TabIndex = 6;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(164, 287);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(151, 28);
            cmbPaymentStatus.TabIndex = 7;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(164, 380);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(338, 85);
            txtNotes.TabIndex = 8;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Location = new Point(165, 331);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(125, 27);
            txtAmountPaid.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(116, 495);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 29);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(222, 530);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveBooking
            // 
            btnSaveBooking.Location = new Point(278, 495);
            btnSaveBooking.Name = "btnSaveBooking";
            btnSaveBooking.Size = new Size(120, 29);
            btnSaveBooking.TabIndex = 12;
            btnSaveBooking.Text = "Save Booking";
            btnSaveBooking.UseVisualStyleBackColor = true;
            btnSaveBooking.Click += btnSaveBooking_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 13;
            label1.Text = "Client:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 94);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 14;
            label2.Text = "Booking Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 15;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 162);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 16;
            label4.Text = "Hours:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 209);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 17;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 252);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 18;
            label6.Text = "Booking Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 295);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 19;
            label7.Text = "Payment Status:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 338);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 20;
            label8.Text = "Amount Paid:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 383);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 21;
            label9.Text = "Notes:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 54);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 22;
            label10.Text = "Service:";
            // 
            // AddBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 653);
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
            Controls.Add(btnSaveBooking);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtAmountPaid);
            Controls.Add(txtNotes);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(cmbBookingStatus);
            Controls.Add(txtPrice);
            Controls.Add(numHours);
            Controls.Add(txtLocation);
            Controls.Add(dtpBookingDate);
            Controls.Add(cmbService);
            Controls.Add(cmbClient);
            Name = "AddBookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Booking";
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClient;
        private ComboBox cmbService;
        private DateTimePicker dtpBookingDate;
        private TextBox txtLocation;
        private NumericUpDown numHours;
        private TextBox txtPrice;
        private ComboBox cmbBookingStatus;
        private ComboBox cmbPaymentStatus;
        private TextBox txtNotes;
        private TextBox txtAmountPaid;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnSaveBooking;
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
    }
}