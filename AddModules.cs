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
    public partial class AddModules : Form
    {
        public AddModules()
        {
            InitializeComponent();
        }
        public class modules
        {
            public string module_code, year, semester;
            public double credits;
            public int final_mark;

            public modules next;
        }
        public static modules head, aux = null;

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string stud = Signup.get.studno;

                StreamWriter mine = new StreamWriter("Marks.txt", true);
                aux = head;
                do
                {
                    mine.WriteLine($"{aux.module_code},{aux.final_mark},{aux.credits},{aux.year},{aux.semester},{stud}");
                    aux = aux.next;
                } while (aux != null);
                mine.Close();
                this.Close();
                Login Report = new Login();
                Report.Show();
            }
            catch { }



        }
        public bool check()
        {
            try
            {
                if (txtcode.Text == "")
                {
                    txtcode.Focus();
                    MessageBox.Show("Module Code can not be empty");
                    return true;
                }
                else if (txtyear.Text == "")
                {
                    txtyear.Clear();
                    txtyear.Focus();
                    MessageBox.Show("Year of module is invalid");
                    return true;

                }
                else if (txtcredit.Text == "")
                {
                    txtcredit.Clear();
                    txtcredit.Focus();
                    MessageBox.Show("Module Credit Invalid");
                    return true;

                }
                else if (txtsm.Text == "")
                {
                    txtsm.Clear();
                    txtsm.Focus();
                    MessageBox.Show("Semester Invalid");
                    return true;

                }
                else if (txtyear.Text != "")
                    if (Convert.ToDouble(txtyear.Text) <= 0)
                    {
                        txtyear.Clear();
                        txtyear.Focus();
                        MessageBox.Show("Year of module is invalid");
                        return true;

                    }
                    else if (txtcredit.Text != "")
                        if (Convert.ToDouble(txtcredit.Text) < 0)
                        {
                            txtcredit.Clear();
                            txtcredit.Focus();
                            MessageBox.Show("Module Credit Invalid");
                            return true;

                        }
                        else if (txtsm.Text == "")
                        {
                            if (Convert.ToDouble(txtsm.Text) < 0)
                            {
                                txtsm.Clear();
                                txtsm.Focus();
                                MessageBox.Show("Semester Invalid");
                                return true;
                            }

                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID DETAILS!!!");
            }








            return false;
        }
        public bool Exists()
        {
            try
            {
                if (head != null)
                {
                    aux = head;


                    if (aux.module_code != null && aux.module_code.Equals(txtcode.Text))
                    {
                        return true;
                    }

                    while (aux.next != null)
                    {
                        aux = aux.next;

                        if (aux.module_code != null && aux.module_code.Equals(txtcode.Text))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (Exists() == false && check() == false)
            {
                modules md = new modules();
                md.module_code = txtcode.Text;
                md.final_mark = Convert.ToInt32(npdamark.Value);
                if (txtcredit.Text.Contains(","))
                    md.credits = Convert.ToDouble(txtcredit.Text);
                else
                    md.credits = Convert.ToDouble(txtcredit.Text + ",0");

                md.semester = txtsm.Text;
                md.year = txtyear.Text;
                md.next = null;
                if (head == null)
                    head = md;
                else
                    aux.next = md;
                aux = md;
                MessageBox.Show($"{md.module_code} has been added");
                txtcode.Clear();
                txtcredit.Clear();
                txtsm.Clear();
                txtyear.Clear();
                txtsm.Clear();
                npdamark.Value = 0;

            }
            else if (Exists() == true)
            {
                MessageBox.Show($"{txtcode.Text} already exists");
                txtcode.Clear();
                txtcredit.Clear();
                txtsm.Clear();
                txtyear.Clear();
                txtsm.Clear();
                npdamark.Value = 0;

            }



        }

        private void txtcredit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
