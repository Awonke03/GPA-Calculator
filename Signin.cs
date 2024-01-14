using GPA_Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static bool k;
        private void Form2_Load(object sender, EventArgs e)
        {
            k = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblquit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        public class stud
        {
            public string idno, studno, fname, lname;
            public string pin;
        }
        public static stud gets = null;


        private void btnlog_Click(object sender, EventArgs e)
        {

            string ID = txtid.Text;
            string pin = txtpin.Text;
            bool bfound = false;
            try
            {
                String[] Lines = File.ReadAllLines("Students.txt");
                foreach (String Line in Lines)
                {
                    string[] get = Line.Split(",");
                    if ((get[0] == ID || get[3] == ID) && get[4] == pin)
                    {
                        stud stu = new stud();
                        stu.idno = get[3];
                        stu.pin = get[4];
                        stu.fname = get[1];
                        stu.lname = get[2];
                        stu.studno = get[0];
                        gets = stu;
                        bfound = true;
                        this.Hide();

                        MessageBox.Show("Access Granted");
                        MessageBox.Show($"Welcome {get[1]} {get[2]}");
                        Main m = new Main();
                        m.Show();



                    }
                }
                if (bfound == false)
                {
                    MessageBox.Show("Access Denied\nInvalid Details");
                    lblf.Visible = true;
                    lblsign.Visible = true;
                }


            }
            catch (Exception) { }
        }

        private void lblf_Click(object sender, EventArgs e)
        {
            this.Close();
           forgot fort =new forgot();
            fort.Show();
        }

        private void lblsign_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup signup = new Signup();
            signup.Show();
        }
    }
}
