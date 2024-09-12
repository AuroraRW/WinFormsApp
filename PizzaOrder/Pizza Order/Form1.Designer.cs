namespace Pizza_Order
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
            rdoSmall = new RadioButton();
            rdoMedium = new RadioButton();
            rdoLarge = new RadioButton();
            rdoPickup = new RadioButton();
            rdoDelivery = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            chkCheese = new CheckBox();
            chkBacon = new CheckBox();
            chkMushrooms = new CheckBox();
            chkPeppers = new CheckBox();
            btnOK = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rdoSmall
            // 
            rdoSmall.AutoSize = true;
            rdoSmall.Location = new Point(42, 38);
            rdoSmall.Name = "rdoSmall";
            rdoSmall.Size = new Size(136, 36);
            rdoSmall.TabIndex = 0;
            rdoSmall.Text = "Small $5";
            rdoSmall.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(41, 88);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(168, 36);
            rdoMedium.TabIndex = 1;
            rdoMedium.Text = "Medium $8";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoLarge
            // 
            rdoLarge.AutoSize = true;
            rdoLarge.Location = new Point(41, 142);
            rdoLarge.Name = "rdoLarge";
            rdoLarge.Size = new Size(149, 36);
            rdoLarge.TabIndex = 2;
            rdoLarge.Text = "Large $10";
            rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(45, 58);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(115, 36);
            rdoPickup.TabIndex = 3;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(45, 112);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(165, 36);
            rdoDelivery.TabIndex = 4;
            rdoDelivery.Text = "Delivery $5";
            rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSmall);
            groupBox1.Controls.Add(rdoMedium);
            groupBox1.Controls.Add(rdoLarge);
            groupBox1.Location = new Point(62, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 200);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizza Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoPickup);
            groupBox2.Controls.Add(rdoDelivery);
            groupBox2.Location = new Point(62, 337);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 200);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delivery Method";
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(439, 155);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(157, 36);
            chkCheese.TabIndex = 7;
            chkCheese.Text = "Cheese $5";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(439, 218);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(157, 36);
            chkBacon.TabIndex = 8;
            chkBacon.Text = "Bacon $10";
            chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(439, 277);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(206, 36);
            chkMushrooms.TabIndex = 9;
            chkMushrooms.Text = "Mushrooms $8";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            chkPeppers.AutoSize = true;
            chkPeppers.Location = new Point(439, 340);
            chkPeppers.Name = "chkPeppers";
            chkPeppers.Size = new Size(163, 36);
            chkPeppers.TabIndex = 10;
            chkPeppers.Text = "Peppers $3";
            chkPeppers.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(439, 439);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 46);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 33);
            label1.Name = "label1";
            label1.Size = new Size(364, 38);
            label1.TabIndex = 12;
            label1.Text = "Base Pizza Price $10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 13;
            label2.Text = "Toppings:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 577);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(chkPeppers);
            Controls.Add(chkMushrooms);
            Controls.Add(chkBacon);
            Controls.Add(chkCheese);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizza Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoSmall;
        private RadioButton rdoMedium;
        private RadioButton rdoLarge;
        private RadioButton rdoPickup;
        private RadioButton rdoDelivery;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkCheese;
        private CheckBox chkBacon;
        private CheckBox chkMushrooms;
        private CheckBox chkPeppers;
        private Button btnOK;
        private Label label1;
        private Label label2;
    }
}
