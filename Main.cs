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
    public partial class Main : Form
    {
        public class modules
        {
            public string module_code, year, semester;
            public double credits;
            public int final_mark;

            public modules next;
        }
        public static modules head = null, aux = null;
        public Main()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateM m = new UpdateM();
            m.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete m = new Delete();
            m.Show();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            this.Close();
            LogReport m = new LogReport();
            m.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            head = null;
            try
            {
                string stud = Login.gets.studno;
                if (File.Exists("Marks.txt"))
                {
                    string[] lines = File.ReadAllLines("Marks.txt");
                    foreach (string line in lines)
                    {
                        string[] get = line.Split(',');
                        {

                            if (get[5].Contains(stud) == true)
                            {
                                modules node = new modules();
                                node.module_code = get[0];
                                node.year = get[3];
                                node.semester = get[4];
                                node.credits = Convert.ToDouble(get[2]);
                                node.final_mark = Convert.ToInt32(get[1]);

                                //  MessageBox.Show($"{node.module_code},{node.final_mark},{node.credits}");
                                if (head == null)
                                    head = node;
                                else
                                    aux.next = node;
                                aux = node;


                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewcs addNewcs = new AddNewcs();
            addNewcs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login   login = new Login();
            login.Show();
        }
    }
}
