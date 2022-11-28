using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class NakladniAuto
    {
        private string spz;
        private int nosnost;
        private int hmotnostnakladu;
        public int Hmotnost
        {
            get
            {
                return hmotnostnakladu;
            }
        }
        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
        public void NalozNaklad(int vaha)
        {
            if(vaha <= nosnost)
            {
                hmotnostnakladu = vaha;
            }
            else
            {
                hmotnostnakladu = nosnost;
                MessageBox.Show("Náklad překročil nosnost vozidla. Nebylo naloženo " + (vaha - hmotnostnakladu) + " tun.");
            }
        }
        public void VylozNaklad(int vaha)
        {
            if (vaha <= hmotnostnakladu)
            {
                hmotnostnakladu = hmotnostnakladu - vaha;
            }
            else
            {
                hmotnostnakladu = 0;
                MessageBox.Show("Není možné vyložit tolik tun nákladu. Chybí " + (vaha - hmotnostnakladu) + " tun.");
            }
        }
        public override string ToString()
        {
            return "Nákladní auto " + this.spz + " má nosnost " + this.nosnost + " tuny a má naloženo " + this.hmotnostnakladu + " tun.";
        }
    }
}
