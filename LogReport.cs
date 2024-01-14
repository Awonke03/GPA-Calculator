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
    public partial class LogReport : Form
    {
        public LogReport()
        {
            InitializeComponent();
        }
        public string years, semesters;
        public double weightedgpa()
        {

            double summod = 0, sumcred = 0;
            aux = head;
            years = ""; semesters = "";
            while (aux != null)
            {
                summod = summod + (Convert.ToDouble(aux.final_mark) / 100) * aux.credits;
                sumcred += aux.credits;

                if (years.Contains(aux.year) == false)
                {
                    years = years + aux.year;
                }

                if (semesters.Contains(aux.semester) == false)
                {
                    //semesters.Append(aux.semester);
                    semesters = semesters + aux.semester;
                }

                aux = aux.next;
            }

            return Math.Round((summod / sumcred) * 100, 2);
        }
        Main.modules aux, head = Main.head;


        public void displaysm()
        {
            rtbout2.Clear();


            double summod = 0, sumcred = 0;
            foreach (char i in years)
            {

                rtbout2.AppendText($"Year: {i}\n");
                foreach (char j in semesters)
                {
                    aux = head;
                    summod = 0; sumcred = 0;
                    while (aux != null)
                    {
                        if (aux.year.Contains(i) == true && aux.semester.Contains(j) == true)
                        {
                            summod = summod + (Convert.ToDouble(aux.final_mark) / 100) * aux.credits;
                            sumcred += aux.credits;
                        }

                        aux = aux.next;

                    }
                    if (summod != 0)
                        rtbout2.AppendText($"Semester: {j}     GPA: {Math.Round((summod / sumcred) * 100, 2)}%\n");



                }



            }
        }
        public Char getgrate(double mark)
        {
            if (mark >= 90)
            {
                return 'A';
            }
            else if (mark >= 80)
            {
                return 'B';
            }
            else if (mark >= 70)
            {
                return 'C';
            }
            else if (mark >= 60)
            {
                return 'D';
            }
            else if (mark >= 50)
            {
                return 'E';
            }

            return 'F';
        }
        public void headings()
        {


            rtbout.AppendText($"Module Code\t\tFinal Mark\tYear\tSemester\tCredits\n");

        }
        public void bubblesort()
        {
            aux = head;
            Main.modules temp;
            bool swapped = false;
            do
            {
                swapped = false;

                aux = head;
                while (aux.next != null)
                {
                    if (aux.final_mark < aux.next.final_mark)
                    {
                        swapped = true;
                        temp = aux;
                        aux = aux.next;
                        aux.next = temp;
                        if (aux == head)
                        {
                            head = temp;
                        }
                        else
                        {

                            Main.modules prev = head;
                            while (prev.next != aux)
                            {
                                prev = prev.next;
                            }
                            prev.next = temp;
                        }
                    }


                    aux = aux.next;
                }
            }
            while (swapped != false);

        }

        private void LogReport_Load(object sender, EventArgs e)
        {
            rtbout.Clear();
            headings();

            aux = head;

            while (aux != null)
            {

                rtbout.AppendText($"{aux.module_code}\t\t{aux.final_mark}\t\t{aux.year}\t{aux.semester}\t\t{aux.credits}\n");


                aux = aux.next;

            }

            txtGpa.Text = Convert.ToString(weightedgpa());
            txtfname.Text = Login.gets.fname;
            txtstud.Text = Login.gets.studno;
            txtid.Text = Login.gets.idno;
            txtlname.Text = Login.gets.lname;
            txtgrade.Text = Convert.ToString(getgrate(weightedgpa()));
            displaysm();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

