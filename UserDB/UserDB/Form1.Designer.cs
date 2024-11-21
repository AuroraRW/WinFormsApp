namespace UserDB
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
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            btnDelete = new Button();
            txtSearchName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtUserId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(756, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(806, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(636, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 46);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(458, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 204);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 139);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(199, 136);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 39);
            txtUserName.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(806, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(558, 60);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 39);
            txtSearchName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 64);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 64);
            label1.Name = "label1";
            label1.Size = new Size(39, 32);
            label1.TabIndex = 3;
            label1.Text = "Id:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(201, 61);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(200, 39);
            txtUserId.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 733);
            Controls.Add(label4);
            Controls.Add(txtSearchName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(txtUserId);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearchName;
        private Label label4;
        private Label label1;
        private TextBox txtUserId;
    }
}
