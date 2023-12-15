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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue " + Global.username);
        }

        private ListeMedicaments listeMedicaments;
        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listeMedicaments == null || listeMedicaments.IsDisposed)
                listeMedicaments = new ListeMedicaments();

            listeMedicaments.MdiParent = this;
            listeMedicaments.Show();
        }

        private DecisionEtape decisionEtape;

        private void decisionEtapeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (decisionEtape == null || decisionEtape.IsDisposed)
            {
                decisionEtape = new DecisionEtape();
            }

            decisionEtape.MdiParent = this;
            decisionEtape.Show();
        }

        private medParFamille medParFamille;

        private void nombreDeMédicamentParFamilleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (medParFamille == null || medParFamille.IsDisposed)

                medParFamille = new medParFamille();
            medParFamille.MdiParent = this;
            medParFamille.Show();
        }


        private AjoutMedicament AjoutMedicament;
        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (AjoutMedicament == null || AjoutMedicament.IsDisposed)

                AjoutMedicament = new AjoutMedicament();
            AjoutMedicament.MdiParent = this;
            AjoutMedicament.Show();
        }

        private etapesMedicament etapesMedicament;
        private void workflowToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (etapesMedicament == null || etapesMedicament.IsDisposed)

                etapesMedicament = new etapesMedicament();
            etapesMedicament.MdiParent = this;
            etapesMedicament.Show();
        }
    }
}
