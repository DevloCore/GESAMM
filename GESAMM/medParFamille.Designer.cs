namespace GESAMM
{
    partial class medParFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lv_familles = new ListView();
            codeFamille = new ColumnHeader();
            designationFamille = new ColumnHeader();
            nbMedicAutorise = new ColumnHeader();
            lv_medic = new ListView();
            depotLegal = new ColumnHeader();
            nomCommercial = new ColumnHeader();
            composition = new ColumnHeader();
            effets = new ColumnHeader();
            contreIndication = new ColumnHeader();
            prixEchantillon = new ColumnHeader();
            amm = new ColumnHeader();
            gb_liste_famille_medicament = new GroupBox();
            gb_medic_par_famille = new GroupBox();
            gb_liste_famille_medicament.SuspendLayout();
            gb_medic_par_famille.SuspendLayout();
            SuspendLayout();
            // 
            // lv_familles
            // 
            lv_familles.Columns.AddRange(new ColumnHeader[] { codeFamille, designationFamille, nbMedicAutorise });
            lv_familles.Location = new Point(4, 29);
            lv_familles.Name = "lv_familles";
            lv_familles.Size = new Size(389, 300);
            lv_familles.TabIndex = 1;
            lv_familles.UseCompatibleStateImageBehavior = false;
            lv_familles.View = View.Details;
            lv_familles.SelectedIndexChanged += lv_familles_SelectedIndexChanged;
            // 
            // codeFamille
            // 
            codeFamille.Text = "Code";
            codeFamille.Width = 47;
            // 
            // designationFamille
            // 
            designationFamille.Text = "Désignation";
            designationFamille.Width = 92;
            // 
            // nbMedicAutorise
            // 
            nbMedicAutorise.Text = "Nombre de médicament autorisé";
            nbMedicAutorise.Width = 301;
            // 
            // lv_medic
            // 
            lv_medic.Columns.AddRange(new ColumnHeader[] { depotLegal, nomCommercial, composition, effets, contreIndication, prixEchantillon, amm });
            lv_medic.Location = new Point(6, 29);
            lv_medic.Name = "lv_medic";
            lv_medic.Size = new Size(389, 300);
            lv_medic.TabIndex = 2;
            lv_medic.UseCompatibleStateImageBehavior = false;
            lv_medic.View = View.Details;
            // 
            // depotLegal
            // 
            depotLegal.Text = "Dépot Légal";
            depotLegal.Width = 94;
            // 
            // nomCommercial
            // 
            nomCommercial.Text = "Nom Commercial";
            nomCommercial.Width = 129;
            // 
            // composition
            // 
            composition.Text = "Composition";
            composition.Width = 97;
            // 
            // effets
            // 
            effets.Text = "Effets";
            effets.Width = 49;
            // 
            // contreIndication
            // 
            contreIndication.Text = "Contre-Indications";
            contreIndication.Width = 134;
            // 
            // prixEchantillon
            // 
            prixEchantillon.Text = "Prix de l'échantillon";
            prixEchantillon.Width = 141;
            // 
            // amm
            // 
            amm.Text = "Autorisation de mise sur le marché";
            amm.Width = 241;
            // 
            // gb_liste_famille_medicament
            // 
            gb_liste_famille_medicament.BackColor = SystemColors.Control;
            gb_liste_famille_medicament.Controls.Add(lv_familles);
            gb_liste_famille_medicament.Location = new Point(40, 60);
            gb_liste_famille_medicament.Name = "gb_liste_famille_medicament";
            gb_liste_famille_medicament.Size = new Size(453, 434);
            gb_liste_famille_medicament.TabIndex = 4;
            gb_liste_famille_medicament.TabStop = false;
            gb_liste_famille_medicament.Text = "Liste des familles:";
            // 
            // gb_medic_par_famille
            // 
            gb_medic_par_famille.BackColor = SystemColors.Control;
            gb_medic_par_famille.Controls.Add(lv_medic);
            gb_medic_par_famille.Location = new Point(602, 60);
            gb_medic_par_famille.Name = "gb_medic_par_famille";
            gb_medic_par_famille.Size = new Size(453, 434);
            gb_medic_par_famille.TabIndex = 5;
            gb_medic_par_famille.TabStop = false;
            gb_medic_par_famille.Text = "Médicaments de la famille sélectionnée";
            // 
            // medParFamille
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 537);
            Controls.Add(gb_medic_par_famille);
            Controls.Add(gb_liste_famille_medicament);
            Name = "medParFamille";
            Text = "Nombre de médicament par famille";
            WindowState = FormWindowState.Maximized;
            gb_liste_famille_medicament.ResumeLayout(false);
            gb_medic_par_famille.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView lv_familles;
        private ColumnHeader codeFamille;
        private ColumnHeader designationFamille;
        private ColumnHeader nbMedicAutorise;
        private ListView lv_medic;
        private ColumnHeader depotLegal;
        private ColumnHeader nomCommercial;
        private ColumnHeader composition;
        private ColumnHeader effets;
        private ColumnHeader contreIndication;
        private ColumnHeader prixEchantillon;
        private ColumnHeader amm;
        private GroupBox gb_liste_famille_medicament;
        private GroupBox gb_medic_par_famille;
    }
}