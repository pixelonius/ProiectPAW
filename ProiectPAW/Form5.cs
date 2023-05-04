using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW
{
    public partial class Form5 : Form
    {
        Materiale material1;
        string denumire;
        string cantitate;
        string pret;
        public Form5(Materiale material)
        {

           


            InitializeComponent();
            material1 = (Materiale)material.Clone();


            tbFurnizor.Text = material1.furnizor.ToString();
            SizeF tbFurnizors = getSizes(tbFurnizor);
            tbFurnizor.Width = (int)(tbFurnizors.Width * 1.7);
            foreach (String s in material1.denumireMarfa)
            {
                tbDenumire.Text += s + Environment.NewLine;
                denumire += s + " ";
            }
            setSizeBox(tbDenumire);


            foreach (var i in material1.cantitate)
            {
                tbCantitate.Text += i.ToString() + Environment.NewLine;
                cantitate += i.ToString() + " ";
            }
            setSizeBox(tbCantitate);


            foreach (var i in material1.pret)
            {
                tbPret.Text += i.ToString() + Environment.NewLine;
                pret += i.ToString() + " ";
            }
            setSizeBox(tbPret);
           
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private SizeF getSizes(System.Windows.Forms.TextBox tb)
        {
            SizeF MessageSize = tb.CreateGraphics()
                              .MeasureString(tb.Text,
                                              tb.Font,
                                              tb.Width,
                                              new StringFormat(0));
            return MessageSize;
        }

        private void setSizeBox(System.Windows.Forms.TextBox tb)
        {
            SizeF tbs = getSizes(tb);
            int height = (int)(tbs.Height * 1.3);
            tb.Height = height;

        }

        private void salvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                string rezultat = tbFurnizor.Text+Environment.NewLine+denumire+Environment.NewLine+cantitate+Environment.NewLine+pret+Environment.NewLine;
              
                sw.WriteLine(rezultat);
                sw.Close();
                
            }
        }

        private void citireFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbFurnizor.Clear();
                tbDenumire.Clear();
                tbCantitate.Clear();
                tbPret.Clear();
                StreamReader sr = new StreamReader(dlg.FileName);
                tbFurnizor.Text = sr.ReadLine();
                SizeF tbFurnizors = getSizes(tbFurnizor);
                tbFurnizor.Width = (int)(tbFurnizors.Width * 1.7);
                string[] denum = sr.ReadLine().Trim().Split(' ');
                foreach(string s in denum)
                {
                    tbDenumire.Text += s + Environment.NewLine;
                }

                string[] cant= sr.ReadLine().Trim().Split(' ');
                foreach(string s in cant)
                {
                    tbCantitate.Text += s + Environment.NewLine;
                }

                string[] prt= sr.ReadLine().Trim().Split(' ');
                foreach(string s in prt)
                {
                    tbPret.Text += s + Environment.NewLine;
                }
                setSizeBox(tbDenumire);
                setSizeBox(tbCantitate);
                setSizeBox(tbPret);

                sr.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6 frm=new Form6(material1);
            frm.Show();
        }
    }
}
