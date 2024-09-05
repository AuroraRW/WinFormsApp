namespace Stop_Watch
{
    partial class FormStopWatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart = new Button();
            buttonStop = new Button();
            buttonExit = new Button();
            txtStart = new TextBox();
            txtStop = new TextBox();
            txtElapsed = new TextBox();
            labelStart = new Label();
            labelStop = new Label();
            labelElapsed = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(35, 33);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(150, 46);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "&Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(35, 111);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(150, 46);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "S&top";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(35, 193);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 46);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "&Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(524, 40);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(200, 39);
            txtStart.TabIndex = 3;
            // 
            // txtStop
            // 
            txtStop.Location = new Point(524, 118);
            txtStop.Name = "txtStop";
            txtStop.Size = new Size(200, 39);
            txtStop.TabIndex = 4;
            // 
            // txtElapsed
            // 
            txtElapsed.Location = new Point(524, 200);
            txtElapsed.Name = "txtElapsed";
            txtElapsed.Size = new Size(200, 39);
            txtElapsed.TabIndex = 5;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(363, 47);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(122, 32);
            labelStart.TabIndex = 6;
            labelStart.Text = "Start Time";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(363, 125);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(122, 32);
            labelStop.TabIndex = 7;
            labelStop.Text = "Stop Time";
            // 
            // labelElapsed
            // 
            labelElapsed.AutoSize = true;
            labelElapsed.Location = new Point(207, 207);
            labelElapsed.Name = "labelElapsed";
            labelElapsed.Size = new Size(278, 32);
            labelElapsed.TabIndex = 8;
            labelElapsed.Text = "Elapsed Time in Seconds";
            // 
            // FormStopWatch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 298);
            Controls.Add(labelElapsed);
            Controls.Add(labelStop);
            Controls.Add(labelStart);
            Controls.Add(txtElapsed);
            Controls.Add(txtStop);
            Controls.Add(txtStart);
            Controls.Add(buttonExit);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Name = "FormStopWatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stop Watch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Button buttonExit;
        private TextBox txtStart;
        private TextBox txtStop;
        private TextBox txtElapsed;
        private Label labelStart;
        private Label labelStop;
        private Label labelElapsed;
    }
}
