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
    public partial class DecisionEtape : Form
    {
        public DecisionEtape()
        {
            InitializeComponent();
        }

        private void DecisionEtape_Load(object sender, EventArgs e)
        {
            // REMPLISSAGE DE LA COMBO BOX DES MEDICMAMENT

            foreach (var i in Global.medicaments)
            {
                cbMedicaments.Items.Add(i.Value.getNomCommercial());
            }
            btnValider.Enabled = false;

        }

        private void cbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnValider.Enabled = false;
            lvEtape.Items.Clear();
            lvEtapeNext.Items.Clear();

            foreach (var i in Global.medicaments)
            {
                if (i.Value.getNomCommercial().ToString() == cbMedicaments.Text)
                {
                    Medicament medoc = i.Value;
                    int idx = -1;
                    foreach (Workflow unWorkflow in medoc.getEtapes())
                    {
                        if(unWorkflow != null)
                        {
                            idx++;
                        }
                    }
                    if (idx >= 0)
                    {
                        if (medoc.getEtapes()[idx].getIdDecision() == 2)
                        {
                            MessageBox.Show("Il n'est plus possible de saisir d'étapes pour ce médicament car sa dernière étape a été refusée.");
                            return;
                        }
                        ListViewItem ligne = new ListViewItem();
                        ligne.Text = medoc.getEtapes()[idx].getNumEtape().ToString();
                        ligne.SubItems.Add(medoc.getEtapes()[idx].getDateDecision().ToString());
                        ligne.SubItems.Add(medoc.getEtapes()[idx].getEtape().getLibelle());
                        if (medoc.getEtapes()[idx] != null &&
                            medoc.getEtapes()[idx].getEtape() != null &&
                            medoc.getEtapes()[idx].getEtape().getEtapeNormee() != null &&
                            medoc.getEtapes()[idx].getEtape().getEtapeNormee().getNorme() != null)
                        {
                            ligne.SubItems.Add(medoc.getEtapes()[idx].getEtape().getEtapeNormee().getNorme());
                        }
                        else
                        {
                            ligne.SubItems.Add("Null");
                        }
                        if (medoc.getEtapes()[idx] != null &&
                            medoc.getEtapes()[idx].getEtape() != null &&
                            medoc.getEtapes()[idx].getEtape().getEtapeNormee() != null &&
                            medoc.getEtapes()[idx].getEtape().getEtapeNormee().getDateNorme() != null)
                        {
                            ligne.SubItems.Add(medoc.getEtapes()[idx].getEtape().getEtapeNormee().getDateNorme().ToString());
                        }
                        else
                        {
                            ligne.SubItems.Add("Null");
                        }
                        lvEtape.Items.Add(ligne);
                    }

                    if (idx < 7)
                    {
                        int idx2 = idx + 1;
                        if (idx > -1)
                        {
                            if (medoc.getEtapes()[idx].getIdDecision() == 2)
                            {
                                MessageBox.Show("Il n'est plus possible de saisir d'étapes pour ce médicament car sa dernière étape a été refusée.");
                                return;
                            }
                        }
                        ListViewItem ligne2 = new ListViewItem();
                        ligne2.Text = Global.etapes[idx + 1].getNum().ToString();
                        ligne2.SubItems.Add(Global.etapes[idx + 1].getLibelle());
                        if (Global.etapes[idx + 1] != null && Global.etapes[idx + 1].getEtapeNormee() != null && Global.etapes[idx + 1].getEtapeNormee().getNorme() != null)
                        {
                            ligne2.SubItems.Add(Global.etapes[idx + 1].getEtapeNormee().getNorme());
                        }
                        else
                        {
                            ligne2.SubItems.Add("Null");
                        }
                        if (Global.etapes[idx + 1] != null && Global.etapes[idx + 1].getEtapeNormee() != null && Global.etapes[idx + 1].getEtapeNormee().getDateNorme() != null)
                        {
                            ligne2.SubItems.Add(Global.etapes[idx + 1].getEtapeNormee().getDateNorme().ToString());
                        }
                        else
                        {
                            ligne2.SubItems.Add("Null");
                        }
                        lvEtapeNext.Items.Add(ligne2);

                        btnValider.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Impossible d'afficher et de saisir la prochaine étape car l'étape précédente est la dernière.");
                    }
                break;


                }


            }

        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            string famCode = "";
            int etaNum = 0;
            string medDepotLegal = "";
            int idx = -1;
            foreach (var i in Global.medicaments)
            {

                if (i.Value.getNomCommercial().ToString() == cbMedicaments.Text)
                {
                    Medicament medoc = i.Value;
                    famCode = medoc.getCodeFamille();
                    medDepotLegal = i.Value.getDepotLegal();
                    foreach (Workflow unWorkflow in medoc.getEtapes())
                    {
                        if (unWorkflow != null)
                        {
                            idx++;
                        }
                    }
                    if (idx >= 0)
                    {
                        etaNum = i.Value.getEtapes()[idx].getEtape().getNum() + 1;
                    }
                    else
                    {
                        etaNum = 1;
                    }
                }
            }
            
            int decId;
            if (cbOui.Checked == true && cbNon.Checked == false)
            {
                decId = 1;
            }
            else if (cbNon.Checked == true && cbOui.Checked == false)
            {
                decId = 2;
            }
            else
            {
                MessageBox.Show("Veuillez cochez une case pour la décision de l'étape");
                return;
            }

            string date = dateDecision.Value.ToString("yyyy-MM-dd");

            SqlCommand command = Global.db.CreateCommand();

            command.CommandText = "INSERT INTO WORKFLOW (WOR_ETA_NUM, WOR_DEC_ID, WOR_MED_DEPOTLEGAL, WOR_DATE_DECISION) VALUES(@numEta, @decId, @medDepotLegal, @date)";

            command.Parameters.AddWithValue("@numEta", etaNum);

            command.Parameters.AddWithValue("@decId", decId);

            command.Parameters.AddWithValue("@medDepotLegal", medDepotLegal);

            command.Parameters.AddWithValue("@date", date);

            command.ExecuteNonQuery();


            MessageBox.Show("Décision enregistrée.");
            if(decId == 2)
            {
                MessageBox.Show("Aucune étape ne peut être enregistrée pour ce médicament car sa dernière étape est refusée.");
                btnValider.Enabled = false;
            }
            else
            {
                if (etaNum == 8)
                {
                    // Exécution de la requête

                    SqlCommand command2 = Global.db.CreateCommand();

                    command2.CommandText = "UPDATE MEDICAMENT SET MED_AMM = 1 WHERE MED_DEPOTLEGAL = @medDepotLegal";

                    command2.Parameters.AddWithValue("@medDepotLegal", medDepotLegal);

                    command2.ExecuteNonQuery();

                    MessageBox.Show("Nombre de médicament de cette famille mis à jour.");

                    MessageBox.Show("Aucune étape ne peut être ajoutée à ce médicament.");
                    btnValider.Enabled = false;
                }
            }
            Global.ReloadData(true);
        }
    }
}
