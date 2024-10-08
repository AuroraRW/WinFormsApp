namespace ExtendedControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefault_MouseEnter(object sender, EventArgs e)
        {
            btnDefault.BackColor = Color.LightBlue;
        }

        private void btnDefault_MouseLeave(object sender, EventArgs e)
        {
            btnDefault.BackColor = SystemColors.Control;
        }

        private void btnDefault_MouseHover(object sender, EventArgs e)
        {
            btnDefault.BackColor = Color.LightPink;
        }
        private void btnDefault_Click(object sender, EventArgs e)
        {
            btnDefault.BackColor = Color.Blue;
        }

        private void txtDefault_TextChanged(object sender, EventArgs e)
        {
            if (txtDefault.Text.Length >= 10)
            {
                txtDefault.BackColor = Color.Red;
                txtDefault.ForeColor = Color.White;
                MessageBox.Show("No more than 10");
            }else if (txtDefault.Text.Length >= 5)
            {
                txtDefault.BackColor= Color.Green;
                txtDefault.ForeColor = Color.Black;
            }
            else
            {
                txtDefault.BackColor = Color.White;
                txtDefault.ForeColor = Color.Black;
            }
        }
    }
}
