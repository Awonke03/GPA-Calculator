namespace Test
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            Login log = new Login();
            Signup Sign = new Signup();

            pb1.Increment(1);
            pb2.Increment(1);
            lbl1.Text = $"Loading Files....{pb1.Value}%";
            if (pb1.Value == 100)
            {
                //this.Close();
                t1.Stop();

                DialogResult acc = MessageBox.Show("Have you saved your modules before??", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (acc == DialogResult.No)
                    Sign.Show();
                
                else if (acc == DialogResult.Yes)
                    log.Show();
                else
                    if (acc == DialogResult.Cancel)
                    Application.Exit();



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup m = new Signup();
            t1.Stop();
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Signup m = new Signup();
            t1.Stop();
            m.Show();
        }
    }
}