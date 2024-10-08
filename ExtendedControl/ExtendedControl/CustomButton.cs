using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControl
{
    public class CustomButton:Button
    {
        public CustomButton()
        {
            this.MouseEnter += CustomButton_MouseEnter;
            this.MouseLeave += CustomButton_MouseLeave;

        }

        private void CustomButton_MouseEnter(object sender, EventArgs e) 
        {
            this.BackColor = Color.LightBlue;
        }
        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
