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
        }

        private string depotLegal;
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

        private void tb_code_famille_TextChanged(object sender, EventArgs e)
        {
            this.fam_code = tb_code_famille.Text;
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

        private void tb_prix_echantillon_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_prixEchantillon = tb_prix_echantillon_medicament.Text;
        }

        private void tb_AMM_medicament_TextChanged(object sender, EventArgs e)
        {
            this.med_amm = tb_AMM_medicament.Text;
        }

        private void button_valider_ajout_medicament_Click(object sender, EventArgs e)
        {
            if (med_nomCommercial != null && fam_code != null && med_depotLegal != null && med_composition != null && medEffets != null && medContreIndic != null && medPrixEchantillon != null && medAMM != null)
            {
                string temp = "INSERT INTO MEDICAMENT VALUES ('" + nomCommercial + "','" + codeFamille + "','" + medCompo + "','" + medCompo + "','" + medEffets + "','" + medContreIndic + "','" + medPrixEchantillon + "','" + medAMM + "')";
                MessageBox.Show(temp);

                //objet SQLCommand pour définir la procédure stockée à utiliser
                SqlCommand maRequete = new SqlCommand("prc_ajout_medicament", Global.db);
                maRequete.CommandType = System.Data.CommandType.StoredProcedure;
                maRequete.Parameters.AddWithValue("@med_depotLegal", tb_depot_legal_medicament.Text);
                //CA MARCHE CA AU DESSUS !!!!!


                // exécuter la procedure stockée dans un curseur 
                SqlDataReader SqlExec = maRequete.ExecuteReader();

            }

            else
            {
                MessageBox.Show("Une données ou plus n'est pas correcte.");
            }
        }
    }
}
