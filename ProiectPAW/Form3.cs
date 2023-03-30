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
    public partial class Form3 : Form
    {
        List<string> denumiri=new List<string>();
        List<int> cantitati=new List<int>();
        List<int> preturi=new List<int>();
        Furnizor furnizor1;

        public Form3(Furnizor furnizor)
        {
            InitializeComponent();
            furnizor1 = new Furnizor(furnizor.Nume, furnizor.Localitate, furnizor.Tara);
            Console.WriteLine(furnizor.ToString()+Environment.NewLine);
            Console.WriteLine(furnizor1.ToString() + "2");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbDenumire.Text == "")
                errorProvider1.SetError(tbDenumire, "Introduceti o denumire");
            else if (tbCantitate.Text == "")
                errorProvider1.SetError(tbCantitate, "Introduceti o cantitate");
            else if (tbPret.Text == "")
                errorProvider1.SetError(tbPret, "Introduceti pretul");
            else
            {
                errorProvider1.Clear();
                try
                {
                    String denumire=tbDenumire.Text;
                    int cantitate = Convert.ToInt32(tbCantitate.Text);
                    int pret=Convert.ToInt32(tbPret.Text);
                    denumiri.Add(denumire);
                    preturi.Add(pret);
                    cantitati.Add(cantitate);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbDenumire.Clear();
                    tbCantitate.Clear();
                    tbPret.Clear();
                    Console.WriteLine(furnizor1.ToString() + " 3");
                    Form4 frm=new Form4(denumiri, cantitati, preturi, furnizor1);
                   
                    frm.Show();

                }
            }
        }
    }
}
