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
            label1 = new Label();
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 41);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Liste des familles:";
            // 
            // lv_familles
            // 
            lv_familles.Columns.AddRange(new ColumnHeader[] { codeFamille, designationFamille, nbMedicAutorise });
            lv_familles.Location = new Point(44, 89);
            lv_familles.Name = "lv_familles";
            lv_familles.Size = new Size(444, 399);
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
            lv_medic.Location = new Point(602, 89);
            lv_medic.Name = "lv_medic";
            lv_medic.Size = new Size(444, 399);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 41);
            label2.Name = "label2";
            label2.Size = new Size(272, 20);
            label2.TabIndex = 3;
            label2.Text = "Médicaments de la famille sélectionnée";
            // 
            // medParFamille
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 537);
            Controls.Add(label2);
            Controls.Add(lv_medic);
            Controls.Add(lv_familles);
            Controls.Add(label1);
            Name = "medParFamille";
            Text = "Nombre de médicament par famille";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Label label2;
    }
}