﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESAMM
{
    public class Workflow
    {
        private DateTime dateDecision;
        private int numEtape;
        private int idDecision;

        public Workflow(DateTime dateDecision, int numEtape, int idDecision) {
            this.dateDecision = dateDecision;
            this.numEtape = numEtape;
            this.idDecision = idDecision;
        }

        public DateTime getDateDecision() { return dateDecision; }
        public int getNumEtape() { return numEtape; }
        public int getIdDecision() { return idDecision;}

        public Etape getEtape()
        {
            return Global.etapes.First((val) => val.getNum() == numEtape);
        }

        public Decision getDecision()
        {
            return Global.decisions.First((val) => val.getId() == idDecision);
        }

    }
}
