namespace Test
{
    partial class UpdateM
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
            btnBack = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            label2 = new Label();
            lbltitle = new Label();
            txtcredit = new TextBox();
            txtcode = new TextBox();
            rdbmark = new RadioButton();
            rdbyear = new RadioButton();
            rdbsm = new RadioButton();
            rdbcredits = new RadioButton();
            groupBox1 = new GroupBox();
            nudval = new NumericUpDown();
            lblValue = new Label();
            txtval = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudval).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(284, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 396);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(492, 36);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 31;
            btnBack.Text = "<<Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(171, 475);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 29);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 153);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 29;
            label3.Text = "Module Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 221);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 28;
            label2.Text = "Module Credits";
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.Location = new Point(113, 58);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(305, 38);
            lbltitle.TabIndex = 27;
            lbltitle.Text = "Enter Modules Details";
            // 
            // txtcredit
            // 
            txtcredit.Location = new Point(223, 218);
            txtcredit.Name = "txtcredit";
            txtcredit.Size = new Size(279, 27);
            txtcredit.TabIndex = 26;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(223, 146);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(291, 27);
            txtcode.TabIndex = 25;
            // 
            // rdbmark
            // 
            rdbmark.AutoSize = true;
            rdbmark.Location = new Point(284, 314);
            rdbmark.Name = "rdbmark";
            rdbmark.Size = new Size(100, 24);
            rdbmark.TabIndex = 32;
            rdbmark.TabStop = true;
            rdbmark.Text = "Final_Mark";
            rdbmark.UseVisualStyleBackColor = true;
            rdbmark.CheckedChanged += rdbmark_CheckedChanged;
            rdbmark.Click += rdbmark_Click;
            // 
            // rdbyear
            // 
            rdbyear.AutoSize = true;
            rdbyear.Location = new Point(296, 353);
            rdbyear.Name = "rdbyear";
            rdbyear.Size = new Size(58, 24);
            rdbyear.TabIndex = 33;
            rdbyear.TabStop = true;
            rdbyear.Text = "Year";
            rdbyear.UseVisualStyleBackColor = true;
            rdbyear.CheckedChanged += rdbyear_CheckedChanged;
            rdbyear.Click += rdbyear_Click;
            // 
            // rdbsm
            // 
            rdbsm.AutoSize = true;
            rdbsm.Location = new Point(150, 314);
            rdbsm.Name = "rdbsm";
            rdbsm.Size = new Size(91, 24);
            rdbsm.TabIndex = 34;
            rdbsm.TabStop = true;
            rdbsm.Text = "Semester";
            rdbsm.UseVisualStyleBackColor = true;
            rdbsm.CheckedChanged += rdbsm_CheckedChanged;
            rdbsm.Click += rdbsm_Click;
            // 
            // rdbcredits
            // 
            rdbcredits.AutoSize = true;
            rdbcredits.Location = new Point(150, 353);
            rdbcredits.Name = "rdbcredits";
            rdbcredits.Size = new Size(76, 24);
            rdbcredits.TabIndex = 35;
            rdbcredits.TabStop = true;
            rdbcredits.Text = "Credits";
            rdbcredits.UseVisualStyleBackColor = true;
            rdbcredits.CheckedChanged += rdbcredits_CheckedChanged;
            rdbcredits.Click += rdbcredits_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(141, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 30);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose what you want to Update:";
            // 
            // nudval
            // 
            nudval.Location = new Point(171, 422);
            nudval.Name = "nudval";
            nudval.Size = new Size(150, 27);
            nudval.TabIndex = 37;
            nudval.Visible = false;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblValue.Location = new Point(41, 424);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(88, 20);
            lblValue.TabIndex = 38;
            lblValue.Text = "Enter Value";
            lblValue.Visible = false;
            // 
            // txtval
            // 
            txtval.Location = new Point(171, 422);
            txtval.Name = "txtval";
            txtval.Size = new Size(150, 27);
            txtval.TabIndex = 39;
            txtval.Visible = false;
            // 
            // UpdateM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 600);
            Controls.Add(rdbsm);
            Controls.Add(rdbcredits);
            Controls.Add(rdbyear);
            Controls.Add(txtval);
            Controls.Add(lblValue);
            Controls.Add(nudval);
            Controls.Add(rdbmark);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbltitle);
            Controls.Add(txtcredit);
            Controls.Add(txtcode);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateM";
            Text = "GPA Wizard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBack;
        private Button btnUpdate;
        private Label label3;
        private Label label2;
        private Label lbltitle;
        private TextBox txtcredit;
        private TextBox txtcode;
        private RadioButton rdbmark;
        private RadioButton rdbyear;
        private RadioButton rdbsm;
        private RadioButton rdbcredits;
        private GroupBox groupBox1;
        private NumericUpDown nudval;
        private Label lblValue;
        private TextBox txtval;
    }
}