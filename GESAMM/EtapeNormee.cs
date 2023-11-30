using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class EtapeNormee
    {
        private string norme;
        private DateOnly dateNorme;

        public EtapeNormee(string norme, DateOnly dateNorme)
        {
            this.norme = norme;
            this.dateNorme = dateNorme;
        }

        public string getNorme() { return norme; }
        public DateOnly getDateNorme() { return dateNorme;}

    }
}
