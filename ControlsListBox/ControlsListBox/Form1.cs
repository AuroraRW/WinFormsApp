namespace ControlsListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Click button to add new item of pear
            //lstFruit.Items.Add("pear");

            // Input a new fruit to textbox, then click button to add into listbox
            if (txtNewFruit.Text != "")
            {
                lstFruit.Items.Add(txtNewFruit.Text);
                txtNewFruit.Text = "";
            }

            // Append the array to listbox
            //string[] FruitItems = { "pear", "peach" };
            //lstFruit.Items.AddRange(FruitItems);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get selected index and value
            //MessageBox.Show(lstFruit.SelectedIndex.ToString());
            //MessageBox.Show(lstFruit.SelectedItem.ToString());

            //Delete
            //lstFruit.Items.RemoveAt(lstFruit.SelectedIndex);
            if (lstFruit.SelectedItem != null)
            {
                lstFruit.Items.Remove(lstFruit.SelectedItem);
            }
            else
            {
                MessageBox.Show("please select a item!");
            }

        }

        private void txtNewFruit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstFruit.Items.Add(txtNewFruit.Text);
                txtNewFruit.Text = "";
            }
        }
    }
}
