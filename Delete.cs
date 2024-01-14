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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Main.modules aux, head = null;
        public void DeletefromTextfile()
        {
            StreamWriter write = new StreamWriter("Marks.txt");
            aux = Main.head;
       
            while (aux != null)
            {
                write.WriteLine($"{aux.module_code},{aux.final_mark},{aux.credits},{aux.year},{aux.semester},{Login.gets.studno}");
                aux=aux.next;
            }
            write.Close();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            head = Main.head;
            Main.modules aux2=null;
            aux = head;
            bool found = false;
            while (aux != null)
            {
                if ((aux.module_code==txtcode.Text) && (aux.credits==Convert.ToDouble(txtcredit.Text)))
                {
                    found = true;
                    if (aux == head)
                        head = aux.next;
                    else
                    {
                        aux2.next = aux.next;
                        aux = null;

                    }

                    break;

                }
                aux2 = aux;
                aux = aux.next;
            }
            if(found==true)
            {
                DeletefromTextfile();
                MessageBox.Show($"{txtcode.Text} Has been deleted");
            }
            else
            {
                MessageBox.Show($"{txtcode.Text} not found");

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main n = new Main();
            n.Show();
        }
    }
}
