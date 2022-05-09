namespace PasswortGenerator
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

        private void PWForm_Load(object sender, EventArgs e)
        {
            PWGen sample = new PWGen();
        }

        private void passwordGenerateButton_Click(object sender, EventArgs e)
        {
            if (lenghtCount.Text == "")
            {
                return;
            }
            else
            {
                int lenght = int.Parse(lenghtCount.Text);
                PWGen.GeneratePW(counter: lenght);
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