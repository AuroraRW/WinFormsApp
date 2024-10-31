namespace DataBinding
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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtAge = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblName = new Label();
            lblAge = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            personBindingSource = new BindingSource(components);
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 39);
            txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 113);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(153, 39);
            txtAge.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(88, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 46);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 116);
            label2.Name = "label2";
            label2.Size = new Size(61, 32);
            label2.TabIndex = 5;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 38);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 105);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 7;
            label4.Text = "Age:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(417, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 32);
            lblName.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(427, 111);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(0, 32);
            lblAge.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 285);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(50, 379);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 164);
            listBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(480, 300);
            dataGridView1.TabIndex = 12;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(676, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 662);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label lblAge;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private BindingSource personBindingSource;
        private Button btnAdd;
    }
}
