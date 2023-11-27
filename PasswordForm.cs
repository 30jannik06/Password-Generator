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
                PWGen.GeneratePW(counter: length);
            }
        }

        private void copyPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordOutput.Text == null)
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
