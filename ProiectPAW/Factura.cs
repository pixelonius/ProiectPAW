using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Factura
    {
        String nrFactura;
        Furnizor furnizor;
        DateTime data;
        Materiale materiale;
        int total;

        public Factura()
        {
            nrFactura = "0";
            furnizor = null;
            data = new DateTime();
            materiale = null;
            total = -1;
        }

        public Factura(string nrFactura, Furnizor furnizor, DateTime data, Materiale materiale)
        {
            this.nrFactura = nrFactura;
            this.furnizor = (Furnizor)furnizor.Clone();
            this.data = data;
            this.materiale = (Materiale)materiale.Clone();
            this.total = materiale.calculTotal();
        }



    }
}
