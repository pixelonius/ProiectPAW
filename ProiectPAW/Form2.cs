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
    public partial class Form2 : Form
    {
        List<Furnizor> furnizorList2;
        public Form2(List<Furnizor> furnizorList)
        {
            InitializeComponent();
            furnizorList2 = furnizorList;
            textBox1.Text=furnizorList.Last().ToString();

        }

        private void btnAnotherOne_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 frm=new Form3(furnizorList2.Last());
            this.Close();
            frm.Show();
        }
    }
}
