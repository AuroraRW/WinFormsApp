using System.Security.Cryptography;

namespace PrebuiltDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file";
            //ofd.Filter = "TEXT file|*.txt";
            ofd.Filter = "TEXT file|*.txt|RTF file| *.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("OK");
                // path
                //MessageBox.Show(ofd.FileName);
                // file name
                //MessageBox.Show(ofd.SafeFileName);

                string filePath = ofd.FileName;

                // read from txt file
                //string fileContent = File.ReadAllText(filePath);
                //MessageBox.Show(fileContent);
                //txtFileContent.Text = fileContent;

                // read from rtf file
                rtxtFileContent.LoadFile(filePath);

            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save file";
            sfd.Filter = "TEXT file|*.txt|RTF file| *.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // save to txt file
                string filePath = sfd.FileName;
                //File.WriteAllText(filePath, txtFileContent.Text);

                // save to rtf file
                rtxtFileContent.SaveFile(filePath);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // set up in code 
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.ShowHelp = true;
            cd.HelpRequest += new EventHandler(cd_HelpRequest);

            if (cd.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cd.Color;
            }


            // set up in properties
            //if (cdChangeColor.ShowDialog() == DialogResult.OK)
            //{
            //    btnColor.BackColor = cdChangeColor.Color;
            //}
        }
        private void cd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose a color (from code)!");
        }

        private void cdChangeColor_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose a color!");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd=new FontDialog();
            fd.ShowColor = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                rtxtFileContent.Font = fd.Font;
                rtxtFileContent.ForeColor = fd.Color;
            }
        }
    }
}
