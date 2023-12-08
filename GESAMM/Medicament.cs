using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class Medicament
    {
        private string depotLegal;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndications;
        private float? prixEchantillon;
        private string amm;
        private int derniereEtape;
        private string codeFamille;
        private List<Workflow> etapes;

        public Medicament(string depotLegal, string nomCommercial, string composition, string effets, string contreIndications, float? prixEchantillon, string amm, int derniereEtape, string codeFamille)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.prixEchantillon = prixEchantillon;
            this.amm = amm;
            this.derniereEtape = derniereEtape;
            this.codeFamille = codeFamille;
            this.etapes = new List<Workflow>();
        }

        public string getDepotLegal() { return depotLegal; }
        public string getNomCommercial() { return nomCommercial; }
        public string getComposition() { return composition; }
        public string getEffets() { return effets; }
        public string getContreIndications() { return contreIndications; }
        public float? getPrixEchantillon() { return prixEchantillon; }
        public string getAmm() { return amm; }
        public int getDerniereEtape() { return derniereEtape; }
        public string getCodeFamille() { return codeFamille; }

        public bool estRefusé()
        {
            foreach(var element in etapes)
            {
                if (element.getDecision().getLibelle() == "non") return true;
            }
            return false;
        }

        public Famille getFamille()
        {
            return Global.familles[codeFamille];
        }

        public void AjouterEtape(Workflow workflow)
        {
            etapes.Add(workflow);
        }

    }
}
