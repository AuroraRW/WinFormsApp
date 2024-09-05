namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hello(object sender, EventArgs e)
        {
            // type mbox then type tab twice
            MessageBox.Show("Hello world!");
        }

        private void ChangeText(object sender, EventArgs e)
        {
            btn.Text = "Text changed";
        }
    }
}
