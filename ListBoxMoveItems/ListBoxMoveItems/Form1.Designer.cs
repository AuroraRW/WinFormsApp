namespace ListBoxMoveItems
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
            lstLeft = new ListBox();
            lstRight = new ListBox();
            btnMove = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstLeft
            // 
            lstLeft.FormattingEnabled = true;
            lstLeft.Location = new Point(46, 80);
            lstLeft.Name = "lstLeft";
            lstLeft.SelectionMode = SelectionMode.MultiSimple;
            lstLeft.Size = new Size(203, 292);
            lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            lstRight.FormattingEnabled = true;
            lstRight.Location = new Point(316, 80);
            lstRight.Name = "lstRight";
            lstRight.Size = new Size(202, 292);
            lstRight.TabIndex = 1;
            lstRight.DoubleClick += lstRight_DoubleClick;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(212, 387);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(152, 47);
            btnMove.TabIndex = 2;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 23);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 3;
            label1.Text = "Healthy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 23);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 4;
            label2.Text = "Unhealthy:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 556);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMove);
            Controls.Add(lstRight);
            Controls.Add(lstLeft);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Group Food";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLeft;
        private ListBox lstRight;
        private Button btnMove;
        private Label label1;
        private Label label2;
    }
}
