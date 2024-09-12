namespace ListBoxMoveItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fruit = { "apple", "carrot", "fries", "peach", "cola", "bread" };
            lstLeft.Items.AddRange(fruit);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //for (int i = lstLeft.SelectedIndices.Count - 1; i >= 0; i--) {
            //    if (lstLeft.SelectedIndices.Count > 0)
            //    {
            //        int selectedIndex = lstLeft.SelectedIndices[i];
            //        var selectedItem = lstLeft.Items[selectedIndex];
            //        lstRight.Items.Add(selectedItem);
            //        lstLeft.Items.RemoveAt(selectedIndex);
            //    }
            //}

            while (lstLeft.SelectedIndices.Count != 0)
            {
                if (lstLeft.SelectedIndices.Count > 0)
                {
                    int selectedIndex = lstLeft.SelectedIndices[0];
                    var selectedItem = lstLeft.Items[selectedIndex];
                    lstRight.Items.Add(selectedItem);
                    lstLeft.Items.RemoveAt(selectedIndex);
                }
            }

        }

        private void lstRight_DoubleClick(object sender, EventArgs e)
        {
            if(lstRight.Items.Count != 0)
            {
                lstLeft.Items.Add(lstRight.Items[lstRight.SelectedIndex]);
                lstRight.Items.RemoveAt(lstRight.SelectedIndex);
            }
        }
    }
}
