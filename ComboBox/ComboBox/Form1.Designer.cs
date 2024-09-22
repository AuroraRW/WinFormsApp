namespace ComboBox
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
            cboFruit = new System.Windows.Forms.ComboBox();
            lblTitle = new Label();
            lblSelected = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // cboFruit
            // 
            cboFruit.FormattingEnabled = true;
            cboFruit.Location = new Point(94, 31);
            cboFruit.Name = "cboFruit";
            cboFruit.Size = new Size(242, 40);
            cboFruit.TabIndex = 0;
            cboFruit.SelectedIndexChanged += cboFruit_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(405, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "You selected:";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(586, 39);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(102, 32);
            lblSelected.TabIndex = 2;
            lblSelected.Text = "Nothing";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(94, 127);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 355);
            Controls.Add(btnAdd);
            Controls.Add(lblSelected);
            Controls.Add(lblTitle);
            Controls.Add(cboFruit);
            Name = "Form1";
            Text = "Combo Box";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboFruit;
        private Label lblTitle;
        private Label lblSelected;
        private Button btnAdd;
    }
}
