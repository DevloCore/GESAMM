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
    public partial class ListeMedicaments : Form
    {
        public ListeMedicaments()
        {
            InitializeComponent();
        }

        private void ListeMedicaments_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void cb_enValid_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listMedicaments.Items.Clear();

            var elements = Global.medicaments.Values.ToArray();
            if (cb_enValid.Checked) elements = elements.Where((e) => (e.getDerniereEtape() < 8 && !e.estRefusé())).ToArray();

            foreach (Medicament med in elements)
            {
                ListViewItem item = new ListViewItem(med.getDepotLegal());
                item.SubItems.Add(med.getNomCommercial());
                item.SubItems.Add(med.getFamille().getLibelle());
                item.SubItems.Add(med.getComposition());
                item.SubItems.Add(med.getEffets());
                item.SubItems.Add(med.getContreIndications());
                if (med.getPrixEchantillon().HasValue)
                    item.SubItems.Add(med.getPrixEchantillon().Value.ToString("F2") + " €");
                else
                    item.SubItems.Add("");
                item.SubItems.Add(med.getAmm());
                listMedicaments.Items.Add(item);
            }
        }
    }
}
