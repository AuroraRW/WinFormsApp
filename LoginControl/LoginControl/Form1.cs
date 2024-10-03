namespace LoginControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loginControl.LoginButtonClick += new EventHandler(LoginControl_LoginButtonClick);
        }
        private void LoginControl_LoginButtonClick(object sender, EventArgs e)
        {
            string username = loginControl.Username;
            string password = loginControl.Password;

            MessageBox.Show($"UserName: {username}\nPassword: {password}");
        }
    }
}
