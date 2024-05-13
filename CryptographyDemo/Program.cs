using System.Security.Cryptography;

using System.Text;

namespace CryptographyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter the  text ");
            //string plaintext= Console.ReadLine();
            //SHA256 SHA512 = SHA256.Create();
            //byte[] hash = SHA512.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
            //var hashed = BitConverter.ToString(hash).Replace("-", "");
            //Console.WriteLine("Data after hashed ");
            //Console.WriteLine(hashed);
            byte[] key = RandomNumberGenerator.GetBytes(16);
            byte[] iv = RandomNumberGenerator.GetBytes(16);
            Console.WriteLine("Enter the  text to encrypt ");
            //encrypt data
            string str= Console.ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(str);
            byte[] encryptmsg=Encrypt(data, key, iv);
            string encyrptdata= Convert.ToBase64String(encryptmsg);
            Console.WriteLine(encyrptdata );
            //deycrept data

            string res= Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(encyrptdata), key, iv));
            Console.WriteLine(res);
           
        }
        //public byte[] Encrypt(string plaintext)
        //{
        //    byte[] key = RandomNumberGenerator.GetBytes(16);
        //    byte[] iv = RandomNumberGenerator.GetBytes(16);        //    using (SymmetricAlgorithm algorithm =Aes.Create())        //    { }
        //}

        public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (Aes algorithm = Aes.Create())
            using (ICryptoTransform encryptor = algorithm.CreateEncryptor(key, iv))
                return Crypt(data, encryptor);
        }
        public static byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (Aes algorithm = Aes.Create())
            using (ICryptoTransform decryptor = algorithm.CreateDecryptor(key, iv))
                return Crypt(data, decryptor);
        }
        static byte[] Crypt(byte[] data, ICryptoTransform cryptor)
        {
            MemoryStream m = new MemoryStream();
            using (Stream c = new CryptoStream(m, cryptor, CryptoStreamMode.Write))
                c.Write(data, 0, data.Length);
            return m.ToArray();
        }
    }
}
