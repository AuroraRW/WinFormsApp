namespace Hello
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
            btn = new Button();
            SuspendLayout();
            // 
            // btn
            // 
            btn.ForeColor = Color.Coral;
            btn.Location = new Point(330, 128);
            btn.Name = "btn";
            btn.Size = new Size(334, 149);
            btn.TabIndex = 0;
            btn.Text = "Show message";
            btn.UseVisualStyleBackColor = true;
            btn.Click += Hello;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 615);
            Controls.Add(btn);
            Name = "Form1";
            Text = "F";
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
    }
}
