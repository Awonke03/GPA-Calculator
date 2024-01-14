namespace GPA_Calculator
{
    partial class LogReport
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
            txtgrade = new TextBox();
            btnQuit = new Button();
            lbltitle = new Label();
            lblgpa = new Label();
            txtGpa = new TextBox();
            rtbout2 = new RichTextBox();
            rtbout = new RichTextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtlname = new TextBox();
            label3 = new Label();
            txtfname = new TextBox();
            label4 = new Label();
            txtstud = new TextBox();
            label5 = new Label();
            txtid = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(759, 468);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 25;
            label1.Text = "Overall Grade";
            // 
            // txtgrade
            // 
            txtgrade.Location = new Point(891, 457);
            txtgrade.Margin = new Padding(3, 4, 3, 4);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(213, 27);
            txtgrade.TabIndex = 24;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(903, 36);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 23;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.Location = new Point(44, 16);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(178, 37);
            lbltitle.TabIndex = 22;
            lbltitle.Text = "GPA Reports";
            // 
            // lblgpa
            // 
            lblgpa.AutoSize = true;
            lblgpa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblgpa.Location = new Point(742, 422);
            lblgpa.Name = "lblgpa";
            lblgpa.Size = new Size(121, 20);
            lblgpa.TabIndex = 21;
            lblgpa.Text = "Overall GPA (%)";
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(891, 415);
            txtGpa.Margin = new Padding(3, 4, 3, 4);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(213, 27);
            txtGpa.TabIndex = 20;
            // 
            // rtbout2
            // 
            rtbout2.Location = new Point(853, 114);
            rtbout2.Margin = new Padding(3, 4, 3, 4);
            rtbout2.Name = "rtbout2";
            rtbout2.Size = new Size(288, 269);
            rtbout2.TabIndex = 19;
            rtbout2.Text = "";
            // 
            // rtbout
            // 
            rtbout.Location = new Point(30, 89);
            rtbout.Margin = new Padding(3, 4, 3, 4);
            rtbout.Name = "rtbout";
            rtbout.Size = new Size(805, 309);
            rtbout.TabIndex = 18;
            rtbout.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calc2;
            pictureBox1.Location = new Point(725, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 396);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 464);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 30;
            label2.Text = "LastName";
            // 
            // txtlname
            // 
            txtlname.Location = new Point(155, 457);
            txtlname.Margin = new Padding(3, 4, 3, 4);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(213, 27);
            txtlname.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 429);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 28;
            label3.Text = "FirstName";
            // 
            // txtfname
            // 
            txtfname.Location = new Point(155, 422);
            txtfname.Margin = new Padding(3, 4, 3, 4);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(213, 27);
            txtfname.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(391, 468);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 34;
            label4.Text = "Student Number";
            // 
            // txtstud
            // 
            txtstud.Location = new Point(523, 461);
            txtstud.Margin = new Padding(3, 4, 3, 4);
            txtstud.Name = "txtstud";
            txtstud.Size = new Size(213, 27);
            txtstud.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(391, 433);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 32;
            label5.Text = "ID Number";
            // 
            // txtid
            // 
            txtid.Location = new Point(523, 426);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(213, 27);
            txtid.TabIndex = 31;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(580, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 35;
            btnBack.Text = "<<Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // LogReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 510);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(txtstud);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(txtlname);
            Controls.Add(label3);
            Controls.Add(txtfname);
            Controls.Add(label1);
            Controls.Add(txtgrade);
            Controls.Add(btnQuit);
            Controls.Add(lbltitle);
            Controls.Add(lblgpa);
            Controls.Add(txtGpa);
            Controls.Add(rtbout2);
            Controls.Add(rtbout);
            Controls.Add(pictureBox1);
            Name = "LogReport";
            Text = "GPA Wizard";
            Load += LogReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtgrade;
        private Button btnQuit;
        private Label lbltitle;
        private Label lblgpa;
        private TextBox txtGpa;
        private RichTextBox rtbout2;
        private RichTextBox rtbout;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtlname;
        private Label label3;
        private TextBox txtfname;
        private Label label4;
        private TextBox txtstud;
        private Label label5;
        private TextBox txtid;
        private Button btnBack;
    }
}