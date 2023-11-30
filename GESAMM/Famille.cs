using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class Famille
    {
        private string code;
        private string name;
        private int nbMediAmm;

        public Famille(string code, string name, int nbMediAmm)
        {
            this.code = code;
            this.name = name;
            this.nbMediAmm = nbMediAmm;
        }

        public string getCode() { return code; }
        public string getName() { return name; }
        public int getNbMediAmm() { return nbMediAmm; }

    }
}
