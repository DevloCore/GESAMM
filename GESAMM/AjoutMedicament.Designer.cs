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
            cb_famille_medicament = new ComboBox();
            nud_prix_echantillon_medicament = new NumericUpDown();
            tb_depot_legal_medicament = new TextBox();
            label_depot_legal_medicament = new Label();
            button_valider_ajout_medicament = new Button();
            tb_AMM_medicament = new TextBox();
            label_AMM_medicament = new Label();
            label_prix_echantillon_medicament = new Label();
            tb_contre_indication_medicament = new TextBox();
            label_contre_indication_medicament = new Label();
            tb_effet_medicament = new TextBox();
            label_effet_medicament = new Label();
            tb_composition_medicament = new TextBox();
            label_composition_medicament = new Label();
            label_code_famille = new Label();
            label_nom_commercial = new Label();
            tb_nom_commercial = new TextBox();
            gb_formulaire_ajout_medic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_prix_echantillon_medicament).BeginInit();
            SuspendLayout();
            // 
            // gb_formulaire_ajout_medic
            // 
            gb_formulaire_ajout_medic.BackColor = SystemColors.Control;
            gb_formulaire_ajout_medic.Controls.Add(cb_famille_medicament);
            gb_formulaire_ajout_medic.Controls.Add(nud_prix_echantillon_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_depot_legal_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_depot_legal_medicament);
            gb_formulaire_ajout_medic.Controls.Add(button_valider_ajout_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_AMM_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_AMM_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_prix_echantillon_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_contre_indication_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_contre_indication_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_effet_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_effet_medicament);
            gb_formulaire_ajout_medic.Controls.Add(tb_composition_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_composition_medicament);
            gb_formulaire_ajout_medic.Controls.Add(label_code_famille);
            gb_formulaire_ajout_medic.Controls.Add(label_nom_commercial);
            gb_formulaire_ajout_medic.Controls.Add(tb_nom_commercial);
            gb_formulaire_ajout_medic.Location = new Point(204, 19);
            gb_formulaire_ajout_medic.Margin = new Padding(3, 2, 3, 2);
            gb_formulaire_ajout_medic.Name = "gb_formulaire_ajout_medic";
            gb_formulaire_ajout_medic.Padding = new Padding(3, 2, 3, 2);
            gb_formulaire_ajout_medic.Size = new Size(398, 337);
            gb_formulaire_ajout_medic.TabIndex = 0;
            gb_formulaire_ajout_medic.TabStop = false;
            gb_formulaire_ajout_medic.Text = "Formulaire d'ajout d'un médicament";
            // 
            // cb_famille_medicament
            // 
            cb_famille_medicament.FormattingEnabled = true;
            cb_famille_medicament.Location = new Point(159, 62);
            cb_famille_medicament.Margin = new Padding(3, 2, 3, 2);
            cb_famille_medicament.Name = "cb_famille_medicament";
            cb_famille_medicament.Size = new Size(110, 23);
            cb_famille_medicament.TabIndex = 18;
            cb_famille_medicament.SelectedIndexChanged += cb_famille_medicament_SelectedIndexChanged;
            // 
            // nud_prix_echantillon_medicament
            // 
            nud_prix_echantillon_medicament.Location = new Point(159, 214);
            nud_prix_echantillon_medicament.Margin = new Padding(3, 2, 3, 2);
            nud_prix_echantillon_medicament.Maximum = new decimal(new int[] { 1241513983, 370409800, 542101, 0 });
            nud_prix_echantillon_medicament.Name = "nud_prix_echantillon_medicament";
            nud_prix_echantillon_medicament.Size = new Size(109, 23);
            nud_prix_echantillon_medicament.TabIndex = 17;
            nud_prix_echantillon_medicament.ValueChanged += nud_prix_echantillon_medicament_ValueChanged;
            // 
            // tb_depot_legal_medicament
            // 
            tb_depot_legal_medicament.Location = new Point(159, 92);
            tb_depot_legal_medicament.Margin = new Padding(3, 2, 3, 2);
            tb_depot_legal_medicament.Name = "tb_depot_legal_medicament";
            tb_depot_legal_medicament.Size = new Size(110, 23);
            tb_depot_legal_medicament.TabIndex = 16;
            tb_depot_legal_medicament.TextChanged += tb_depot_legal_medicament_TextChanged;
            // 
            // label_depot_legal_medicament
            // 
            label_depot_legal_medicament.AutoSize = true;
            label_depot_legal_medicament.Location = new Point(13, 94);
            label_depot_legal_medicament.Name = "label_depot_legal_medicament";
            label_depot_legal_medicament.Size = new Size(70, 15);
            label_depot_legal_medicament.TabIndex = 15;
            label_depot_legal_medicament.Text = "Dépot légal:";
            // 
            // button_valider_ajout_medicament
            // 
            button_valider_ajout_medicament.Location = new Point(159, 292);
            button_valider_ajout_medicament.Margin = new Padding(3, 2, 3, 2);
            button_valider_ajout_medicament.Name = "button_valider_ajout_medicament";
            button_valider_ajout_medicament.Size = new Size(91, 40);
            button_valider_ajout_medicament.TabIndex = 14;
            button_valider_ajout_medicament.Text = "Ajouter le médicament";
            button_valider_ajout_medicament.UseVisualStyleBackColor = true;
            button_valider_ajout_medicament.Click += button_valider_ajout_medicament_Click;
            // 
            // tb_AMM_medicament
            // 
            tb_AMM_medicament.Location = new Point(159, 257);
            tb_AMM_medicament.Margin = new Padding(3, 2, 3, 2);
            tb_AMM_medicament.Name = "tb_AMM_medicament";
            tb_AMM_medicament.Size = new Size(110, 23);
            tb_AMM_medicament.TabIndex = 13;
            tb_AMM_medicament.TextChanged += tb_AMM_medicament_TextChanged;
            // 
            // label_AMM_medicament
            // 
            label_AMM_medicament.AutoSize = true;
            label_AMM_medicament.Location = new Point(13, 248);
            label_AMM_medicament.Name = "label_AMM_medicament";
            label_AMM_medicament.Size = new Size(119, 30);
            label_AMM_medicament.TabIndex = 11;
            label_AMM_medicament.Text = "Autorisation de mise \r\nsur le marché:";
            // 
            // label_prix_echantillon_medicament
            // 
            label_prix_echantillon_medicament.AutoSize = true;
            label_prix_echantillon_medicament.Location = new Point(13, 216);
            label_prix_echantillon_medicament.Name = "label_prix_echantillon_medicament";
            label_prix_echantillon_medicament.Size = new Size(114, 15);
            label_prix_echantillon_medicament.TabIndex = 10;
            label_prix_echantillon_medicament.Text = "Prix de l'echantillon:";
            // 
            // tb_contre_indication_medicament
            // 
            tb_contre_indication_medicament.Location = new Point(159, 180);
            tb_contre_indication_medicament.Margin = new Padding(3, 2, 3, 2);
            tb_contre_indication_medicament.Name = "tb_contre_indication_medicament";
            tb_contre_indication_medicament.Size = new Size(110, 23);
            tb_contre_indication_medicament.TabIndex = 9;
            tb_contre_indication_medicament.TextChanged += tb_contre_indication_medicament_TextChanged;
            // 
            // label_contre_indication_medicament
            // 
            label_contre_indication_medicament.AutoSize = true;
            label_contre_indication_medicament.Location = new Point(13, 182);
            label_contre_indication_medicament.Name = "label_contre_indication_medicament";
            label_contre_indication_medicament.Size = new Size(109, 15);
            label_contre_indication_medicament.TabIndex = 8;
            label_contre_indication_medicament.Text = "Contre-indications:";
            // 
            // tb_effet_medicament
            // 
            tb_effet_medicament.Location = new Point(159, 152);
            tb_effet_medicament.Margin = new Padding(3, 2, 3, 2);
            tb_effet_medicament.Name = "tb_effet_medicament";
            tb_effet_medicament.Size = new Size(110, 23);
            tb_effet_medicament.TabIndex = 7;
            tb_effet_medicament.TextChanged += tb_effet_medicament_TextChanged;
            // 
            // label_effet_medicament
            // 
            label_effet_medicament.AutoSize = true;
            label_effet_medicament.Location = new Point(13, 154);
            label_effet_medicament.Name = "label_effet_medicament";
            label_effet_medicament.Size = new Size(39, 15);
            label_effet_medicament.TabIndex = 6;
            label_effet_medicament.Text = "Effets:";
            // 
            // tb_composition_medicament
            // 
            tb_composition_medicament.Location = new Point(159, 124);
            tb_composition_medicament.Margin = new Padding(3, 2, 3, 2);
            tb_composition_medicament.Name = "tb_composition_medicament";
            tb_composition_medicament.Size = new Size(110, 23);
            tb_composition_medicament.TabIndex = 5;
            tb_composition_medicament.TextChanged += tb_composition_medicament_TextChanged;
            // 
            // label_composition_medicament
            // 
            label_composition_medicament.AutoSize = true;
            label_composition_medicament.Location = new Point(13, 126);
            label_composition_medicament.Name = "label_composition_medicament";
            label_composition_medicament.Size = new Size(82, 15);
            label_composition_medicament.TabIndex = 4;
            label_composition_medicament.Text = "Composition: ";
            // 
            // label_code_famille
            // 
            label_code_famille.AutoSize = true;
            label_code_famille.Location = new Point(13, 64);
            label_code_famille.Name = "label_code_famille";
            label_code_famille.Size = new Size(105, 15);
            label_code_famille.TabIndex = 2;
            label_code_famille.Text = "Code de la famille:";
            // 
            // label_nom_commercial
            // 
            label_nom_commercial.AutoSize = true;
            label_nom_commercial.Location = new Point(13, 34);
            label_nom_commercial.Name = "label_nom_commercial";
            label_nom_commercial.Size = new Size(106, 15);
            label_nom_commercial.TabIndex = 1;
            label_nom_commercial.Text = "Nom commercial :";
            // 
            // tb_nom_commercial
            // 
            tb_nom_commercial.Location = new Point(159, 32);
            tb_nom_commercial.Margin = new Padding(3, 2, 3, 2);
            tb_nom_commercial.Name = "tb_nom_commercial";
            tb_nom_commercial.Size = new Size(110, 23);
            tb_nom_commercial.TabIndex = 0;
            tb_nom_commercial.TextChanged += tb_nom_commercial_TextChanged;
            // 
            // AjoutMedicament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(791, 405);
            Controls.Add(gb_formulaire_ajout_medic);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AjoutMedicament";
            Text = "Ajout de médicament";
            WindowState = FormWindowState.Maximized;
            gb_formulaire_ajout_medic.ResumeLayout(false);
            gb_formulaire_ajout_medic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_prix_echantillon_medicament).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_formulaire_ajout_medic;
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
        private Label label_AMM_medicament;
        private TextBox tb_depot_legal_medicament;
        private Label label_depot_legal_medicament;
        private NumericUpDown nud_prix_echantillon_medicament;
        private ComboBox cb_famille_medicament;
    }
}