namespace GESAMM
{
    partial class ListeEtapes
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
            this.listViewEtapeNormees = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.buttonEditNorme = new System.Windows.Forms.Button();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.datePickerNorme = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewEtapeNormees
            // 
            this.listViewEtapeNormees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEtapeNormees.FullRowSelect = true;
            this.listViewEtapeNormees.Location = new System.Drawing.Point(12, 12);
            this.listViewEtapeNormees.Name = "listViewEtapeNormees";
            this.listViewEtapeNormees.Size = new System.Drawing.Size(696, 325);
            this.listViewEtapeNormees.TabIndex = 0;
            this.listViewEtapeNormees.UseCompatibleStateImageBehavior = false;
            this.listViewEtapeNormees.View = System.Windows.Forms.View.Details;
            this.listViewEtapeNormees.SelectedIndexChanged += new System.EventHandler(this.listViewEtapeNormees_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro étape";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Est normée ?";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Norme";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date de la norme";
            this.columnHeader4.Width = 140;
            // 
            // buttonEditNorme
            // 
            this.buttonEditNorme.Enabled = false;
            this.buttonEditNorme.Location = new System.Drawing.Point(750, 308);
            this.buttonEditNorme.Name = "buttonEditNorme";
            this.buttonEditNorme.Size = new System.Drawing.Size(264, 29);
            this.buttonEditNorme.TabIndex = 1;
            this.buttonEditNorme.Text = "Modifier la norme";
            this.buttonEditNorme.UseVisualStyleBackColor = true;
            this.buttonEditNorme.Click += new System.EventHandler(this.buttonEditNorme_Click);
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(750, 184);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(264, 27);
            this.tbNorme.TabIndex = 2;
            // 
            // datePickerNorme
            // 
            this.datePickerNorme.Location = new System.Drawing.Point(750, 245);
            this.datePickerNorme.Name = "datePickerNorme";
            this.datePickerNorme.Size = new System.Drawing.Size(264, 27);
            this.datePickerNorme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(750, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Norme (laissez vide si aucune)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(750, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date de la norme";
            // 
            // ListeEtapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerNorme);
            this.Controls.Add(this.tbNorme);
            this.Controls.Add(this.buttonEditNorme);
            this.Controls.Add(this.listViewEtapeNormees);
            this.Name = "ListeEtapes";
            this.Text = "Liste des étapes normées";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListeEtapes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewEtapeNormees;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonEditNorme;
        private TextBox tbNorme;
        private DateTimePicker datePickerNorme;
        private Label label1;
        private Label label2;
    }
}