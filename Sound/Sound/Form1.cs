using System.Media;

namespace Sound
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
            // put the sound file in the folder where exe file is
            // _soundPlayer = new SoundPlayer("clapping.wav");

            //_soundPlayer = new SoundPlayer("..\\..\\..\\..\\resource\\clapping.wav");
            //_soundPlayer = new SoundPlayer(@"..\..\..\..\resource\clapping.wav");

            // add resource
            _soundPlayer = new SoundPlayer(Properties.Resources.clapping);
        }

        private void chkPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlay.Checked)
            {
                chkPlay.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                chkPlay.Text = "Play";
                _soundPlayer.Stop();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                btnPlay.Text = "Stop";
                _soundPlayer.Play();
                flag = true;
            }
            else
            {
                btnPlay.Text = "Play";
                _soundPlayer.Stop();
                flag = false;
            }

        }
    }
}
