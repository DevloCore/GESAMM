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
    public partial class DecisionEtape : Form
    {
        public DecisionEtape()
        {
            InitializeComponent();
        }

        private void DecisionEtape_Load(object sender, EventArgs e)
        {
            foreach (var i in Global.medicaments)
            {
                cbMedicaments.Items.Add(i.Value.getNomCommercial());
            }
        }
    }
}
