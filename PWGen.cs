using System.Text;

namespace PasswortGenerator
{
    public class PWGen
    {
        // This method generates the password.
        public static void GeneratePW(int counter)
        {
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            List<char> characters = new List<char>();
            characters.AddRange(Enumerable.Range('a', 26).Select(i => (char)i));
            characters.AddRange(Enumerable.Range('A', 26).Select(i => (char)i));
            characters.AddRange(Enumerable.Range('0', 10).Select(i => (char)i));
            characters.AddRange(Enumerable.Range('!', 16).Select(i => (char)i));

            if (counter <= 0)
            {

                MessageBox.Show("Count musst be 1-24!");
                return;
            }
            else
            {
                for (int i = 0; i < counter; i++)
                {
                    password.Append(characters[random.Next(characters.Count)]);
                }
                // Can be used to display the generated password in pop-up.
                // MessageBox.Show(password.ToString());

                // Used to update the password output field
                PasswordForm._PasswordForm.update("" + password.ToString());
            }
        }
    }
}
