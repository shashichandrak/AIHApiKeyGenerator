using System.Security.Cryptography;
using System.Text;

namespace GenerateCustomerApiKey
{
    /// <summary>
    /// Form to generate API key for customer
    /// </summary>
    public partial class GenerateApiKey : Form
    {
        public GenerateApiKey()
        {
            InitializeComponent();

        }

        private void btnApiKey_Click(object sender, EventArgs e)
        {
            // Check if customer name and number are empty
            if (string.IsNullOrEmpty(txtCustomerName.Text) && string.IsNullOrEmpty(txtCustomerNumber.Text))
            {
                MessageBox.Show("Please enter customer name and number");
                return;
            }
            // Generate API key
            var custApiKey = GenerateAPIKey($"{txtCustomerName.Text}-{txtCustomerNumber.Text}-{dtpexpirydate.Value.ToString()}");
            txtApiKey.Text = custApiKey;
        }

        /// <summary>
        /// Generate API key
        /// </summary>
        /// <param name="apiKeyMeta"></param>
        /// <returns></returns>
        private string GenerateAPIKey(string apiKeyMeta)
        {
            // Convert API key meta to bytes
            byte[] apiKeyMetaBytes = Encoding.UTF8.GetBytes(apiKeyMeta);
            // Get current timestamp
            byte[] timestampBytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
            // Create HMACSHA256 object
            using (var hmac = new HMACSHA256(apiKeyMetaBytes))
            {
                byte[] hashBytes = hmac.ComputeHash(timestampBytes);
                // Return base64 encoded API key
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void GenerateApiKey_Load(object sender, EventArgs e)
        {
            // Set expiry date to 1 year from now
            dtpexpirydate.Value = DateTime.Now.AddYears(1);
        }

        private void dtpexpirydate_ValueChanged(object sender, EventArgs e)
        {
            // Check if expiry date is less than 1 year from now
            if(dtpexpirydate.Value < DateTime.Now.AddYears(1))
            {
                MessageBox.Show("Expiry date cannot be less than 1 year from now.");
                dtpexpirydate.Value = DateTime.Now.AddYears(1);
            }
        }
    }
}
    