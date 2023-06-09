﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Materiale : ICloneable
    {
       
       public Furnizor furnizor;
       public String[] denumireMarfa;
       public int[] cantitate;
       public int[] pret;
       public int total;

        public Materiale() {
            furnizor = new Furnizor();
            denumireMarfa= new String[0];
            cantitate= new int[0];
            pret= new int[0];
        }

        public Materiale(Furnizor furnizor, string[] denumireMarfa, int[] cantitate, int[] pret, int total)
        {
            this.furnizor= (Furnizor)furnizor.Clone();
            this.denumireMarfa=new String[denumireMarfa.Length];
           for(int i=0;i< denumireMarfa.Length;i++)
            {
                this.denumireMarfa[i] = String.Copy(denumireMarfa[i]);
            }
            this.cantitate = new int[cantitate.Length];
            for(int i=0;i< cantitate.Length; i++)
            {
                this.cantitate[i] = cantitate[i];
            }
            this.pret = new int[pret.Length];
            for(int i = 0; i < pret.Length; i++)
            {
                this.pret[i] = pret[i];
            }
            this.total = total;
        }

        public object Clone()
        {
            Materiale clona= (Materiale)MemberwiseClone();
            clona.furnizor=(Furnizor)furnizor.Clone();
            clona.denumireMarfa = new String[denumireMarfa.Length];
            for (int i = 0; i < denumireMarfa.Length; i++)
            {
                clona.denumireMarfa[i] = String.Copy(denumireMarfa[i]);
            }
            clona.cantitate = new int[cantitate.Length];
            for (int i = 0; i < cantitate.Length; i++)
            {
                clona.cantitate[i] = cantitate[i];
            }
            clona.pret = new int[pret.Length];
            for (int i = 0; i < pret.Length; i++)
            {
                clona.pret[i] = pret[i];
            }

            return clona;
        }

        public int calculTotal()
        {
            total = 0;
            for(int i=0;i<pret.Length;i++) {
                total += pret[i]*cantitate[i];
            }

            return total;
        }
        public override string ToString()
        {
            string rezultat="De la furnizorul: ";
            rezultat += furnizor.ToString()+", s-au achizitionat urmatoarele: "+Environment.NewLine;
            rezultat += "Denumire      Cantitate      Pret"+Environment.NewLine;
           for(int i=0;i<pret.Length;i++) 
            {
                rezultat += denumireMarfa[i]+"      ";
                rezultat += cantitate[i].ToString() + "     ";
                rezultat += pret[i].ToString();
                rezultat += Environment.NewLine;
            }
            return rezultat;
          
        }
    }
}
