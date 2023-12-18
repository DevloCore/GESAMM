using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class EtapeNormee
    {
        private int id;
        private string norme;
        private DateTime? dateNorme;

        public EtapeNormee(int id, string norme, string dateNorme)
        {
            this.id = id;
            this.norme = norme;
            try
            {
                DateTime parsed = DateTime.Parse(dateNorme);
                this.dateNorme = parsed;
            }
            catch { }
        }

        public int getId() { return id; }
        public bool estNormee() { return norme != ""; }

        public string getNorme() { return norme; }
        public DateTime? getDateNorme() { return dateNorme;}

    }
}
