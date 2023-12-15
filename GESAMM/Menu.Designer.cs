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
            familleDeMédicamentToolStripMenuItem = new ToolStripMenuItem();
            nombreDeMédicamentParFamilleToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            workflowToolStripMenuItem2 = new ToolStripMenuItem();
            familleToolStripMenuItem = new ToolStripMenuItem();
            nombreDeMédicamentParFamilleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // médicamentsToolStripMenuItem
            // 
            médicamentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulterToolStripMenuItem, ajouterToolStripMenuItem });
            médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            médicamentsToolStripMenuItem.Size = new Size(112, 24);
            médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // consulterToolStripMenuItem
            // 
            consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            consulterToolStripMenuItem.Size = new Size(154, 26);
            consulterToolStripMenuItem.Text = "Consulter";
            consulterToolStripMenuItem.Click += consulterToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(154, 26);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { médicamentsToolStripMenuItem, decisionToolStripMenuItem1, familleDeMédicamentToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1262, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // decisionToolStripMenuItem1
            // 
            decisionToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { decisionEtapeToolStripMenuItem2 });
            decisionToolStripMenuItem1.Name = "decisionToolStripMenuItem1";
            decisionToolStripMenuItem1.Size = new Size(80, 24);
            decisionToolStripMenuItem1.Text = "Décision";
            // 
            // decisionEtapeToolStripMenuItem2
            // 
            decisionEtapeToolStripMenuItem2.Name = "decisionEtapeToolStripMenuItem2";
            decisionEtapeToolStripMenuItem2.Size = new Size(130, 26);
            decisionEtapeToolStripMenuItem2.Text = "Etape";
            decisionEtapeToolStripMenuItem2.Click += decisionEtapeToolStripMenuItem2_Click;
            // 
            // familleDeMédicamentToolStripMenuItem
            // 
            familleDeMédicamentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreDeMédicamentParFamilleToolStripMenuItem1 });
            familleDeMédicamentToolStripMenuItem.Name = "familleDeMédicamentToolStripMenuItem";
            familleDeMédicamentToolStripMenuItem.Size = new Size(178, 24);
            familleDeMédicamentToolStripMenuItem.Text = "Famille de médicament";
            // 
            // nombreDeMédicamentParFamilleToolStripMenuItem1
            // 
            nombreDeMédicamentParFamilleToolStripMenuItem1.Name = "nombreDeMédicamentParFamilleToolStripMenuItem1";
            nombreDeMédicamentParFamilleToolStripMenuItem1.Size = new Size(331, 26);
            nombreDeMédicamentParFamilleToolStripMenuItem1.Text = "Nombre de médicament par famille";
            nombreDeMédicamentParFamilleToolStripMenuItem1.Click += nombreDeMédicamentParFamilleToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { workflowToolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(92, 24);
            toolStripMenuItem1.Text = "Workflows";
            // 
            // workflowToolStripMenuItem2
            // 
            workflowToolStripMenuItem2.Name = "workflowToolStripMenuItem2";
            workflowToolStripMenuItem2.Size = new Size(255, 26);
            workflowToolStripMenuItem2.Text = "Etapes d'un médicament";
            workflowToolStripMenuItem2.Click += workflowToolStripMenuItem2_Click;
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
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "GesAMM - Gestion et suivi des Autorisations de Mise sur le Marché des médicaments";
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
        private ToolStripMenuItem familleDeMédicamentToolStripMenuItem;
        private ToolStripMenuItem nombreDeMédicamentParFamilleToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem workflowToolStripMenuItem2;
    }
}