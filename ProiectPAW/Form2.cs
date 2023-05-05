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
    public partial class Form2 : Form
    {
        List<Furnizor> furnizorList2;
        
        public Form2(List<Furnizor> furnizorList)
        {
            InitializeComponent();
            furnizorList2 = furnizorList;
            textBox1.Text=furnizorList.Last().ToString()+Environment.NewLine;

        }
        private void salvareFurnizori(List<Furnizor> list) { 
           
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            string filePath = Path.Combine(parentDirectory, "furn.txt");
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (Furnizor f in list)
                {
                    string furnizor = f.Nume + "," + f.Localitate + "," + f.Tara;
                    sw.WriteLine(furnizor);
                }
                sw.Close();
            }
        }

        private void btnAnotherOne_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //save to file
            salvareFurnizori(furnizorList2);
            Form3 frm=new Form3(furnizorList2.Last());
            this.Close();
            
            frm.Show();
        }

     
    }
}
