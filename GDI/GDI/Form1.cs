namespace GDI
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Rectangle updateRectangle=new Rectangle(0, 300, 800, 50);
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.Width = 800;
            this.Height = 600;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            x += 5;
            if (x > this.Width) x = 0;
            this.Invalidate(updateRectangle); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // set up pen
            Pen bluePen = new Pen(Color.Blue, 3);

            //g.DrawLine(Pens.Blue, 10, 10, 200, 10);
            g.DrawLine(bluePen, 10, 10, 200, 10);

            g.DrawRectangle(Pens.Red, 20, 20, 100, 50);

            g.FillEllipse(Brushes.Green, 150, 50, 100, 50);

            

            // release pen object
            bluePen.Dispose();
            /////////////////////text///////////////////
            Font font = new Font("Arial", 16);

            g.DrawString("Hello", font, Brushes.Black, new PointF(10, 10));

            Font italicFont = new Font("Arial", 16, FontStyle.Italic);
            g.DrawString("Italic Text", italicFont, Brushes.Red, new PointF(10, 50));

            ///////////////////dymanic////////////////
            g.FillEllipse(Brushes.Black, x, 300, 100, 50);

        }
    }
}
