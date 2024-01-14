namespace Test
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtid = new TextBox();
            txtstd = new TextBox();
            txtname = new TextBox();
            txtsur = new TextBox();
            txtpin = new TextBox();
            btnSignUp = new Button();
            btnQuit = new Button();
            txtc = new TextBox();
            pin = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lbllog = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 325);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Pin (5 digits)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 271);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 207);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Firstname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(78, 152);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 4;
            label5.Text = "Student Number";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(78, 101);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "ID number";
            // 
            // txtid
            // 
            txtid.Location = new Point(227, 101);
            txtid.Name = "txtid";
            txtid.Size = new Size(185, 27);
            txtid.TabIndex = 6;
            txtid.TextChanged += textBox1_TextChanged;
            // 
            // txtstd
            // 
            txtstd.Location = new Point(227, 152);
            txtstd.Name = "txtstd";
            txtstd.Size = new Size(181, 27);
            txtstd.TabIndex = 7;
            // 
            // txtname
            // 
            txtname.Location = new Point(227, 207);
            txtname.Name = "txtname";
            txtname.Size = new Size(181, 27);
            txtname.TabIndex = 8;
            // 
            // txtsur
            // 
            txtsur.Location = new Point(227, 271);
            txtsur.Name = "txtsur";
            txtsur.Size = new Size(181, 27);
            txtsur.TabIndex = 9;
            // 
            // txtpin
            // 
            txtpin.Location = new Point(227, 325);
            txtpin.Name = "txtpin";
            txtpin.PasswordChar = '*';
            txtpin.Size = new Size(181, 27);
            txtpin.TabIndex = 10;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(215, 457);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(458, 55);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 12;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // txtc
            // 
            txtc.Location = new Point(227, 381);
            txtc.Name = "txtc";
            txtc.PasswordChar = '*';
            txtc.Size = new Size(185, 27);
            txtc.TabIndex = 13;
            // 
            // pin
            // 
            pin.AutoSize = true;
            pin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pin.Location = new Point(78, 381);
            pin.Name = "pin";
            pin.Size = new Size(97, 20);
            pin.TabIndex = 14;
            pin.Text = "Confirm Pin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(261, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 396);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(78, 455);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "<<Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbllog
            // 
            lbllog.AutoSize = true;
            lbllog.ForeColor = SystemColors.HotTrack;
            lbllog.Location = new Point(362, 466);
            lbllog.Name = "lbllog";
            lbllog.Size = new Size(59, 20);
            lbllog.TabIndex = 17;
            lbllog.Text = "Log in...";
            lbllog.Visible = false;
            lbllog.Click += lbllog_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 499);
            Controls.Add(lbllog);
            Controls.Add(button1);
            Controls.Add(pin);
            Controls.Add(txtc);
            Controls.Add(btnQuit);
            Controls.Add(btnSignUp);
            Controls.Add(txtpin);
            Controls.Add(txtsur);
            Controls.Add(txtname);
            Controls.Add(txtstd);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Signup";
            Text = "GPA Wizard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtid;
        private TextBox txtstd;
        private TextBox txtname;
        private TextBox txtsur;
        private TextBox txtpin;
        private Button btnSignUp;
        private Button btnQuit;
        private TextBox txtc;
        private Label pin;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lbllog;
    }
}