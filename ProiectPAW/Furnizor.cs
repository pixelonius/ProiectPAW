﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Furnizor : ICloneable
    {
        String nume;
        String localitate;
        String tara;

        public Furnizor()
        {
            nume = "";
            localitate = "";
            tara = "";
        }

        public Furnizor(string nume, string localitate, string tara)
        {
            this.nume = nume;
            this.localitate = localitate;
            this.tara = tara;
        }

        public object Clone()
        {
            /*Furnizor clona= (Furnizor)MemberwiseClone();
            clona.nume = String.Copy(nume);
            clona.localitate=String.Copy(localitate);
            clona.tara=String.Copy(tara);*/
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Societatea comerciala  " + nume + " din localitatea " + localitate + ", tara " + tara+"!";
        }
    }
}
