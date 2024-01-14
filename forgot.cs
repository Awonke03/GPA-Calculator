using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace GPA_Calculator
{
    public partial class forgot : Form
    {
        public forgot()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text;

            bool bfound = false;
            try
            {
                String[] Lines = File.ReadAllLines("Students.txt");
                foreach (String Line in Lines)
                {
                    string[] get = Line.Split(",");
                    if (get[3] == ID)
                    {
                        bfound = true;

                        txtpin.Text = get[4];

                        txtstd.Text = get[0];





                    }
                }
                if (bfound == false)
                {
                    MessageBox.Show("Access Denied\nInvalid Details");

                }


            }
            catch (Exception) { }
        }


    }
}
