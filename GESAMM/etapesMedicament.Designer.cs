namespace GESAMM
{
    partial class etapesMedicament
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
            lvEtapes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            cbMedicaments = new ComboBox();
            SuspendLayout();
            // 
            // lvEtapes
            // 
            lvEtapes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvEtapes.Location = new Point(12, 84);
            lvEtapes.Name = "lvEtapes";
            lvEtapes.Size = new Size(604, 247);
            lvEtapes.TabIndex = 0;
            lvEtapes.UseCompatibleStateImageBehavior = false;
            lvEtapes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Numéro";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Libelle";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Date décision";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Libelle décision";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Norme";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Date norme";
            columnHeader6.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 30);
            label1.TabIndex = 1;
            label1.Text = "Workflow des médicaments";
            // 
            // cbMedicaments
            // 
            cbMedicaments.FormattingEnabled = true;
            cbMedicaments.Location = new Point(658, 84);
            cbMedicaments.Name = "cbMedicaments";
            cbMedicaments.Size = new Size(121, 23);
            cbMedicaments.TabIndex = 2;
            cbMedicaments.SelectedIndexChanged += cbMedicaments_SelectedIndexChanged;
            // 
            // etapesMedicament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbMedicaments);
            Controls.Add(label1);
            Controls.Add(lvEtapes);
            Name = "etapesMedicament";
            Text = "etapesMedicament";
            WindowState = FormWindowState.Maximized;
            Load += etapesMedicament_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvEtapes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private ComboBox cbMedicaments;
    }
}