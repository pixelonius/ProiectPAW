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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW
{
    public partial class Form8 : Form
    {
        Materiale material1;
        string connString;
        public Form8(Materiale material)
        {
            InitializeComponent();
            material1=(Materiale)material.Clone();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Istoric.accdb";
        }

        

        private void Form8_Load_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("S-a deschis!");
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM Istoric";
                comanda.Connection = conexiune;

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Data"].ToString());
                    itm.SubItems.Add(reader["Furnizor"].ToString());
                    itm.SubItems.Add(reader["Denumire"].ToString());
                    itm.SubItems.Add(reader["Cantitate"].ToString());
                    itm.SubItems.Add(reader["Pret"].ToString());
                    itm.SubItems.Add((Convert.ToDouble(reader["Cantitate"].ToString()) * Convert.ToDouble(reader["Pret"].ToString())).ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
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
    }
}
