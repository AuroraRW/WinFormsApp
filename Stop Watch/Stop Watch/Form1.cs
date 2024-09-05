namespace Stop_Watch
{
    public partial class FormStopWatch : Form
    {
        public FormStopWatch()
        {
            InitializeComponent();
        }
        DateTime start;
        DateTime stop;
        TimeSpan elapsedTime;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            txtStart.Text = start.ToLongTimeString();
            txtStop.Text = "";
            txtElapsed.Text = "";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            txtStop.Text = stop.ToLongTimeString();
            elapsedTime = stop - start;
            txtElapsed.Text = elapsedTime.Seconds.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
