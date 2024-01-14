using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Test
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool check()
        {
            if (txtid.Text == "" || txtid.Text.Length != 13)
            {
                txtid.Clear();
                MessageBox.Show("Invalid ID number\nID number must be 13 digits");
                txtid.Focus();
                return true;
            }
            else if (txtname.Text == "")
            {
                txtname.Clear();
                MessageBox.Show("Firstname can not be empty ");
                txtname.Focus();
                return true;
            }
            else if (txtsur.Text == "")
            {
                txtsur.Clear();
                MessageBox.Show("Lastname can not be empty");
                txtsur.Focus();
                return true;
            }
            else if (txtstd.Text == "")
            {
                txtstd.Clear();
                MessageBox.Show("Student Number can not be empty");
                txtstd.Focus();
                return true;

            }

            else if (txtpin.Text.Length != 5 || txtpin.Text != txtc.Text)
            {
                txtpin.Clear();
                txtc.Clear();
                txtpin.Focus();
                MessageBox.Show("Pin must be 5 digts and pins must match");
                return true;
            }
            return false;

        }

        public class stud
        {
            public string idno, studno, fname, lname;
            public string pin;
        }
        public static stud get = null;
        public void savetotextfile(string id, string std, string sur, string name, string pin)
        {
            StreamWriter write = new StreamWriter("Students.txt", true);
            write.WriteLine($"{std},{name},{sur},{id},{pin}");
            write.Close();
        }
        public bool exists()
        {
            try
            {
                if (File.Exists("Students.txt"))
                {
                    string[] lines = File.ReadAllLines("Students.txt");
                    foreach (string line in lines)
                    {
                        string[] get = line.Split(',');
                        if (txtid.Text == get[3] || txtstd.Text == get[0])
                            return true;




                    }
                }
            }
            catch (Exception e) { }
            return false;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            stud std = new stud();

            if (exists() == false && check() == false)
            {
                std.idno = txtid.Text;
                std.fname = txtname.Text;
                std.lname = txtsur.Text;
                std.pin = txtpin.Text;
                std.studno = txtstd.Text;
                savetotextfile(std.idno, std.studno, std.lname, std.fname, std.pin);
                MessageBox.Show("Details Saved");
                this.Close();
                AddModules Add = new AddModules();
                Add.Show();
                get = std;

            }
            else if (exists() == true)
            {
                txtid.Clear();
                txtname.Clear();
                txtsur.Clear();
                txtpin.Clear();
                txtstd.Clear();
                txtc.Clear();
                MessageBox.Show("Record Exits Already");
                lbllog.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m = new Login();

            m.Show();
        }

        private void lbllog_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}