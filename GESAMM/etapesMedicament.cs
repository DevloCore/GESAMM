using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESAMM
{
    public partial class etapesMedicament : Form
    {
        public etapesMedicament()
        {
            InitializeComponent();
        }

        private void etapesMedicament_Load(object sender, EventArgs e)
        {
            foreach (var medoc in Global.medicaments)
            {
                cbMedicaments.Items.Add(medoc.Value.getNomCommercial());
            }
        }

        private void cbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvEtapes.Items.Clear();
            foreach (var medoc in Global.medicaments)
            {
                if (medoc.Value.getNomCommercial() == cbMedicaments.Text)
                {
                    foreach (Workflow uneEtape in medoc.Value.getEtapes())
                    {
                        ListViewItem ligne = new ListViewItem();
                        if (uneEtape != null)
                        {
                            ligne.Text = uneEtape.getNumEtape().ToString();
                            ligne.SubItems.Add(uneEtape.getEtape().getLibelle());
                            ligne.SubItems.Add(uneEtape.getDateDecision().ToString());
                            if (uneEtape.getDecision().getLibelle() == "oui")
                            {
                                ligne.SubItems.Add("Validée");
                            }
                            else if (uneEtape.getDecision().getLibelle() == "non")
                            {
                                ligne.SubItems.Add("Refusée");
                            }
                            else
                            {
                                ligne.SubItems.Add("Null");
                            }
                            if (uneEtape.getEtape() != null && uneEtape.getEtape().getEtapeNormee() != null && uneEtape.getEtape().getEtapeNormee().getNorme() != null)
                            {
                                ligne.SubItems.Add(uneEtape.getEtape().getEtapeNormee().getNorme());
                            }
                            else
                            {
                                ligne.SubItems.Add("Null");
                            }
                            if (uneEtape.getEtape() != null && uneEtape.getEtape().getEtapeNormee() != null && uneEtape.getEtape().getEtapeNormee().getDateNorme() != null)
                            {
                                ligne.SubItems.Add(uneEtape.getEtape().getEtapeNormee().getDateNorme().ToString());
                            }
                            else
                            {
                                ligne.SubItems.Add("Null");
                            }
                            lvEtapes.Items.Add(ligne);

                        }
                        else
                        {
                            MessageBox.Show("Ce médicament n'a pas d'étapes enregistrées dans son workflow.");
                        }
                    }
                }
            }
        }
    }
}
