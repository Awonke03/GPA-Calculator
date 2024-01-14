namespace Test
{
    partial class Login
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
            btnlog = new Button();
            lblId = new Label();
            lblpin = new Label();
            txtid = new TextBox();
            txtpin = new TextBox();
            lbltitle = new Label();
            button1 = new Button();
            lblquit = new Button();
            pictureBox1 = new PictureBox();
            lblf = new Label();
            lblsign = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnlog
            // 
            btnlog.Location = new Point(43, 243);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(94, 29);
            btnlog.TabIndex = 0;
            btnlog.Text = "Log in";
            btnlog.UseVisualStyleBackColor = true;
            btnlog.Click += btnlog_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(7, 124);
            lblId.Name = "lblId";
            lblId.Size = new Size(149, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID/Student Number";
            lblId.Click += label1_Click;
            // 
            // lblpin
            // 
            lblpin.AutoSize = true;
            lblpin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblpin.Location = new Point(11, 171);
            lblpin.Name = "lblpin";
            lblpin.Size = new Size(99, 20);
            lblpin.TabIndex = 2;
            lblpin.Text = "Pin (5 digits)";
            lblpin.Click += label2_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(175, 124);
            txtid.Name = "txtid";
            txtid.Size = new Size(188, 27);
            txtid.TabIndex = 4;
            // 
            // txtpin
            // 
            txtpin.Location = new Point(165, 164);
            txtpin.Name = "txtpin";
            txtpin.Size = new Size(198, 27);
            txtpin.TabIndex = 6;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.Location = new Point(65, 29);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(223, 31);
            lbltitle.TabIndex = 3;
            lbltitle.Text = "Enter Log in Details";
            lbltitle.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(398, 279);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblquit
            // 
            lblquit.Location = new Point(249, 243);
            lblquit.Name = "lblquit";
            lblquit.Size = new Size(94, 29);
            lblquit.TabIndex = 8;
            lblquit.Text = "Quit";
            lblquit.UseVisualStyleBackColor = true;
            lblquit.Click += lblquit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(82, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 368);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // lblf
            // 
            lblf.AutoSize = true;
            lblf.ForeColor = Color.Crimson;
            lblf.Location = new Point(143, 275);
            lblf.Name = "lblf";
            lblf.Size = new Size(131, 20);
            lblf.TabIndex = 30;
            lblf.Text = "Forgot password ?";
            lblf.Visible = false;
            lblf.Click += lblf_Click;
            // 
            // lblsign
            // 
            lblsign.AutoSize = true;
            lblsign.ForeColor = SystemColors.HotTrack;
            lblsign.Location = new Point(165, 295);
            lblsign.Name = "lblsign";
            lblsign.Size = new Size(70, 20);
            lblsign.TabIndex = 31;
            lblsign.Text = "Sign Up...";
            lblsign.Visible = false;
            lblsign.Click += lblsign_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 321);
            Controls.Add(lblsign);
            Controls.Add(lblf);
            Controls.Add(lblquit);
            Controls.Add(button1);
            Controls.Add(txtpin);
            Controls.Add(txtid);
            Controls.Add(lbltitle);
            Controls.Add(lblpin);
            Controls.Add(lblId);
            Controls.Add(btnlog);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "GPA Wizard";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlog;
        private Label lblId;
        private Label lblpin;
        private TextBox txtid;
        private TextBox txtpin;
        private Label lbltitle;
        private Button button1;
        private Button lblquit;
        private PictureBox pictureBox1;
        private Label lblf;
        private Label lblsign;
    }
}