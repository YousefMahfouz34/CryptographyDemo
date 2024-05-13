using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ASymmetricEncryption
{
    public partial class Form1 : Form
    {
        RSAParameters PublicKey;
        RSAParameters PrivateKey;
        public Form1()
        {
            InitializeComponent();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            PublicKey = rsa.ExportParameters(false);
            PrivateKey = rsa.ExportParameters(true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Encrypt_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(PublicKey);
            byte[] message = Encoding.Unicode.GetBytes(textBox1.Text);
            byte[] EncryptMessage = rsa.Encrypt(message, false);
            textBox2.Text = Convert.ToBase64String(EncryptMessage);
        }
        private void Deycrept_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(PrivateKey);
            byte[] EncryptedMessage = Convert.FromBase64String(textBox2.Text);
            byte[] DecryptedMessage = rsa.Decrypt(EncryptedMessage, false);
            textBox3.Text = Encoding.Unicode.GetString(DecryptedMessage);
        }
    }
}
