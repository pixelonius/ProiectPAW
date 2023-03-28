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
    public partial class Form1 : Form
    {
        List<Furnizor> furnizorList=new List<Furnizor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }*/

       /* private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
           
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNumeFurnizor.Text == "")
            {
                errorProvider1.SetError(tbNumeFurnizor, "Introduceti numele furnizorului!");
            }
            else if (tbLocalitateFurnizor.Text == "")
                errorProvider1.SetError(tbLocalitateFurnizor, "Introduceti localitatea furnizorului!");
            else if (tbTaraFurnizor.Text == "")
                errorProvider1.SetError(tbTaraFurnizor, "Introduceti tara furnziorului!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    String nume=tbNumeFurnizor.Text;
                    String localitate = tbLocalitateFurnizor.Text;
                    String tara = tbTaraFurnizor.Text;
                    Furnizor f=new Furnizor(nume, localitate, tara);
                    furnizorList.Add(f);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbLocalitateFurnizor.Clear();
                    tbTaraFurnizor.Clear();
                    tbNumeFurnizor.Clear();
                    Form2 frm = new Form2(furnizorList);
                    frm.Show();
                }
            }
        }
    }
}
