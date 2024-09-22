namespace MultipleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// No1.
            //Form2 F2 = new Form2(txtName.Text);
            //F2.ShowDialog();

            //// No2
            //Form2 F2 = new Form2();
            //F2.DisplayName = txtName.Text;
            //// Modal Form: blocking, has return value
            //F2.ShowDialog();
            //// Modeless Form
            ////F2.Show();

            // Check if the user click OK or Cancel
            Form2 F2 = new Form2();
            F2.DisplayName = txtName.Text;
            DialogResult result = F2.ShowDialog();
            if (result == DialogResult.OK) 
            {
                lblResult.Text = "User clicked OK!";
            }
            if (result == DialogResult.Cancel) 
            {
                lblResult.Text = "User clicked Cancel!";
            }
        }
    }
}
