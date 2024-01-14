namespace Test
{
    partial class Main
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
            btnUpdate = new Button();
            btndelete = new Button();
            btnReport = new Button();
            btnQuit = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(286, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 396);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(121, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(298, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update Module";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(122, 166);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(297, 29);
            btndelete.TabIndex = 18;
            btndelete.Text = "Delete Module";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(122, 324);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(297, 29);
            btnReport.TabIndex = 19;
            btnReport.Text = "View Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(394, 449);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 20;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(122, 252);
            button1.Name = "button1";
            button1.Size = new Size(297, 29);
            button1.TabIndex = 21;
            button1.Text = "Add Module";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(49, 449);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 22;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 490);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnQuit);
            Controls.Add(btnReport);
            Controls.Add(btndelete);
            Controls.Add(btnUpdate);
            Controls.Add(pictureBox1);
            Name = "Main";
            Text = "GPA Wizard";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnUpdate;
        private Button btndelete;
        private Button btnReport;
        private Button btnQuit;
        private Button button1;
        private Button button2;
    }
}