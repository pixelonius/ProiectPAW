using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
   
    public partial class Form4 : Form
    {
        List<string> denumiri1;
        List<int> cantitati1;
        List<double> preturi1;
        int total1;
        Furnizor furnizor1;

       
        public Form4(List<string> denumiri, List<int> cantitati, List<double> preturi, Furnizor furnizori, int total )
        {
            InitializeComponent();
            furnizor1 = (Furnizor)furnizori.Clone();
            denumiri1 = denumiri;
            cantitati1 = cantitati;
            preturi1 = preturi;
            total1 = total;
            string rezultat = "Ati adaugat: ";
            for(int i = 0; i < denumiri1.Count; i++)
            {
                rezultat += cantitati1[i].ToString() + " bucati din " + denumiri1[i].ToString() + " la pretul de " + preturi1[i].ToString() + " bucata!" + "\n";
            }
            textBox1.Text = rezultat;
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int marime = denumiri1.Count;
            string[] denumiri2 = denumiri1.ToArray();
            int[] cantitati2 = cantitati1.ToArray();
            double[] preturi2=preturi1.ToArray();
            foreach (var i in cantitati2)
                Console.WriteLine(i.ToString());
           
            Materiale material = new Materiale(furnizor1,denumiri2, cantitati2,preturi2, total1);

            Form6 frm=new Form6(material);
            Console.WriteLine(material.ToString());
            this.Close();
            frm.ShowDialog();
        }

        /*private void btnModif_Click(object sender, EventArgs e)
        {
            denumiri1.RemoveAt(denumiri1.Count-1);
            cantitati1.RemoveAt(cantitati1.Count-1);
            preturi1.RemoveAt(preturi1.Count-1);
            total1--;
            this.Close();
        }*/
    }
}
