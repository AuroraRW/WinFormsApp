namespace Sound
{
    partial class Form1
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
            chkPlay = new CheckBox();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // chkPlay
            // 
            chkPlay.Appearance = Appearance.Button;
            chkPlay.Location = new Point(184, 81);
            chkPlay.Name = "chkPlay";
            chkPlay.Size = new Size(400, 123);
            chkPlay.TabIndex = 0;
            chkPlay.Text = "Play";
            chkPlay.TextAlign = ContentAlignment.MiddleCenter;
            chkPlay.UseVisualStyleBackColor = true;
            chkPlay.CheckedChanged += chkPlay_CheckedChanged;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(187, 293);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(397, 118);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(btnPlay);
            Controls.Add(chkPlay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkPlay;
        private Button btnPlay;
    }
}
