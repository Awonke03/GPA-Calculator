using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class UpdateM : Form
    {
        public UpdateM()
        {
            InitializeComponent();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rdbcredits_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void rdbmark_CheckedChanged(object sender, EventArgs e)
        {



        }
        Main.modules aux, head = null;
        public void updateTextfile()
        {
            StreamWriter write = new StreamWriter("Marks.txt");
            aux = Main.head;

            while (aux != null)
            {
                write.WriteLine($"{aux.module_code},{aux.final_mark},{aux.credits},{aux.year},{aux.semester},{Login.gets.studno}");
                aux = aux.next;
            }
            write.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


            aux = Main.head;
            bool found = false;
            while (aux != null)
            {
                if ((aux.module_code == txtcode.Text) && (aux.credits == Convert.ToDouble(txtcredit.Text)))
                {
                    found = true;
                    if (rdbmark.Checked == true)
                    {
                        aux.final_mark = Convert.ToInt32(nudval.Value);
                    }
                    else if (rdbcredits.Checked == true)
                    {
                        aux.credits = Convert.ToDouble(txtval.Text);

                    }
                    else if (rdbyear.Checked == true) aux.year = Convert.ToString(nudval.Value);
                    else if (rdbcredits.Checked == true) aux.semester = Convert.ToString(nudval.Value);


                }
                aux = aux.next;

            }
            if (found == true)
            {
                updateTextfile();
                MessageBox.Show($"{txtcode.Text} Succefully Updated");
            }
            else
            {
                MessageBox.Show("Module Not Found");

            }
        }

        private void rdbyear_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rdbsm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbsm_Click(object sender, EventArgs e)
        {
            rdbcredits.Checked = false;
            rdbyear.Checked = false;
            rdbsm.Checked = true;
            rdbmark.Checked = false;
            txtval.Visible = false;


            if (rdbsm.Checked = true)
            {
                txtval.Visible = false;
                nudval.Visible = true;
                lblValue.Visible = true;
            }

        }

        private void rdbcredits_Click(object sender, EventArgs e)
        {
            rdbcredits.Checked = true;
            rdbyear.Checked = false;
            rdbsm.Checked = false;
            rdbmark.Checked = false;
            txtval.Visible = false;


            if (rdbcredits.Checked = true)
            {
                txtval.Visible = true;
                nudval.Visible = false;
                lblValue.Visible = true;
            }
        }

        private void rdbyear_Click(object sender, EventArgs e)
        {
            rdbcredits.Checked = false;
            rdbyear.Checked = true;
            rdbsm.Checked = false;
            rdbmark.Checked = false;
            txtval.Visible = false;


            if (rdbyear.Checked = true)
            {
                txtval.Visible = false;
                nudval.Visible = true;
                lblValue.Visible = true;
            }

        }

        private void rdbmark_Click(object sender, EventArgs e)
        {
            rdbcredits.Checked = false;
            rdbyear.Checked = false;
            rdbsm.Checked = false;
            rdbmark.Checked = true;
            txtval.Visible = false;


            if (rdbmark.Checked = true)
            {
                txtval.Visible = false;
                nudval.Visible = true;
                lblValue.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
