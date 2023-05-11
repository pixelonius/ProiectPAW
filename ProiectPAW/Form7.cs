using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProiectPAW
{
    public partial class Form7 : Form
    {
        Materiale material1;
        const int marg = 10;
        Graphics gr;
        Color culoare = Color.Blue;
        int nrElem;
        public Form7(Materiale material)
        {
            InitializeComponent();
            material1 = (Materiale)material.Clone();
            gr = panel1.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg,
                    panel1.ClientRectangle.Y + 2 * marg,
                    panel1.ClientRectangle.Width - 2 * marg,
                    panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(Color.Red, 3);
            gr.DrawRectangle(pen, rec);
            nrElem=material1.denumireMarfa.Count();

            double latime = rec.Width / nrElem / 2;
            double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
            double vMax = material1.getMax();

            Brush br = new SolidBrush(culoare);
            Rectangle[] recs = new Rectangle[nrElem];

            for (int i = 0; i < nrElem; i++)
            {
                recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - (material1.pret[i]*material1.cantitate[i]) / vMax * rec.Height),
                        (int)latime,
                        (int)((material1.pret[i]*material1.cantitate[i]) / vMax * rec.Height));
                gr.FillRectangle(br, recs[i]);
                //gr.FillEllipse(br, recs[i]);
                gr.DrawString((material1.pret[i]*material1.cantitate[i]).ToString(), this.Font,
                    br, recs[i].Location.X, recs[i].Location.Y - this.Font.Height);
                Font miniFont = new Font(this.Font.Name, (float)(this.Font.Size*0.85));
                
                gr.DrawString(material1.denumireMarfa[i], this.Font,
                        br, recs[i].Location.X-miniFont.Size, recs[i].Location.Y + recs[i].Height);
            }
            for (int i = 0; i < nrElem - 1; i++)
                gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                    recs[i].Location.Y),
                    new Point((int)(recs[i + 1].Location.X + latime / 2),
                    recs[i + 1].Location.Y));

        }
    }
}
