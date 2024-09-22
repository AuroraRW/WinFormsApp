using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForm
{
    public partial class Form2 : Form
    {
        // No1. pass value from Form1 to Form2 by constructor 
        //public Form2(string Name)
        //{
        //    InitializeComponent();
        //    lblName.Text += Name;
        //    lblName.Text += "\n Please confirm your name!";
        //}


        // No2. Using public properties to pass value from Form1 to Form2
        public Form2()
        {
            InitializeComponent();
        }
        public string DisplayName = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text += DisplayName;
            lblName.Text += "\n \n \n Please confirm your name!";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
