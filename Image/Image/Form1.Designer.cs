namespace Image
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
            picShow = new PictureBox();
            btnPic = new Button();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            SuspendLayout();
            // 
            // picShow
            // 
            picShow.Location = new Point(12, 98);
            picShow.Name = "picShow";
            picShow.Size = new Size(526, 597);
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;
            picShow.TabIndex = 0;
            picShow.TabStop = false;
            // 
            // btnPic
            // 
            btnPic.Location = new Point(12, 24);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(150, 46);
            btnPic.TabIndex = 1;
            btnPic.Text = "Show Picture";
            btnPic.UseVisualStyleBackColor = true;
            btnPic.Click += btnPic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 707);
            Controls.Add(btnPic);
            Controls.Add(picShow);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picShow;
        private Button btnPic;
    }
}
