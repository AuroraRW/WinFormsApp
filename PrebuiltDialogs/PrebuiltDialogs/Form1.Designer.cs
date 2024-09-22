namespace PrebuiltDialogs
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
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            btnColor = new Button();
            cdChangeColor = new ColorDialog();
            btnFont = new Button();
            rtxtFileContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(604, 127);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(150, 46);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Open file";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(604, 219);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(150, 46);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "Save file";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(75, 307);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(411, 213);
            btnColor.TabIndex = 3;
            btnColor.Text = "Change Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // cdChangeColor
            // 
            cdChangeColor.FullOpen = true;
            cdChangeColor.ShowHelp = true;
            cdChangeColor.HelpRequest += cdChangeColor_HelpRequest;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(49, 31);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(108, 46);
            btnFont.TabIndex = 4;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // rtxtFileContent
            // 
            rtxtFileContent.Location = new Point(49, 99);
            rtxtFileContent.Name = "rtxtFileContent";
            rtxtFileContent.Size = new Size(512, 192);
            rtxtFileContent.TabIndex = 5;
            rtxtFileContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 548);
            Controls.Add(rtxtFileContent);
            Controls.Add(btnFont);
            Controls.Add(btnColor);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenFile;
        private Button btnSaveFile;
        private Button btnColor;
        private ColorDialog cdChangeColor;
        private Button btnFont;
        private RichTextBox rtxtFileContent;
    }
}
