namespace ControlsListBox
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
            lstFruit = new ListBox();
            btnAdd = new Button();
            txtNewFruit = new TextBox();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstFruit
            // 
            lstFruit.FormattingEnabled = true;
            lstFruit.Items.AddRange(new object[] { "apple", "orange", "banana" });
            lstFruit.Location = new Point(62, 83);
            lstFruit.Name = "lstFruit";
            lstFruit.Size = new Size(307, 164);
            lstFruit.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(386, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNewFruit
            // 
            txtNewFruit.Location = new Point(186, 275);
            txtNewFruit.Name = "txtNewFruit";
            txtNewFruit.Size = new Size(183, 39);
            txtNewFruit.TabIndex = 2;
            txtNewFruit.KeyDown += txtNewFruit_KeyDown;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(386, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.Location = new Point(62, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 4;
            label1.Text = "Fruit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 278);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 5;
            label2.Text = "New fruit:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 411);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(txtNewFruit);
            Controls.Add(btnAdd);
            Controls.Add(lstFruit);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Fruit list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstFruit;
        private Button btnAdd;
        private TextBox txtNewFruit;
        private Button btnDelete;
        private Label label1;
        private Label label2;
    }
}
