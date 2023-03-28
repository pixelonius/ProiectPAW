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
            SizeF tbDenumires = getSizes(tbDenumire);
            int height = (int)(tbDenumires.Height * 1.3);
            tbDenumire.Height = height;


            foreach (var i in material1.cantitate)
            {
                tbCantitate.Text += i.ToString() + Environment.NewLine;
                cantitate += i.ToString() + " ";
            }
            tbCantitate.Height = height;


            foreach (var i in material1.pret)
            {
                tbPret.Text += i.ToString() + Environment.NewLine;
                pret += i.ToString() + " ";
            }
            tbPret.Height = height;
           
            
            

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
                StreamReader sr = new StreamReader(dlg.FileName);
                tbDenumire.Text = sr.ReadLine();
                sr.ReadLine();
                //citeste linie cu linie;
                sr.Close();
            }
        }



    }
}
