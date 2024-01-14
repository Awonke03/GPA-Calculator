namespace Test
{
    partial class Welcome
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
            components = new System.ComponentModel.Container();
            pb1 = new ProgressBar();
            pb2 = new ProgressBar();
            t1 = new System.Windows.Forms.Timer(components);
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pb1
            // 
            pb1.Location = new Point(11, 25);
            pb1.Name = "pb1";
            pb1.Size = new Size(459, 24);
            pb1.TabIndex = 0;
            // 
            // pb2
            // 
            pb2.Location = new Point(11, 277);
            pb2.Name = "pb2";
            pb2.Size = new Size(459, 21);
            pb2.TabIndex = 1;
            // 
            // t1
            // 
            t1.Tick += t1_Tick;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(101, 213);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 20);
            lbl1.TabIndex = 2;
            lbl1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Black;
            lbl2.Location = new Point(37, 76);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(345, 35);
            lbl2.TabIndex = 3;
            lbl2.Text = "GPA Wizard at Your Service!";
            lbl2.Click += label1_Click_1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(219, 148);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(240, 35);
            lbl3.TabIndex = 4;
            lbl3.Text = "Elevate Your Grades,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GPA_Calculator.Properties.Resources.calc2;
            pictureBox1.Location = new Point(11, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 263);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 307);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.AppStarting;
            Location = new Point(100, 75);
            Name = "Welcome";
            Text = "GPA Calculator";
            Load += Form1_Load;
            Shown += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pb1;
        private ProgressBar pb2;
        private System.Windows.Forms.Timer t1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private PictureBox pictureBox1;
    }
}