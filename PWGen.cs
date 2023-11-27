using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Passwort_Generator
{
    public class PWGen
    {
        private static readonly RNGCryptoServiceProvider cryptoRandom = new RNGCryptoServiceProvider();

        public static string GeneratePW(int counter, out bool isValid)
        {
            isValid = (counter >= 8 && counter <= 24);

            if (!isValid)
            {
                MessageBox.Show("Count must be between 8 and 24 for better acceptance on most websites!");
                return null;
            }

            StringBuilder password = new StringBuilder();
            string characters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=<>?/";

            for (int i = 0; i < counter; i++)
            {
                byte[] randomBytes = new byte[4];
                cryptoRandom.GetBytes(randomBytes);
                int randomNumber = BitConverter.ToInt32(randomBytes, 0);

                int index = Math.Abs(randomNumber % characters.Length);
                password.Append(characters[index]);
            }

            return password.ToString();
        }
    }
}
