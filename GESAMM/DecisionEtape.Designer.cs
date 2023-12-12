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
            SuspendLayout();
            // 
            // cbMedicaments
            // 
            cbMedicaments.FormattingEnabled = true;
            cbMedicaments.Location = new Point(472, 89);
            cbMedicaments.Name = "cbMedicaments";
            cbMedicaments.Size = new Size(121, 23);
            cbMedicaments.TabIndex = 0;
            // 
            // DecisionEtape
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbMedicaments);
            Name = "DecisionEtape";
            Text = "DecisionEtape";
            WindowState = FormWindowState.Maximized;
            Load += DecisionEtape_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbMedicaments;
    }
}