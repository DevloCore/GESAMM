namespace GESAMM
{
    partial class AjoutMedicament
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
            gb_formulaire_ajout_medic = new GroupBox();
            tb_depot_legal_medicament = new TextBox();
            label_depot_legal_medicament = new Label();
            button_valider_ajout_medicament = new Button();
            tb_AMM_medicament = new TextBox();
            tb_prix_echantillon_medicament = new TextBox();
            label_AMM_medicament = new Label();
            label_prix_echantillon_medicament = new Label();
            tb_contre_indication_medicament = new TextBox();
            label_contre_indication_medicament = new Label();
            tb_effet_medicament = new TextBox();
            label_effet_medicament = new Label();
            tb_composition_medicament = new TextBox();
            label_composition_medicament = new Label();
            tb_code_famille = new TextBox();
            label_code_famille = new Label();
            label_nom_commercial = new Label();
            tb_nom_commercial = new TextBox();
            numericUpDown1 = new NumericUpDown();
            gb_formulaire_ajout_medic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // gb_formulaire_ajout_medic
            // 
            gb_formulaire_ajout_medic.Controls.Add(numericUpDown1);
            gb_formulaire_ajout_medic.Controls.Add(tb_depot_legal_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_depot_legal_medicament);
            gb_formulaire_ajout_medic.Controls.Add(button_valider_ajout_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_AMM_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_prix_echantillon_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_AMM_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_prix_echantillon_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_contre_indication_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_contre_indication_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_effet_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_effet_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_composition_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_composition_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_code_famille);
            gb_formulaire_ajout_medic.Controls.Add(label_code_famille);
            gb_formulaire_ajout_medic.Controls.Add(label_nom_commercial);
            gb_formulaire_ajout_medic.Controls.Add(tb_nom_commercial);
            gb_formulaire_ajout_medic.Location = new Point(233, 25);
            gb_formulaire_ajout_medic.Name = "gb_formulaire_ajout_medic";
            gb_formulaire_ajout_medic.Size = new Size(455, 449);
            gb_formulaire_ajout_medic.TabIndex = 0;
            gb_formulaire_ajout_medic.TabStop = false;
            gb_formulaire_ajout_medic.Text = "Formulaire d'ajout d'un médicament";
            // 
            // tb_depot_legal_medicament
            // 
            tb_depot_legal_medicament.Location = new Point(182, 123);
            tb_depot_legal_medicament.Name = "tb_depot_legal_medicament";
            tb_depot_legal_medicament.Size = new Size(125, 27);
            tb_depot_legal_medicament.TabIndex = 16;
            tb_depot_legal_medicament.TextChanged += tb_depot_legal_medicament_TextChanged;
            // 
            // label_depot_legal_medicament
            // 
            label_depot_legal_medicament.AutoSize = true;
            label_depot_legal_medicament.Location = new Point(15, 126);
            label_depot_legal_medicament.Name = "label_depot_legal_medicament";
            label_depot_legal_medicament.Size = new Size(91, 20);
            label_depot_legal_medicament.TabIndex = 15;
            label_depot_legal_medicament.Text = "Dépot légal:";
            // 
            // button_valider_ajout_medicament
            // 
            button_valider_ajout_medicament.Location = new Point(182, 390);
            button_valider_ajout_medicament.Name = "button_valider_ajout_medicament";
            button_valider_ajout_medicament.Size = new Size(104, 53);
            button_valider_ajout_medicament.TabIndex = 14;
            button_valider_ajout_medicament.Text = "Ajouter le médicament";
            button_valider_ajout_medicament.UseVisualStyleBackColor = true;
            button_valider_ajout_medicament.Click += button_valider_ajout_medicament_Click;
            // 
            // tb_AMM_medicament
            // 
            tb_AMM_medicament.Location = new Point(182, 343);
            tb_AMM_medicament.Name = "tb_AMM_medicament";
            tb_AMM_medicament.Size = new Size(125, 27);
            tb_AMM_medicament.TabIndex = 13;
            tb_AMM_medicament.TextChanged += tb_AMM_medicament_TextChanged;
            // 
            // tb_prix_echantillon_medicament
            // 
            tb_prix_echantillon_medicament.Location = new Point(182, 285);
            tb_prix_echantillon_medicament.Name = "tb_prix_echantillon_medicament";
            tb_prix_echantillon_medicament.Size = new Size(125, 27);
            tb_prix_echantillon_medicament.TabIndex = 12;
            tb_prix_echantillon_medicament.TextChanged += tb_prix_echantillon_medicament_TextChanged;
            // 
            // label_AMM_medicament
            // 
            label_AMM_medicament.AutoSize = true;
            label_AMM_medicament.Location = new Point(15, 330);
            label_AMM_medicament.Name = "label_AMM_medicament";
            label_AMM_medicament.Size = new Size(150, 40);
            label_AMM_medicament.TabIndex = 11;
            label_AMM_medicament.Text = "Autorisation de mise \r\nsur le marché:";
            // 
            // label_prix_echantillon_medicament
            // 
            label_prix_echantillon_medicament.AutoSize = true;
            label_prix_echantillon_medicament.Location = new Point(15, 288);
            label_prix_echantillon_medicament.Name = "label_prix_echantillon_medicament";
            label_prix_echantillon_medicament.Size = new Size(141, 20);
            label_prix_echantillon_medicament.TabIndex = 10;
            label_prix_echantillon_medicament.Text = "Prix de l'echantillon:";
            // 
            // tb_contre_indication_medicament
            // 
            tb_contre_indication_medicament.Location = new Point(182, 240);
            tb_contre_indication_medicament.Name = "tb_contre_indication_medicament";
            tb_contre_indication_medicament.Size = new Size(125, 27);
            tb_contre_indication_medicament.TabIndex = 9;
            tb_contre_indication_medicament.TextChanged += tb_contre_indication_medicament_TextChanged;
            // 
            // label_contre_indication_medicament
            // 
            label_contre_indication_medicament.AutoSize = true;
            label_contre_indication_medicament.Location = new Point(15, 243);
            label_contre_indication_medicament.Name = "label_contre_indication_medicament";
            label_contre_indication_medicament.Size = new Size(134, 20);
            label_contre_indication_medicament.TabIndex = 8;
            label_contre_indication_medicament.Text = "Contre-indications:";
            // 
            // tb_effet_medicament
            // 
            tb_effet_medicament.Location = new Point(182, 202);
            tb_effet_medicament.Name = "tb_effet_medicament";
            tb_effet_medicament.Size = new Size(125, 27);
            tb_effet_medicament.TabIndex = 7;
            tb_effet_medicament.TextChanged += tb_effet_medicament_TextChanged;
            // 
            // label_effet_medicament
            // 
            label_effet_medicament.AutoSize = true;
            label_effet_medicament.Location = new Point(15, 205);
            label_effet_medicament.Name = "label_effet_medicament";
            label_effet_medicament.Size = new Size(49, 20);
            label_effet_medicament.TabIndex = 6;
            label_effet_medicament.Text = "Effets:";
            // 
            // tb_composition_medicament
            // 
            tb_composition_medicament.Location = new Point(182, 165);
            tb_composition_medicament.Name = "tb_composition_medicament";
            tb_composition_medicament.Size = new Size(125, 27);
            tb_composition_medicament.TabIndex = 5;
            tb_composition_medicament.TextChanged += tb_composition_medicament_TextChanged;
            // 
            // label_composition_medicament
            // 
            label_composition_medicament.AutoSize = true;
            label_composition_medicament.Location = new Point(15, 168);
            label_composition_medicament.Name = "label_composition_medicament";
            label_composition_medicament.Size = new Size(101, 20);
            label_composition_medicament.TabIndex = 4;
            label_composition_medicament.Text = "Composition: ";
            // 
            // tb_code_famille
            // 
            tb_code_famille.Location = new Point(182, 82);
            tb_code_famille.Name = "tb_code_famille";
            tb_code_famille.Size = new Size(125, 27);
            tb_code_famille.TabIndex = 3;
            tb_code_famille.TextChanged += tb_code_famille_TextChanged;
            // 
            // label_code_famille
            // 
            label_code_famille.AutoSize = true;
            label_code_famille.Location = new Point(15, 85);
            label_code_famille.Name = "label_code_famille";
            label_code_famille.Size = new Size(134, 20);
            label_code_famille.TabIndex = 2;
            label_code_famille.Text = "Code de la famille:";
            // 
            // label_nom_commercial
            // 
            label_nom_commercial.AutoSize = true;
            label_nom_commercial.Location = new Point(15, 45);
            label_nom_commercial.Name = "label_nom_commercial";
            label_nom_commercial.Size = new Size(131, 20);
            label_nom_commercial.TabIndex = 1;
            label_nom_commercial.Text = "Nom commercial :";
            // 
            // tb_nom_commercial
            // 
            tb_nom_commercial.Location = new Point(182, 42);
            tb_nom_commercial.Name = "tb_nom_commercial";
            tb_nom_commercial.Size = new Size(125, 27);
            tb_nom_commercial.TabIndex = 0;
            tb_nom_commercial.TextChanged += tb_nom_commercial_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(339, 285);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 27);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Minimum = 0;
            // 
            // AjoutMedicament
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 540);
            Controls.Add(gb_formulaire_ajout_medic);
            Name = "AjoutMedicament";
            Text = "Ajout de médicament";
            gb_formulaire_ajout_medic.ResumeLayout(false);
            gb_formulaire_ajout_medic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_formulaire_ajout_medic;
        private TextBox tb_code_famille;
        private Label label_code_famille;
        private Label label_nom_commercial;
        private TextBox tb_nom_commercial;
        private Label label_contre_indication_medicament;
        private TextBox tb_effet_medicament;
        private Label label_effet_medicament;
        private TextBox tb_composition_medicament;
        private Label label_composition_medicament;
        private Label label_prix_echantillon_medicament;
        private TextBox tb_contre_indication_medicament;
        private Button button_valider_ajout_medicament;
        private TextBox tb_AMM_medicament;
        private TextBox tb_prix_echantillon_medicament;
        private Label label_AMM_medicament;
        private TextBox tb_depot_legal_medicament;
        private Label label_depot_legal_medicament;
        private NumericUpDown numericUpDown1;
    }
}