namespace DescentProject
{
    partial class frmDescent
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éditerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpansion = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonnage = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWarrior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHealer = new System.Windows.Forms.ToolStripMenuItem();
            this.joueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.éditerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuPrincipale";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // éditerToolStripMenuItem
            // 
            this.éditerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExpansion,
            this.tsmPersonnage,
            this.classesToolStripMenuItem,
            this.joueurToolStripMenuItem});
            this.éditerToolStripMenuItem.Name = "éditerToolStripMenuItem";
            this.éditerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.éditerToolStripMenuItem.Text = "Éditer";
            // 
            // tsmExpansion
            // 
            this.tsmExpansion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1});
            this.tsmExpansion.Name = "tsmExpansion";
            this.tsmExpansion.Size = new System.Drawing.Size(152, 22);
            this.tsmExpansion.Text = "Expansion";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem1.Text = "Test";
            // 
            // tsmPersonnage
            // 
            this.tsmPersonnage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.tsmPersonnage.Name = "tsmPersonnage";
            this.tsmPersonnage.Size = new System.Drawing.Size(152, 22);
            this.tsmPersonnage.Text = "Personnage";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWarrior,
            this.tsmMage,
            this.tsmScout,
            this.tsmHealer});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // tsmWarrior
            // 
            this.tsmWarrior.Name = "tsmWarrior";
            this.tsmWarrior.Size = new System.Drawing.Size(152, 22);
            this.tsmWarrior.Text = "Warrior";
            // 
            // tsmMage
            // 
            this.tsmMage.Name = "tsmMage";
            this.tsmMage.Size = new System.Drawing.Size(152, 22);
            this.tsmMage.Text = "Mage";
            // 
            // tsmScout
            // 
            this.tsmScout.Name = "tsmScout";
            this.tsmScout.Size = new System.Drawing.Size(152, 22);
            this.tsmScout.Text = "Scout";
            // 
            // tsmHealer
            // 
            this.tsmHealer.Name = "tsmHealer";
            this.tsmHealer.Size = new System.Drawing.Size(152, 22);
            this.tsmHealer.Text = "Healer";
            // 
            // joueurToolStripMenuItem
            // 
            this.joueurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overlordToolStripMenuItem,
            this.heroToolStripMenuItem});
            this.joueurToolStripMenuItem.Name = "joueurToolStripMenuItem";
            this.joueurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.joueurToolStripMenuItem.Text = "Joueur";
            // 
            // overlordToolStripMenuItem
            // 
            this.overlordToolStripMenuItem.Name = "overlordToolStripMenuItem";
            this.overlordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overlordToolStripMenuItem.Text = "Overlord";
            // 
            // heroToolStripMenuItem
            // 
            this.heroToolStripMenuItem.Name = "heroToolStripMenuItem";
            this.heroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.heroToolStripMenuItem.Text = "Hero";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gameToolStripMenuItem.Text = "Game?";
            // 
            // frmDescent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 378);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDescent";
            this.Text = "Descent: Journeys in the Dark";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem éditerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExpansion;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonnage;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmWarrior;
        private System.Windows.Forms.ToolStripMenuItem tsmMage;
        private System.Windows.Forms.ToolStripMenuItem tsmScout;
        private System.Windows.Forms.ToolStripMenuItem tsmHealer;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heroToolStripMenuItem;
    }
}

