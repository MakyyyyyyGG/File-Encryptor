using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            // Check if the file path is empty
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a file before encrypting.");
                return; // Exit the method if the file path is empty
            }

            // Check if the selected file does not exist
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("The selected file does not exist.");
                return; // Exit the method if the file does not exist
            }

            // If the conditions are met, show the encryption panel
            encryptPanel.Visible = true;
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            encryptPanel.Visible = false;
            keyTextbox.Text = "";
            
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            string inputFile = textBox1.Text;
            string key = keyTextbox.Text;

            if (!File.Exists(inputFile))
            {
                MessageBox.Show("Input file does not exist!");
                return;
            }

            string outputFile = inputFile + ".encrypted";

            try
            {
                // Derive a 256-bit key from the plaintext key
                byte[] derivedKey = DeriveKey(key);

                // Encrypt the file using the derived key
                EncryptFile(inputFile, outputFile, derivedKey);
                textBox1.Text = "";
                MessageBox.Show("Encryption successful! \nLocated at: " + outputFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message);
            }
        }

        private byte[] DeriveKey(string key)
        {
            // Use SHA-256 hash to derive a 256-bit key
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            }
        }

        private void EncryptFile(string inputFile, string outputFile, byte[] key)
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC; // Change cipher mode to CBC

                byte[] iv = aes.IV;

                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                {
                    fsOutput.Write(iv, 0, iv.Length);

                    using (CryptoStream csEncrypt = new CryptoStream(fsOutput, aes.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                    {
                        using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead;

                            while ((bytesRead = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                csEncrypt.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
        }

 

        private void decryptCancelBtn_Click(object sender, EventArgs e)
        {
            decryptPanel.Visible = false;
            keyTextbox.Text = "";
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            // Check if the file path is empty
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a file before encrypting.");
                return; // Exit the method if the file path is empty
            }

            // Check if the selected file does not exist
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("The selected file does not exist.");
                return; // Exit the method if the file does not exist
            }

            // If the conditions are met, show the encryption panel
            decryptPanel.Visible = true;
        }

        private void proceedDecrypt_Click(object sender, EventArgs e)
        {
            string inputFile = textBox1.Text;
            string key = dkeyTextbox.Text;

            if (!File.Exists(inputFile))
            {
                MessageBox.Show("Input file does not exist!");
                return;
            }

            string outputFile = Path.GetFileNameWithoutExtension(inputFile); // Remove ".encrypted" extension

            try
            {
                // Derive a 256-bit key from the plaintext key
                byte[] derivedKey = DeriveKey(key);

                // Decrypt the file using the derived key
                DecryptFile(inputFile, outputFile, derivedKey);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }
        }


        private void DecryptFile(string inputFile, string outputFile, byte[] key)
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC; // Change cipher mode to CBC

                byte[] iv = new byte[16]; // Initialization vector

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                {
                    fsInput.Read(iv, 0, iv.Length); // Read the IV from the input file

                    // Get the original filename without extension
                    string originalFileName = Path.GetFileNameWithoutExtension(inputFile);

                    // Create the decrypted filename with "Decrypted_" prepended
                    string decryptedFileName = Path.Combine(Path.GetDirectoryName(inputFile), $"Decrypted_{originalFileName}");

                    try
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(fsInput, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOutput = new FileStream(decryptedFileName, FileMode.Create))
                            {
                                byte[] buffer = new byte[1024];
                                int bytesRead;

                                while ((bytesRead = csDecrypt.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOutput.Write(buffer, 0, bytesRead);
                                }
                            }
                        }

                        MessageBox.Show("Decryption successful! \nLocated at:" + decryptedFileName);
                        textBox1.Text = "";
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Decryption failed: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void encryptPanel_Paint(object sender, PaintEventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void decryptPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
