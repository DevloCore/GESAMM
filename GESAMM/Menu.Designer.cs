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
            DecisionToolStripMenuItem1 = new ToolStripMenuItem();
            DecisionMedicamentMenu = new ToolStripMenuItem();
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
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.médicamentsToolStripMenuItem});
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            // 
            // DecisionToolStripMenuItem1
            // 
            DecisionToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { DecisionMedicamentMenu });
            DecisionToolStripMenuItem1.Name = "DecisionToolStripMenuItem1";
            DecisionToolStripMenuItem1.Size = new Size(64, 20);
            DecisionToolStripMenuItem1.Text = "Decision";
            // 
            // DecisionMedicamentMenu
            // 
            DecisionMedicamentMenu.Name = "DecisionMedicamentMenu";
            DecisionMedicamentMenu.Size = new Size(180, 22);
            DecisionMedicamentMenu.Text = "Decider";
            DecisionMedicamentMenu.Click += DecisionMedicamentMenu_Click;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem médicamentsToolStripMenuItem;
        private ToolStripMenuItem consulterToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem DecisionToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem DecisionMedicamentMenu;
    }
}