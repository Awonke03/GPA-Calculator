namespace Test
{
    partial class AddModules
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
            btnQuit = new Button();
            btnDone = new Button();
            btnadd = new Button();
            npdamark = new NumericUpDown();
            txtcredit = new TextBox();
            txtsm = new TextBox();
            txtyear = new TextBox();
            txtcode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)npdamark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(357, 83);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(86, 31);
            btnQuit.TabIndex = 27;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(305, 452);
            btnDone.Margin = new Padding(3, 4, 3, 4);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(120, 40);
            btnDone.TabIndex = 26;
            btnDone.Text = "Done Adding";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += button2_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(75, 452);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(125, 40);
            btnadd.TabIndex = 25;
            btnadd.Text = "Add Module";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // npdamark
            // 
            npdamark.Location = new Point(140, 203);
            npdamark.Margin = new Padding(3, 4, 3, 4);
            npdamark.Name = "npdamark";
            npdamark.Size = new Size(167, 27);
            npdamark.TabIndex = 24;
            // 
            // txtcredit
            // 
            txtcredit.Location = new Point(140, 266);
            txtcredit.Margin = new Padding(3, 4, 3, 4);
            txtcredit.Name = "txtcredit";
            txtcredit.Size = new Size(166, 27);
            txtcredit.TabIndex = 23;
            txtcredit.TextChanged += txtcredit_TextChanged;
            // 
            // txtsm
            // 
            txtsm.Location = new Point(140, 384);
            txtsm.Margin = new Padding(3, 4, 3, 4);
            txtsm.Name = "txtsm";
            txtsm.Size = new Size(166, 27);
            txtsm.TabIndex = 22;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(140, 327);
            txtyear.Margin = new Padding(3, 4, 3, 4);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(166, 27);
            txtyear.TabIndex = 21;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(140, 139);
            txtcode.Margin = new Padding(3, 4, 3, 4);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(166, 27);
            txtcode.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 139);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 19;
            label6.Text = "Module Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 206);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 18;
            label5.Text = "Final Mark (%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 266);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 17;
            label4.Text = "Module Credit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 327);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 16;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 384);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 15;
            label2.Text = "Semester";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 43);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 14;
            label1.Text = "Add Module";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(184, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 368);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // AddModules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 521);
            Controls.Add(btnQuit);
            Controls.Add(btnDone);
            Controls.Add(btnadd);
            Controls.Add(npdamark);
            Controls.Add(txtcredit);
            Controls.Add(txtsm);
            Controls.Add(txtyear);
            Controls.Add(txtcode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddModules";
            Text = "GPA Wizard";
            ((System.ComponentModel.ISupportInitialize)npdamark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuit;
        private Button btnDone;
        private Button btnadd;
        private NumericUpDown npdamark;
        private TextBox txtcredit;
        private TextBox txtsm;
        private TextBox txtyear;
        private TextBox txtcode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}