using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class Decision
    {
        private int id;
        private string libelle;

        public Decision(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int getId() { return id; }
        public string getLibelle() { return libelle; }
    }
}
