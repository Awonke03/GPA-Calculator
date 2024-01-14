namespace GPA_Calculator
{
    partial class AddNewcs
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
            btnback = new Button();
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
            // btnback
            // 
            btnback.Location = new Point(359, 52);
            btnback.Margin = new Padding(3, 4, 3, 4);
            btnback.Name = "btnback";
            btnback.Size = new Size(86, 31);
            btnback.TabIndex = 42;
            btnback.Text = "<<Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(307, 421);
            btnDone.Margin = new Padding(3, 4, 3, 4);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(120, 40);
            btnDone.TabIndex = 41;
            btnDone.Text = "Done Adding";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(77, 421);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(125, 40);
            btnadd.TabIndex = 40;
            btnadd.Text = "Add Module";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // npdamark
            // 
            npdamark.Location = new Point(142, 172);
            npdamark.Margin = new Padding(3, 4, 3, 4);
            npdamark.Name = "npdamark";
            npdamark.Size = new Size(167, 27);
            npdamark.TabIndex = 39;
            // 
            // txtcredit
            // 
            txtcredit.Location = new Point(142, 235);
            txtcredit.Margin = new Padding(3, 4, 3, 4);
            txtcredit.Name = "txtcredit";
            txtcredit.Size = new Size(166, 27);
            txtcredit.TabIndex = 38;
            // 
            // txtsm
            // 
            txtsm.Location = new Point(142, 353);
            txtsm.Margin = new Padding(3, 4, 3, 4);
            txtsm.Name = "txtsm";
            txtsm.Size = new Size(166, 27);
            txtsm.TabIndex = 37;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(142, 296);
            txtyear.Margin = new Padding(3, 4, 3, 4);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(166, 27);
            txtyear.TabIndex = 36;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(142, 108);
            txtcode.Margin = new Padding(3, 4, 3, 4);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(166, 27);
            txtcode.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 108);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 34;
            label6.Text = "Module Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 175);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 33;
            label5.Text = "Final Mark (%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 235);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 32;
            label4.Text = "Module Credit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 296);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 31;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 353);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 30;
            label2.Text = "Semester";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 12);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 29;
            label1.Text = "Add Module";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calc2;
            pictureBox1.Location = new Point(186, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 368);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // AddNewcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 500);
            Controls.Add(btnback);
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
            Name = "AddNewcs";
            Text = "GPA Wizard";
            ((System.ComponentModel.ISupportInitialize)npdamark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
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