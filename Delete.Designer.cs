namespace Test
{
    partial class Delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtcode = new TextBox();
            txtcredit = new TextBox();
            lbltitle = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(388, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 396);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(209, 141);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(291, 27);
            txtcode.TabIndex = 18;
            // 
            // txtcredit
            // 
            txtcredit.Location = new Point(209, 209);
            txtcredit.Name = "txtcredit";
            txtcredit.Size = new Size(279, 27);
            txtcredit.TabIndex = 19;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.Location = new Point(99, 53);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(305, 38);
            lbltitle.TabIndex = 20;
            lbltitle.Text = "Enter Modules Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 216);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 21;
            label2.Text = "Module Credits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 148);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 22;
            label3.Text = "Module Code";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(176, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(478, 31);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 24;
            btnBack.Text = "<<Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbltitle);
            Controls.Add(txtcredit);
            Controls.Add(txtcode);
            Controls.Add(pictureBox1);
            Name = "Delete";
            Text = "GPA Wizard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtcode;
        private TextBox txtcredit;
        private Label lbltitle;
        private Label label2;
        private Label label3;
        private Button btnDelete;
        private Button btnBack;
    }
}