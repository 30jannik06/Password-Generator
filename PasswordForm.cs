namespace Passwort_Generator
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            _PasswordForm = this;
        }

        public static PasswordForm _PasswordForm;

        public void update(string message)
        {
            passwordOutput.Text = message;
        }

        private void passwordGenerateButton_Click(object sender, EventArgs e)
        {
            if (lenghtCount.Text == "")
            {
                return;
            }
            else
            {
                int length = int.Parse(lenghtCount.Text);
                bool isValid;
                string generatedPassword = PWGen.GeneratePW(counter: length, out isValid);

                if (isValid)
                {
                    update(generatedPassword);
                }
            }
        }

        private void copyPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordOutput.Text == "")
            {
                return;
            }
            else
            {
                Clipboard.SetText(passwordOutput.Text);
            }
        }
    }
}