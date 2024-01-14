namespace GPA_Calculator
{
    partial class forgot
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
            label5 = new Label();
            txtid = new TextBox();
            lblstd = new Label();
            txtstd = new TextBox();
            lblpin = new Label();
            txtpin = new TextBox();
            button2 = new Button();
            btnQuit = new Button();
            btnback = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 96);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 44;
            label5.Text = "ID Number";
            // 
            // txtid
            // 
            txtid.Location = new Point(105, 93);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(213, 27);
            txtid.TabIndex = 43;
            // 
            // lblstd
            // 
            lblstd.AutoSize = true;
            lblstd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblstd.Location = new Point(51, 229);
            lblstd.Name = "lblstd";
            lblstd.Size = new Size(126, 20);
            lblstd.TabIndex = 38;
            lblstd.Text = "Student Number";
            // 
            // txtstd
            // 
            txtstd.Location = new Point(132, 262);
            txtstd.Margin = new Padding(3, 4, 3, 4);
            txtstd.Name = "txtstd";
            txtstd.Size = new Size(213, 27);
            txtstd.TabIndex = 37;
            // 
            // lblpin
            // 
            lblpin.AutoSize = true;
            lblpin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblpin.Location = new Point(376, 229);
            lblpin.Name = "lblpin";
            lblpin.Size = new Size(35, 20);
            lblpin.TabIndex = 36;
            lblpin.Text = "Pin:";
            // 
            // txtpin
            // 
            txtpin.Location = new Point(372, 262);
            txtpin.Margin = new Padding(3, 4, 3, 4);
            txtpin.Name = "txtpin";
            txtpin.Size = new Size(213, 27);
            txtpin.TabIndex = 35;
            // 
            // button2
            // 
            button2.Location = new Point(237, 177);
            button2.Name = "button2";
            button2.Size = new Size(174, 29);
            button2.TabIndex = 46;
            button2.Text = "Get";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(485, 12);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 45;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(392, 334);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 47;
            btnback.Text = "<<Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calc2;
            pictureBox1.Location = new Point(195, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 396);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // forgot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(btnback);
            Controls.Add(button2);
            Controls.Add(btnQuit);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(lblstd);
            Controls.Add(txtstd);
            Controls.Add(lblpin);
            Controls.Add(txtpin);
            Controls.Add(pictureBox1);
            Name = "forgot";
            Text = "GPA Wizard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtid;
        private Label lblstd;
        private TextBox txtstd;
        private Label lblpin;
        private TextBox txtpin;
        private Button button2;
        private Button btnQuit;
        private Button btnback;
        private PictureBox pictureBox1;
    }
}