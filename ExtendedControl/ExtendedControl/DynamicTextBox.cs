using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControl
{
    public class DynamicTextBox:TextBox
    {
        public DynamicTextBox()
        {
            this.PlaceholderText = "Please input";
            // set up the letter to upper case
            this.CharacterCasing = CharacterCasing.Upper;
            // set up the max length to 10
            this.MaxLength = 10;

            this.TextChanged += DynamicTextBox_TextChanged;
        }
        private void DynamicTextBox_TextChanged(object sender, EventArgs e) 
        {
            if (this.Text.Length >= 10)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
                MessageBox.Show("No more than 10");
            }
            else if (this.Text.Length >= 5)
            {
                this.BackColor = Color.Green;
                this.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }
    }
}
