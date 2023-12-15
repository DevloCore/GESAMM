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

        private Form lastForm;

        private void CustomOpen(Form form)
        {
            if(lastForm != null) lastForm.Close();

            form.MdiParent = this;
            form.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenue " + Global.username);
        }
        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomOpen(new ListeMedicaments());
        }
        private void decisionEtapeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomOpen(new DecisionEtape());
        }
        private void nombreDeMédicamentParFamilleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomOpen(new medParFamille());
        }
        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CustomOpen(new AjoutMedicament());
        }
        private void workflowToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomOpen(new etapesMedicament());
        }
    }
}
