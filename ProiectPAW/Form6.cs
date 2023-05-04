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
    public partial class Form6 : Form
    {
        Materiale material1;
        string denumire;
        string cantitate;
        string pret;
        public Form6(Materiale material)

        {
            

            InitializeComponent();
            material1 = (Materiale)material.Clone();
            label3.Text = material1.furnizor.ToString();
            listView1.Items.Clear();
            for(int i = 0; i < material1.total; i++)
            {
                ListViewItem itm = new ListViewItem(material1.denumireMarfa[i]);
                
                itm.SubItems.Add(material1.cantitate[i].ToString());
                itm.SubItems.Add(material1.pret[i].ToString());
                itm.SubItems.Add((material1.pret[i] * material1.cantitate[i]).ToString());
                listView1.Items.Add(itm);
            }
            
        }
    }
}
