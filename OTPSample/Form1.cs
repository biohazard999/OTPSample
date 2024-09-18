using OtpNet;
using QRCoder;

namespace OTPSample
{
    public partial class Form1 : Form
    {
        private string _secretKey;
        private Totp _totp;

        public Form1()
        {
            InitializeComponent();
            GenerateQrCode();
        }


        // Method to generate QR Code and initialize TOTP
        private void GenerateQrCode()
        {
            // Generate a random secret key (base32)
            var key = KeyGeneration.GenerateRandomKey(20);
            _secretKey = Base32Encoding.ToString(key);
            _totp = new Totp(key);

            // Generate the QR code URL for scanning
            string otpUrl = $"otpauth://totp/MyApp?secret={_secretKey}&issuer=MyApp";

            // Generate the QR Code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(otpUrl, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Display the QR code in PictureBox
            pictureBoxQrCode.Image = qrCodeImage;
        }

        // Button click event to verify OTP
        private void buttonVerify_Click(object sender, EventArgs e)
        {
            // Get the OTP entered by the user
            string enteredOtp = textBoxOtp.Text.Trim();

            // Verify the OTP
            bool isValid = _totp.VerifyTotp(enteredOtp, out long timeStepMatched, new VerificationWindow(1, 1));

            // Display result
            labelResult.Text = isValid ? "OTP is valid!" : "Invalid OTP!";
            labelResult.ForeColor = isValid ? Color.Green : Color.Red;
        }
    }
}
