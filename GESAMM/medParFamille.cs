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
    public partial class medParFamille : Form
    {
        public medParFamille()
        {
            InitializeComponent();

            foreach (Famille uneFamille in Global.familles.Values)
            {
                lv_familles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lv_familles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListViewItem ligne = new ListViewItem();
                ligne.Text = uneFamille.getCode().ToString();
                ligne.SubItems.Add(uneFamille.getLibelle());
                ligne.SubItems.Add(uneFamille.getNbMediAmm().ToString());
                lv_familles.Items.Add(ligne);
            }

        }

        private void lv_familles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_medic.Items.Clear();

            if (lv_familles.SelectedItems.Count > 0)
            {
                ListViewItem selectedFamille = lv_familles.SelectedItems[0];

                string selectedFamilleCode = selectedFamille.SubItems[0].Text;

                foreach (Medicament unMedic in Global.medicaments.Values)
                {
                    if (unMedic.getCodeFamille() == selectedFamilleCode)
                    {
                        lv_medic.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lv_medic.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        ListViewItem ligne = new ListViewItem();
                        ligne.Text = unMedic.getDepotLegal();
                        ligne.SubItems.Add(unMedic.getNomCommercial());
                        ligne.SubItems.Add(unMedic.getComposition());
                        ligne.SubItems.Add(unMedic.getEffets());
                        ligne.SubItems.Add(unMedic.getContreIndications());
                        ligne.SubItems.Add(unMedic.getPrixEchantillon().ToString());
                        ligne.SubItems.Add(unMedic.getAmm());
                        lv_medic.Items.Add(ligne);
                    }
                }
            }
        }
    }
}
