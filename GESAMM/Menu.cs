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
        private void DecisionMedicamentMenu_Click(object sender, EventArgs e)
        {
            if (decisionEtape == null || decisionEtape.IsDisposed)
            {
                decisionEtape = new DecisionEtape();
            }

            decisionEtape.MdiParent = this;
            decisionEtape.Show();
        }
    }
}
