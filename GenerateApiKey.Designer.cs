using System.Security.Cryptography;
using System.Text;

namespace GenerateCustomerApiKey
{
    partial class GenerateApiKey : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateApiKey));
            btnApiKey = new Button();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            txtCustomerNumber = new TextBox();
            lblCustomerNumber = new Label();
            txtApiKey = new TextBox();
            lblCustApiKey = new Label();
            label1 = new Label();
            dtpexpirydate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnApiKey
            // 
            btnApiKey.Location = new Point(335, 262);
            btnApiKey.Name = "btnApiKey";
            btnApiKey.Size = new Size(430, 48);
            btnApiKey.TabIndex = 0;
            btnApiKey.Text = "Generate ApiKey";
            btnApiKey.UseVisualStyleBackColor = true;
            btnApiKey.Click += btnApiKey_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(44, 73);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(259, 25);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Name(Example: ABC University)";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(335, 67);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(551, 31);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerNumber
            // 
            txtCustomerNumber.Location = new Point(335, 129);
            txtCustomerNumber.Name = "txtCustomerNumber";
            txtCustomerNumber.Size = new Size(551, 31);
            txtCustomerNumber.TabIndex = 4;
            // 
            // lblCustomerNumber
            // 
            lblCustomerNumber.AutoSize = true;
            lblCustomerNumber.Location = new Point(44, 135);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(255, 25);
            lblCustomerNumber.TabIndex = 3;
            lblCustomerNumber.Text = "Customer Number(Ex: 100919)";
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(335, 344);
            txtApiKey.Multiline = true;
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(551, 71);
            txtApiKey.TabIndex = 6;
            // 
            // lblCustApiKey
            // 
            lblCustApiKey.AutoSize = true;
            lblCustApiKey.Location = new Point(44, 350);
            lblCustApiKey.Name = "lblCustApiKey";
            lblCustApiKey.Size = new Size(198, 25);
            lblCustApiKey.TabIndex = 5;
            lblCustApiKey.Text = "Secure Encoded ApiKey";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 201);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 7;
            label1.Text = "Expiry Date";
            // 
            // dtpexpirydate
            // 
            dtpexpirydate.Location = new Point(335, 204);
            dtpexpirydate.Name = "dtpexpirydate";
            dtpexpirydate.Size = new Size(551, 31);
            dtpexpirydate.TabIndex = 8;
            dtpexpirydate.Leave += dtpexpirydate_ValueChanged;
            // 
            // GenerateApiKey
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 473);
            Controls.Add(dtpexpirydate);
            Controls.Add(label1);
            Controls.Add(txtApiKey);
            Controls.Add(lblCustApiKey);
            Controls.Add(txtCustomerNumber);
            Controls.Add(lblCustomerNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(btnApiKey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "GenerateApiKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apikey Generator";
            Load += GenerateApiKey_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApiKey;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private TextBox txtCustomerNumber;
        private Label lblCustomerNumber;
        private TextBox txtApiKey;
        private Label lblCustApiKey;
        private Label label1;
        private DateTimePicker dtpexpirydate;
    }
}