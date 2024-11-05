using System.Security.Cryptography;

namespace ProyectoCompany.Classes
{
    public class Encrypt
    {
        private static readonly string keyFilePath = "aes_key.txt";
        private static readonly string ivFilePath = "aes_iv.txt";
        private byte[] key = Array.Empty<byte>();
        private byte[] iv = Array.Empty<byte>();

        #region "AES Files"
        public void comprobarSiHayArchivosAes(){
            
            // Comprobar si ya existen las claves, si no, generarlas
            if (File.Exists(keyFilePath) && File.Exists(ivFilePath))
            {
                key = convertirarchivoAes(keyFilePath);
                iv = convertirarchivoAes(ivFilePath);
            }
            else
            {
                MessageBox.Show("Creados los archivos de encriptación.");
                crearArchivosEncriptacion();
            }
        }

        private byte[] convertirarchivoAes(string path)
        {
            byte[] result = Convert.FromBase64String(File.ReadAllText(path));
            return result;
        }

        private void crearArchivosEncriptacion() {
            using (Aes myAes = Aes.Create())
            {
                byte[] key, iv;
                string keyFilePath = "aes_key.txt";
                string ivFilePath = "aes_iv.txt";

                key = myAes.Key;
                iv = myAes.IV;

                // Almacenar clave y IV
                File.WriteAllText(keyFilePath, Convert.ToBase64String(key));
                File.WriteAllText(ivFilePath, Convert.ToBase64String(iv));
            }
        }
        #endregion
        #region "Encrypt & Decrypt"
        public byte[] EncryptStringToBytes_Aes(string plainText)
        {
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        public string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
        #endregion
    }
}
