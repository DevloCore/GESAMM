﻿using System;
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
        private string amm;
        private int derniereEtape;
        private string codeFamille;
        private List<Workflow> etapes;

        public Medicament(string depotLegal, string nomCommercial, string composition, string effets, string contreIndications, string amm, int derniereEtape, string codeFamille)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
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
        public string getAmm() { return amm; }
        public int getDerniereEtape() { return derniereEtape; }
        public string getCodeFamille() { return codeFamille; }

        public Famille getFamille()
        {
            return Global.familles[codeFamille];
        }

        public void AjouterEtape(Workflow workflow)
        {
            etapes.Add(workflow);
        }

        //public Workflow[] lesEtapes()
        //{
        //    List<Workflow> steps = new List<Workflow>();

        //    foreach(Etape etape in etapes)
        //    {
        //        Decision decision = Global.decisions.First((val) => val.getId() == )
        //        Workflow workflow = new Workflow(DateTime.Now, etape.getNum());
        //        steps.Add();
        //    }

        //    return steps.ToArray();
        //}

    }
}
