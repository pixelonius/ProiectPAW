using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        Bitmap bmp;
        string connString;
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
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Istoric.accdb";

            //db sync
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                /*comanda.CommandText = "SELECT MAX(ID) FROM istoric";
                int id = Convert.ToInt32(comanda.ExecuteScalar());*/

                for (int i = 0; i < material1.total; i++)
                {
                    int id = 0;
                    comanda.CommandText = "SELECT MAX(ID) FROM istoric";
                    if (comanda.ExecuteScalar() != DBNull.Value)
                    {
                        id = Convert.ToInt32(comanda.ExecuteScalar());
                    }                
                    comanda.CommandText = "INSERT INTO istoric VALUES(?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                    comanda.Parameters.Add("Furnizor", OleDbType.Char, 40).Value = material1.furnizor.Nume;
                    comanda.Parameters.Add("Denumire", OleDbType.Char, 40).Value = material1.denumireMarfa[i];
                    comanda.Parameters.Add("Cantitate", OleDbType.Integer).Value = Convert.ToInt32(material1.cantitate[i]);
                    comanda.Parameters.Add("Pret", OleDbType.Double).Value = Convert.ToDouble(material1.pret[i]);
                    comanda.Parameters.Add("Total", OleDbType.Double).Value = Convert.ToDouble(material1.pret[i] * (double)material1.cantitate[i]);
                    comanda.Parameters.Add("Data", OleDbType.Char, 20).Value = System.DateTime.Now.ToString();
                    comanda.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g=this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg=Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?","Confirm exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7(material1);
            frm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8(material1);
            frm.ShowDialog();
        }
    }
}
