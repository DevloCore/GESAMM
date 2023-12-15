using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESAMM
{
    public partial class AjoutMedicament : Form
    {
        public AjoutMedicament()
        {
            InitializeComponent();

            foreach (Famille uneFamille in Global.familles.Values)
            {
                cb_famille_medicament.Items.Add(uneFamille.getCode());
            }
        }

        private string med_depotLegal;
        private string @med_nomCommercial;
        private string @fam_code;
        private string @med_composition;
        private string @med_effets;
        private string @med_contreIndications;
        private string @med_prixEchantillon;
        private string @med_amm;

        private void tb_nom_commercial_TextChanged(object sender, EventArgs e)
        {
            this.med_nomCommercial = tb_nom_commercial.Text;
        }
        private void cb_famille_medicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fam_code = cb_famille_medicament.Text;
        }

        private void tb_depot_legal_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_depotLegal = tb_depot_legal_medicament.Text;
        }

        private void tb_composition_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_composition = tb_composition_medicament.Text;
        }

        private void tb_effet_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_effets = tb_effet_medicament.Text;
        }

        private void tb_contre_indication_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_contreIndications = tb_contre_indication_medicament.Text;
        }
        private void nud_prix_echantillon_medicament_ValueChanged(object sender, EventArgs e)
        {
            this.med_prixEchantillon = nud_prix_echantillon_medicament.Value.ToString();
        }

        private void tb_AMM_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_amm = tb_AMM_medicament.Text;
        }

        private void button_valider_ajout_medicament_Click(object sender, EventArgs e)
        {
            try
            {
                if (med_nomCommercial != null || fam_code != null || med_depotLegal != null || med_composition != null || med_effets != null || med_contreIndications != null || med_prixEchantillon != null || med_amm != null)
                {
                    SqlCommand maRequete = new SqlCommand("dbo.prc_ajout_medicament", Global.db);
                    maRequete.CommandType = System.Data.CommandType.StoredProcedure;
                    maRequete.Parameters.AddWithValue("@med_depotLegal", tb_depot_legal_medicament.Text);
                    maRequete.Parameters.AddWithValue("@med_nomCommercial", tb_nom_commercial.Text);
                    maRequete.Parameters.AddWithValue("@fam_code", cb_famille_medicament.Text);
                    maRequete.Parameters.AddWithValue("@med_composition", tb_composition_medicament.Text);
                    maRequete.Parameters.AddWithValue("@med_effets", tb_effet_medicament.Text);
                    maRequete.Parameters.AddWithValue("@med_contreIndications", tb_contre_indication_medicament.Text);
                    maRequete.Parameters.AddWithValue("@med_prixEchantillon", nud_prix_echantillon_medicament.Text);
                    maRequete.Parameters.AddWithValue("@med_amm", tb_AMM_medicament.Text);
                    
                    int rowsAffected = maRequete.ExecuteNonQuery();

                    if (rowsAffected < 0)
                    {
                        MessageBox.Show("Le médicament a bien été ajouté.");
                        tb_depot_legal_medicament.Clear();
                        tb_nom_commercial.Clear();
                        cb_famille_medicament.SelectedItem = null;
                        tb_composition_medicament.Clear();
                        tb_effet_medicament.Clear();
                        tb_contre_indication_medicament.Clear();
                        nud_prix_echantillon_medicament.Value = 0;
                        tb_AMM_medicament.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Aucune ligne n'a été affectée. Vérifiez vos données ou contactez l'administrateur.");
                    }
                }
                else
                {
                    MessageBox.Show("Une donnée ou plus n'est pas correcte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exécution de la requête SQL : " + ex.Message);
            }
        }

    }
}
