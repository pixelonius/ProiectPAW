using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form1 : Form
    {
        List<Furnizor> furnizorList=new List<Furnizor>();
        Furnizor f;
        int indexDelete;
        public Form1()
        {
            InitializeComponent();
            button2.Visible= false;
            button3.Visible = false;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            Form3 frm = new Form3(f);
            this.Hide();
            frm.Show();
        }    

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
                    frm.ShowDialog();      
                    
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            string filePath = Path.Combine(parentDirectory, "furn.txt");
            using (StreamReader sr = new StreamReader(filePath))
            {
                
                if (sr.Peek() == -1)
                {
                    cbFurnizori.Visible = false;
                }
                else
                {
                    cbFurnizori.Visible = true;
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        string nume = linie.Trim().Split(',')[0];
                        string localitate = linie.Trim().Split(',')[1];
                        string tara = linie.Trim().Split(',')[2];
                        cbFurnizori.Items.Add(nume);
                        Furnizor frn = new Furnizor(nume, localitate, tara);
                        furnizorList.Add(frn);
                    }
                }

            } 
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            //vizuale
            furnizorList.RemoveAt(indexDelete);
            cbFurnizori.Items.RemoveAt(indexDelete);
            cbFurnizori.SelectedIndex = -1;
            button3.Visible = false;
            button2.Visible = false;
            tbNumeFurnizor.Clear();
            tbLocalitateFurnizor.Clear();
            tbTaraFurnizor.Clear();
            button1.Visible = true;
            //functionale
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            string filePath = Path.Combine(parentDirectory, "furn.txt");
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (Furnizor f in furnizorList)
                {
                    string furnizor = f.Nume + "," + f.Localitate + "," + f.Tara;
                    sw.WriteLine(furnizor);
                }
                sw.Close();
            }
        }

        private void cbFurnizori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFurnizori.SelectedIndex != -1)
            {
                tbNumeFurnizor.Text = furnizorList[cbFurnizori.SelectedIndex].Nume;
                tbLocalitateFurnizor.Text = furnizorList[cbFurnizori.SelectedIndex].Localitate;
                tbTaraFurnizor.Text = furnizorList[cbFurnizori.SelectedIndex].Tara;
                button2.Visible = true;
                button3.Visible = true;
                f = new Furnizor(furnizorList[cbFurnizori.SelectedIndex].Nume, furnizorList[cbFurnizori.SelectedIndex].Localitate, furnizorList[cbFurnizori.SelectedIndex].Tara);
                indexDelete = cbFurnizori.SelectedIndex;
                button1.Visible = false;
            }
            else { button2.Visible = false; button3.Visible = false; button1.Visible = true; }
        }

       
    }
}
