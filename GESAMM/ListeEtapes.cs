using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESAMM
{
    public partial class ListeEtapes : Form
    {
        public ListeEtapes()
        {
            InitializeComponent();
        }

        private void ListeEtapes_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listViewEtapeNormees.Items.Clear();

            foreach (var element in Global.etapesNormees)
            {
                var value = element.Value;
                ListViewItem item = new ListViewItem(element.Key.ToString());
                item.SubItems.Add(value.estNormee() ? "Oui" : "Non");
                item.SubItems.Add(value.getNorme());
                item.SubItems.Add(value.getDateNorme()?.ToShortDateString());
                listViewEtapeNormees.Items.Add(item);
            }
        }

        private async void buttonEditNorme_Click(object sender, EventArgs e)
        {
            SqlCommand request = new SqlCommand("prc_maj_norme", Global.db);
            request.CommandType = System.Data.CommandType.StoredProcedure;
            //request.Parameters.AddWithValue("@dateMaj", DateTime.Now.ToString("yyyy-MM-dd"));
            request.Parameters.AddWithValue("@idUser", Global.userId);
            request.Parameters.AddWithValue("@normeAV", selectedEtapeNormee.getNorme());
            request.Parameters.AddWithValue("@normeAP", tbNorme.Text);
            request.Parameters.AddWithValue("@dateAV", selectedEtapeNormee.getDateNorme().HasValue ? selectedEtapeNormee.getDateNorme().Value.ToString("yyyy-MM-dd") : null);
            request.Parameters.AddWithValue("@dateAP", tbNorme.Text == "" ? null : datePickerNorme.Value.ToString("yyyy-MM-dd"));
            request.Parameters.AddWithValue("@numEtape", selectedEtapeNormee.getId());

            try
            {
                request.ExecuteNonQuery();
                MessageBox.Show("Modification prise en compte !", "Parfait");
                await Global.ReloadData();
                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private EtapeNormee selectedEtapeNormee;

        private void listViewEtapeNormees_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEtapeNormee = null;
            if (listViewEtapeNormees.SelectedItems.Count == 1)
                selectedEtapeNormee = Global.etapesNormees.ElementAt(listViewEtapeNormees.SelectedIndices[0]).Value;

            bool selected = selectedEtapeNormee != null;
            tbNorme.Text = selected ? selectedEtapeNormee.getNorme() : "";
            datePickerNorme.Value = (selected && selectedEtapeNormee.getDateNorme().HasValue) ? selectedEtapeNormee.getDateNorme().Value : DateTime.Now;
            buttonEditNorme.Enabled = selected;
        }
    }
}
