namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruit = { "orange", "apple", "banana" };
            cboFruit.Items.AddRange(Fruit);
            cboFruit.Sorted = true;

        }

        private void cboFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = cboFruit.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboFruit.Items.Count!=0)
            {
                for(int i=0; i< cboFruit.Items.Count; i++)
                {
                    if(cboFruit.Text == cboFruit.Items[i].ToString())
                    {
                        MessageBox.Show("This item already exist");
                        cboFruit.Text = "";
                        return;
                    }
                }
            }
            cboFruit.Items.Add(cboFruit.Text);
            cboFruit.Sorted = true;
            cboFruit.Text = "";
        }
    }
}
