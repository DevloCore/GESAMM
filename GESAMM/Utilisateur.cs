using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string password;

        public Utilisateur(int id, string nom, string password)
        {
            this.id = id;
            this.nom = nom;
            this.password = password;
        }

        public int getId() { return id; }
        public string getNom() { return nom; }
        public string getPassword() { return password; }

    }
}
