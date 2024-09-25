namespace Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // No.1
                //picShow.ImageLocation = ofd.FileName;

                // No.2
                //System.Drawing.Image image = System.Drawing.Image.FromFile(ofd.FileName);
                //picShow.Image = image;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No.3 show image by url
            picShow.ImageLocation = "https://images.unsplash.com/photo-1726994804363-5c7ce2255254?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";

        }
    }
}
