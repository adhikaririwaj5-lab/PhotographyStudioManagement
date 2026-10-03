namespace PhotographyStudioManagement
{
    partial class ViewClientsForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dvgClients = new DataGridView();
            btnDeleteClient = new Button();
            btnEditClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgClients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 52);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Client List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 120);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(155, 117);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(337, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(458, 120);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dvgClients
            // 
            dvgClients.AllowUserToAddRows = false;
            dvgClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgClients.Location = new Point(98, 171);
            dvgClients.Name = "dvgClients";
            dvgClients.ReadOnly = true;
            dvgClients.RowHeadersWidth = 51;
            dvgClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgClients.Size = new Size(474, 205);
            dvgClients.TabIndex = 5;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(366, 397);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(94, 29);
            btnDeleteClient.TabIndex = 6;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(212, 397);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(94, 29);
            btnEditClient.TabIndex = 7;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // ViewClientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditClient);
            Controls.Add(btnDeleteClient);
            Controls.Add(dvgClients);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewClientsForm";
            Text = "ViewClientsForm";
            ((System.ComponentModel.ISupportInitialize)dvgClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dvgClients;
        private Button btnDeleteClient;
        private Button btnEditClient;
    }
}