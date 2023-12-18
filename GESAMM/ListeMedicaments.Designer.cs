namespace GESAMM
{
    partial class ListeMedicaments
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
            cb_enValid = new CheckBox();
            label1 = new Label();
            columnHeader8 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listMedicaments = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            SuspendLayout();
            // 
            // cb_enValid
            // 
            cb_enValid.AutoSize = true;
            cb_enValid.Location = new Point(460, 32);
            cb_enValid.Margin = new Padding(3, 2, 3, 2);
            cb_enValid.Name = "cb_enValid";
            cb_enValid.Size = new Size(142, 19);
            cb_enValid.TabIndex = 2;
            cb_enValid.Text = "En cours de validation";
            cb_enValid.UseVisualStyleBackColor = true;
            cb_enValid.CheckedChanged += cb_enValid_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 21);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 1;
            label1.Text = "Liste des médicaments";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "AMM";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Contre indications";
            columnHeader6.Width = 160;
            // 
            // listMedicaments
            // 
            listMedicaments.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listMedicaments.FullRowSelect = true;
            listMedicaments.Location = new Point(10, 69);
            listMedicaments.Margin = new Padding(3, 2, 3, 2);
            listMedicaments.MultiSelect = false;
            listMedicaments.Name = "listMedicaments";
            listMedicaments.Size = new Size(1084, 402);
            listMedicaments.TabIndex = 0;
            listMedicaments.UseCompatibleStateImageBehavior = false;
            listMedicaments.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dépôt légal";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom commercial";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Famille";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Composition";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Effets";
            columnHeader5.Width = 160;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Prix échantillon";
            columnHeader7.Width = 120;
            // 
            // ListeMedicaments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(cb_enValid);
            Controls.Add(label1);
            Controls.Add(listMedicaments);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListeMedicaments";
            Text = "Liste Medicaments";
            WindowState = FormWindowState.Maximized;
            Load += ListeMedicaments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listMedicaments;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label1;
        private CheckBox cb_enValid;
    }
}