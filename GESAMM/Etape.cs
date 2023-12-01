using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class Etape
    {
        private int num;
        private string libelle;
        private EtapeNormee? etapeNormee;

        public Etape(int num, string libelle, EtapeNormee? etapeNormee = null)
        {
            this.num = num;
            this.libelle = libelle;
            this.etapeNormee = etapeNormee;
        }

        public int getNum() { return num; }
        public string getLibelle() { return libelle; }

        public EtapeNormee? getEtapeNormee() { return etapeNormee; }

        public bool estNormee() { return etapeNormee != null; }
    }
}
