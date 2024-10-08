namespace ExtendedControl
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
            btnDefault = new Button();
            btnCustom = new CustomButton();
            txtDefault = new TextBox();
            dynamicTextBox1 = new DynamicTextBox();
            dynamicTextBox2 = new DynamicTextBox();
            SuspendLayout();
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(114, 65);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(150, 46);
            btnDefault.TabIndex = 0;
            btnDefault.Text = "Default";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            btnDefault.MouseEnter += btnDefault_MouseEnter;
            btnDefault.MouseLeave += btnDefault_MouseLeave;
            btnDefault.MouseHover += btnDefault_MouseHover;
            // 
            // btnCustom
            // 
            btnCustom.Location = new Point(399, 65);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(188, 46);
            btnCustom.TabIndex = 1;
            btnCustom.Text = "customButton";
            btnCustom.UseVisualStyleBackColor = true;
            // 
            // txtDefault
            // 
            txtDefault.CharacterCasing = CharacterCasing.Upper;
            txtDefault.Location = new Point(114, 233);
            txtDefault.MaxLength = 10;
            txtDefault.Name = "txtDefault";
            txtDefault.PlaceholderText = "Please input";
            txtDefault.Size = new Size(200, 39);
            txtDefault.TabIndex = 2;
            txtDefault.TextChanged += txtDefault_TextChanged;
            // 
            // dynamicTextBox1
            // 
            dynamicTextBox1.CharacterCasing = CharacterCasing.Upper;
            dynamicTextBox1.Location = new Point(399, 233);
            dynamicTextBox1.MaxLength = 10;
            dynamicTextBox1.Name = "dynamicTextBox1";
            dynamicTextBox1.PlaceholderText = "Please input";
            dynamicTextBox1.Size = new Size(200, 39);
            dynamicTextBox1.TabIndex = 3;
            // 
            // dynamicTextBox2
            // 
            dynamicTextBox2.CharacterCasing = CharacterCasing.Upper;
            dynamicTextBox2.Location = new Point(399, 330);
            dynamicTextBox2.MaxLength = 10;
            dynamicTextBox2.Name = "dynamicTextBox2";
            dynamicTextBox2.PlaceholderText = "Please input";
            dynamicTextBox2.Size = new Size(200, 39);
            dynamicTextBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dynamicTextBox2);
            Controls.Add(dynamicTextBox1);
            Controls.Add(txtDefault);
            Controls.Add(btnCustom);
            Controls.Add(btnDefault);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDefault;
        private CustomButton btnCustom;
        private TextBox txtDefault;
        private DynamicTextBox dynamicTextBox1;
        private DynamicTextBox dynamicTextBox2;
    }
}
