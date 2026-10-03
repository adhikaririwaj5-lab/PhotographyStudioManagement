namespace PhotographyStudioManagement
{
    partial class AddClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Client Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(45, 85);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 27);
            txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(167, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(173, 27);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Client";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(198, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(532, 353);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Name = "AddClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPhone;
        private Label lblEmail;

        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;

        private Button btnSave;
        private Button btnClear;
    }
}