using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanInterface
{
    class cuvant
    {
        protected int incerc;
        protected string num;
        public string nume
        {
            get { return num; }
            set { this.num = value; }
        }
        public int incercari
        {
            get { return incerc; }
            set { this.incerc = value; }
        }
        public cuvant (string num="masina",int incerc=15)
        {
            this.num = num;
            this.incerc = incerc;
        }
        public cuvant dacuvant()
        {
            cuvant cuvmeu = new cuvant { };
            try
            {
                string[] alllines = File.ReadAllLines("cuvinte.txt");
                Random r = new Random();
                string line = alllines[r.Next(alllines.Length)];
                string[] values = line.Split(' ');
                cuvmeu.nume = values[0];
                cuvmeu.incercari = Int32.Parse(values[1]);
            }
            catch
            {
                MessageBox.Show("Eroare! Program Nefunctional!");
            }
            return cuvmeu;
        }
    }
}
