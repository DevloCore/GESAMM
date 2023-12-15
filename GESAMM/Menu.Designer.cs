namespace GESAMM
{
    partial class Menu
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
            médicamentsToolStripMenuItem = new ToolStripMenuItem();
            consulterToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            decisionToolStripMenuItem1 = new ToolStripMenuItem();
            decisionEtapeToolStripMenuItem2 = new ToolStripMenuItem();
            familleToolStripMenuItem = new ToolStripMenuItem();
            nombreDeMédicamentParFamilleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // médicamentsToolStripMenuItem
            // 
            médicamentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulterToolStripMenuItem, ajouterToolStripMenuItem });
            médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            médicamentsToolStripMenuItem.Size = new Size(91, 20);
            médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // consulterToolStripMenuItem
            // 
            consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            consulterToolStripMenuItem.Size = new Size(180, 22);
            consulterToolStripMenuItem.Text = "Consulter";
            consulterToolStripMenuItem.Click += consulterToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(180, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { médicamentsToolStripMenuItem, decisionToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1104, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // decisionToolStripMenuItem1
            // 
            decisionToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { decisionEtapeToolStripMenuItem2 });
            decisionToolStripMenuItem1.Name = "decisionToolStripMenuItem1";
            decisionToolStripMenuItem1.Size = new Size(64, 20);
            decisionToolStripMenuItem1.Text = "Décision";
            // 
            // decisionEtapeToolStripMenuItem2
            // 
            decisionEtapeToolStripMenuItem2.Name = "decisionEtapeToolStripMenuItem2";
            decisionEtapeToolStripMenuItem2.Size = new Size(180, 22);
            decisionEtapeToolStripMenuItem2.Text = "Etape";
            decisionEtapeToolStripMenuItem2.Click += decisionEtapeToolStripMenuItem2_Click;
            // 
            // familleToolStripMenuItem
            // 
            familleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreDeMédicamentParFamilleToolStripMenuItem });
            familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            familleToolStripMenuItem.Size = new Size(178, 24);
            familleToolStripMenuItem.Text = "Famille de médicament";
            // 
            // nombreDeMédicamentParFamilleToolStripMenuItem
            // 
            nombreDeMédicamentParFamilleToolStripMenuItem.Name = "nombreDeMédicamentParFamilleToolStripMenuItem";
            nombreDeMédicamentParFamilleToolStripMenuItem.Size = new Size(331, 26);
            nombreDeMédicamentParFamilleToolStripMenuItem.Text = "Nombre de médicament par famille";
            nombreDeMédicamentParFamilleToolStripMenuItem.Click += nombreDeMédicamentParFamilleToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem médicamentsToolStripMenuItem;
        private ToolStripMenuItem consulterToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem decisionToolStripMenuItem1;
        private ToolStripMenuItem decisionEtapeToolStripMenuItem2;
        private ToolStripMenuItem familleToolStripMenuItem;
        private ToolStripMenuItem nombreDeMédicamentParFamilleToolStripMenuItem;
    }
}