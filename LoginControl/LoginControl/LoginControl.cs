using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginControl
{
    public partial class LoginControl : UserControl
    {
        // Create event
        public event EventHandler LoginButtonClick;

        public LoginControl()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // trigger LoginButtonClick event
            LoginButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
