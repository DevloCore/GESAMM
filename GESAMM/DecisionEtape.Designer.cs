namespace GESAMM
{
    partial class DecisionEtape
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
            cbMedicaments = new ComboBox();
            lvEtape = new ListView();
            id = new ColumnHeader();
            date = new ColumnHeader();
            libelle = new ColumnHeader();
            norme = new ColumnHeader();
            dateNorme = new ColumnHeader();
            lvEtapeNext = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnValider = new Button();
            cbNon = new CheckBox();
            cbOui = new CheckBox();
            dateDecision = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbMedicaments
            // 
            cbMedicaments.FormattingEnabled = true;
            cbMedicaments.Location = new Point(611, 33);
            cbMedicaments.Name = "cbMedicaments";
            cbMedicaments.Size = new Size(121, 23);
            cbMedicaments.TabIndex = 0;
            cbMedicaments.SelectedIndexChanged += cbMedicaments_SelectedIndexChanged;
            // 
            // lvEtape
            // 
            lvEtape.Columns.AddRange(new ColumnHeader[] { id, date, libelle, norme, dateNorme });
            lvEtape.Location = new Point(35, 33);
            lvEtape.Name = "lvEtape";
            lvEtape.Size = new Size(495, 97);
            lvEtape.TabIndex = 1;
            lvEtape.UseCompatibleStateImageBehavior = false;
            lvEtape.View = View.Details;
            // 
            // id
            // 
            id.Text = "Id";
            id.Width = 100;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 100;
            // 
            // libelle
            // 
            libelle.Text = "Libelle";
            libelle.Width = 100;
            // 
            // norme
            // 
            norme.Text = "Norme";
            norme.Width = 100;
            // 
            // dateNorme
            // 
            dateNorme.Text = "Date de la norme";
            dateNorme.Width = 100;
            // 
            // lvEtapeNext
            // 
            lvEtapeNext.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5 });
            lvEtapeNext.Location = new Point(35, 33);
            lvEtapeNext.Name = "lvEtapeNext";
            lvEtapeNext.Size = new Size(495, 97);
            lvEtapeNext.TabIndex = 2;
            lvEtapeNext.UseCompatibleStateImageBehavior = false;
            lvEtapeNext.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Libelle";
            columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Norme";
            columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Date de la norme";
            columnHeader5.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvEtape);
            groupBox1.Controls.Add(cbMedicaments);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 159);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dernière étape validée du médicament choisie";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnValider);
            groupBox2.Controls.Add(cbNon);
            groupBox2.Controls.Add(cbOui);
            groupBox2.Controls.Add(dateDecision);
            groupBox2.Controls.Add(lvEtapeNext);
            groupBox2.Location = new Point(12, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 222);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Etape n+1";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(616, 155);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(143, 38);
            btnValider.TabIndex = 6;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // cbNon
            // 
            cbNon.AutoSize = true;
            cbNon.Location = new Point(559, 93);
            cbNon.Name = "cbNon";
            cbNon.Size = new Size(67, 19);
            cbNon.TabIndex = 5;
            cbNon.Text = "Refusée";
            cbNon.UseVisualStyleBackColor = true;
            // 
            // cbOui
            // 
            cbOui.AutoSize = true;
            cbOui.Location = new Point(559, 68);
            cbOui.Name = "cbOui";
            cbOui.Size = new Size(63, 19);
            cbOui.TabIndex = 4;
            cbOui.Text = "Validée";
            cbOui.UseVisualStyleBackColor = true;
            // 
            // dateDecision
            // 
            dateDecision.Location = new Point(559, 33);
            dateDecision.Name = "dateDecision";
            dateDecision.Size = new Size(200, 23);
            dateDecision.TabIndex = 3;
            // 
            // DecisionEtape
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DecisionEtape";
            Text = "DecisionEtape";
            WindowState = FormWindowState.Maximized;
            Load += DecisionEtape_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbMedicaments;
        private ListView lvEtape;
        private ColumnHeader id;
        private ColumnHeader date;
        private ColumnHeader libelle;
        private ColumnHeader norme;
        private ColumnHeader dateNorme;
        private ListView lvEtapeNext;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox cbNon;
        private CheckBox cbOui;
        private DateTimePicker dateDecision;
        private Button btnValider;
    }
}