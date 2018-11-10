namespace Client.FormIhm
{
	partial class PIM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIM));
			this.groupBox_recherche = new System.Windows.Forms.GroupBox();
			this.button_GetBagage = new System.Windows.Forms.Button();
			this.textBox_CodeIata = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox_resultat = new System.Windows.Forms.GroupBox();
			this.button_CreerBagage = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox_vol = new System.Windows.Forms.GroupBox();
			this.textBox_JourExploitation = new System.Windows.Forms.TextBox();
			this.textBox_Ligne1 = new System.Windows.Forms.TextBox();
			this.textBox_Compagnie = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox_bagage = new System.Windows.Forms.GroupBox();
			this.checkBox_Rush = new System.Windows.Forms.CheckBox();
			this.checkBox_Continuation = new System.Windows.Forms.CheckBox();
			this.textBox_ClasseBagage = new System.Windows.Forms.TextBox();
			this.textBox_Itineraire = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.attenteBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectBgageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creationBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelEtat = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox_recherche.SuspendLayout();
			this.groupBox_resultat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox_vol.SuspendLayout();
			this.groupBox_bagage.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_recherche
			// 
			this.groupBox_recherche.Controls.Add(this.button_GetBagage);
			this.groupBox_recherche.Controls.Add(this.textBox_CodeIata);
			this.groupBox_recherche.Controls.Add(this.label1);
			this.groupBox_recherche.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox_recherche.Location = new System.Drawing.Point(0, 24);
			this.groupBox_recherche.Name = "groupBox_recherche";
			this.groupBox_recherche.Size = new System.Drawing.Size(520, 55);
			this.groupBox_recherche.TabIndex = 0;
			this.groupBox_recherche.TabStop = false;
			this.groupBox_recherche.Text = "Recherche";
			this.groupBox_recherche.Visible = false;
			// 
			// button_GetBagage
			// 
			this.button_GetBagage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_GetBagage.Location = new System.Drawing.Point(437, 18);
			this.button_GetBagage.Name = "button_GetBagage";
			this.button_GetBagage.Size = new System.Drawing.Size(73, 23);
			this.button_GetBagage.TabIndex = 4;
			this.button_GetBagage.Text = "...";
			this.button_GetBagage.UseVisualStyleBackColor = true;
			this.button_GetBagage.Click += new System.EventHandler(this.button_getBagage_Click);
			// 
			// textBox_CodeIata
			// 
			this.textBox_CodeIata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_CodeIata.Location = new System.Drawing.Point(71, 20);
			this.textBox_CodeIata.Name = "textBox_CodeIata";
			this.textBox_CodeIata.Size = new System.Drawing.Size(360, 20);
			this.textBox_CodeIata.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Code Iata :";
			// 
			// groupBox_resultat
			// 
			this.groupBox_resultat.Controls.Add(this.button_CreerBagage);
			this.groupBox_resultat.Controls.Add(this.splitContainer1);
			this.groupBox_resultat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_resultat.Enabled = false;
			this.groupBox_resultat.Location = new System.Drawing.Point(0, 79);
			this.groupBox_resultat.Name = "groupBox_resultat";
			this.groupBox_resultat.Size = new System.Drawing.Size(520, 142);
			this.groupBox_resultat.TabIndex = 1;
			this.groupBox_resultat.TabStop = false;
			this.groupBox_resultat.Text = "Résultat";
			this.groupBox_resultat.Visible = false;
			// 
			// button_CreerBagage
			// 
			this.button_CreerBagage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_CreerBagage.Location = new System.Drawing.Point(3, 113);
			this.button_CreerBagage.Name = "button_CreerBagage";
			this.button_CreerBagage.Size = new System.Drawing.Size(514, 26);
			this.button_CreerBagage.TabIndex = 4;
			this.button_CreerBagage.Text = "Créer";
			this.button_CreerBagage.UseVisualStyleBackColor = true;
			this.button_CreerBagage.Visible = false;
			this.button_CreerBagage.Click += new System.EventHandler(this.button_CreerBagage_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitContainer1.Location = new System.Drawing.Point(3, 16);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox_vol);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox_bagage);
			this.splitContainer1.Size = new System.Drawing.Size(514, 91);
			this.splitContainer1.SplitterDistance = 260;
			this.splitContainer1.TabIndex = 4;
			// 
			// groupBox_vol
			// 
			this.groupBox_vol.Controls.Add(this.textBox_JourExploitation);
			this.groupBox_vol.Controls.Add(this.textBox_Ligne1);
			this.groupBox_vol.Controls.Add(this.textBox_Compagnie);
			this.groupBox_vol.Controls.Add(this.label4);
			this.groupBox_vol.Controls.Add(this.label3);
			this.groupBox_vol.Controls.Add(this.label2);
			this.groupBox_vol.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox_vol.Location = new System.Drawing.Point(0, 0);
			this.groupBox_vol.Name = "groupBox_vol";
			this.groupBox_vol.Size = new System.Drawing.Size(260, 91);
			this.groupBox_vol.TabIndex = 1;
			this.groupBox_vol.TabStop = false;
			this.groupBox_vol.Text = "Vol";
			// 
			// textBox_JourExploitation
			// 
			this.textBox_JourExploitation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_JourExploitation.Location = new System.Drawing.Point(109, 63);
			this.textBox_JourExploitation.Name = "textBox_JourExploitation";
			this.textBox_JourExploitation.Size = new System.Drawing.Size(142, 20);
			this.textBox_JourExploitation.TabIndex = 8;
			// 
			// textBox_Ligne1
			// 
			this.textBox_Ligne1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Ligne1.Location = new System.Drawing.Point(109, 37);
			this.textBox_Ligne1.Name = "textBox_Ligne1";
			this.textBox_Ligne1.Size = new System.Drawing.Size(142, 20);
			this.textBox_Ligne1.TabIndex = 6;
			// 
			// textBox_Compagnie
			// 
			this.textBox_Compagnie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Compagnie.Location = new System.Drawing.Point(109, 13);
			this.textBox_Compagnie.Name = "textBox_Compagnie";
			this.textBox_Compagnie.Size = new System.Drawing.Size(142, 20);
			this.textBox_Compagnie.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Jour d\'exploitation :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ligne :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Compagnie :";
			// 
			// groupBox_bagage
			// 
			this.groupBox_bagage.Controls.Add(this.checkBox_Rush);
			this.groupBox_bagage.Controls.Add(this.checkBox_Continuation);
			this.groupBox_bagage.Controls.Add(this.textBox_ClasseBagage);
			this.groupBox_bagage.Controls.Add(this.textBox_Itineraire);
			this.groupBox_bagage.Controls.Add(this.label6);
			this.groupBox_bagage.Controls.Add(this.label5);
			this.groupBox_bagage.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox_bagage.Location = new System.Drawing.Point(0, 0);
			this.groupBox_bagage.Name = "groupBox_bagage";
			this.groupBox_bagage.Size = new System.Drawing.Size(250, 91);
			this.groupBox_bagage.TabIndex = 2;
			this.groupBox_bagage.TabStop = false;
			this.groupBox_bagage.Text = "Bagage";
			// 
			// checkBox_Rush
			// 
			this.checkBox_Rush.AutoSize = true;
			this.checkBox_Rush.Location = new System.Drawing.Point(157, 63);
			this.checkBox_Rush.Name = "checkBox_Rush";
			this.checkBox_Rush.Size = new System.Drawing.Size(51, 17);
			this.checkBox_Rush.TabIndex = 12;
			this.checkBox_Rush.Text = "Rush";
			this.checkBox_Rush.UseVisualStyleBackColor = true;
			// 
			// checkBox_Continuation
			// 
			this.checkBox_Continuation.AutoSize = true;
			this.checkBox_Continuation.Location = new System.Drawing.Point(38, 63);
			this.checkBox_Continuation.Name = "checkBox_Continuation";
			this.checkBox_Continuation.Size = new System.Drawing.Size(85, 17);
			this.checkBox_Continuation.TabIndex = 11;
			this.checkBox_Continuation.Text = "Continuation";
			this.checkBox_Continuation.UseVisualStyleBackColor = true;
			// 
			// textBox_ClasseBagage
			// 
			this.textBox_ClasseBagage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_ClasseBagage.Location = new System.Drawing.Point(95, 37);
			this.textBox_ClasseBagage.Name = "textBox_ClasseBagage";
			this.textBox_ClasseBagage.Size = new System.Drawing.Size(148, 20);
			this.textBox_ClasseBagage.TabIndex = 10;
			// 
			// textBox_Itineraire
			// 
			this.textBox_Itineraire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Itineraire.Location = new System.Drawing.Point(95, 13);
			this.textBox_Itineraire.Name = "textBox_Itineraire";
			this.textBox_Itineraire.Size = new System.Drawing.Size(148, 20);
			this.textBox_Itineraire.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Classe bagage :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Itinéraire :";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(520, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// commandesToolStripMenuItem
			// 
			this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem,
            this.attenteBagageToolStripMenuItem,
            this.selectBgageToolStripMenuItem,
            this.creationBagageToolStripMenuItem,
            this.afficherBagageToolStripMenuItem});
			this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
			this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.commandesToolStripMenuItem.Text = "Commandes";
			// 
			// réinitialiserToolStripMenuItem
			// 
			this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
			this.réinitialiserToolStripMenuItem.ShortcutKeyDisplayString = "F1";
			this.réinitialiserToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.réinitialiserToolStripMenuItem.Text = "Déconnecter";
			this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
			// 
			// attenteBagageToolStripMenuItem
			// 
			this.attenteBagageToolStripMenuItem.Name = "attenteBagageToolStripMenuItem";
			this.attenteBagageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.attenteBagageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.attenteBagageToolStripMenuItem.Text = "AttenteBagage";
			this.attenteBagageToolStripMenuItem.Click += new System.EventHandler(this.attenteBagageToolStripMenuItem_Click);
			// 
			// selectBgageToolStripMenuItem
			// 
			this.selectBgageToolStripMenuItem.Name = "selectBgageToolStripMenuItem";
			this.selectBgageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.selectBgageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.selectBgageToolStripMenuItem.Text = "SélectionBagage";
			this.selectBgageToolStripMenuItem.Click += new System.EventHandler(this.selectBagageToolStripMenuItem_Click);
			// 
			// creationBagageToolStripMenuItem
			// 
			this.creationBagageToolStripMenuItem.Name = "creationBagageToolStripMenuItem";
			this.creationBagageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.creationBagageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.creationBagageToolStripMenuItem.Text = "CréationBagage";
			this.creationBagageToolStripMenuItem.Click += new System.EventHandler(this.creationBagageToolStripMenuItem_Click);
			// 
			// afficherBagageToolStripMenuItem
			// 
			this.afficherBagageToolStripMenuItem.Name = "afficherBagageToolStripMenuItem";
			this.afficherBagageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.afficherBagageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.afficherBagageToolStripMenuItem.Text = "AffichageBagage";
			this.afficherBagageToolStripMenuItem.Click += new System.EventHandler(this.afficherBagageToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage,
            this.toolStripStatusLabelEtat});
			this.statusStrip1.Location = new System.Drawing.Point(0, 221);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(520, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "n";
			// 
			// toolStripStatusLabelMessage
			// 
			this.toolStripStatusLabelMessage.AutoSize = false;
			this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
			this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(300, 17);
			this.toolStripStatusLabelMessage.Text = "Messages";
			// 
			// toolStripStatusLabelEtat
			// 
			this.toolStripStatusLabelEtat.AutoSize = false;
			this.toolStripStatusLabelEtat.Name = "toolStripStatusLabelEtat";
			this.toolStripStatusLabelEtat.Size = new System.Drawing.Size(150, 17);
			this.toolStripStatusLabelEtat.Text = "Etat";
			// 
			// PIM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 243);
			this.Controls.Add(this.groupBox_resultat);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox_recherche);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(744, 350);
			this.MinimumSize = new System.Drawing.Size(536, 282);
			this.Name = "PIM";
			this.Text = "PIM";
			this.groupBox_recherche.ResumeLayout(false);
			this.groupBox_recherche.PerformLayout();
			this.groupBox_resultat.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox_vol.ResumeLayout(false);
			this.groupBox_vol.PerformLayout();
			this.groupBox_bagage.ResumeLayout(false);
			this.groupBox_bagage.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_recherche;
		private System.Windows.Forms.Button button_GetBagage;
		private System.Windows.Forms.TextBox textBox_CodeIata;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox_resultat;
		private System.Windows.Forms.GroupBox groupBox_bagage;
		private System.Windows.Forms.CheckBox checkBox_Rush;
		private System.Windows.Forms.CheckBox checkBox_Continuation;
		private System.Windows.Forms.TextBox textBox_ClasseBagage;
		private System.Windows.Forms.TextBox textBox_Itineraire;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox_vol;
		private System.Windows.Forms.TextBox textBox_JourExploitation;
		private System.Windows.Forms.TextBox textBox_Ligne1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEtat;
		private System.Windows.Forms.TextBox textBox_Compagnie;
		private System.Windows.Forms.ToolStripMenuItem attenteBagageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectBgageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem creationBagageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afficherBagageToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button_CreerBagage;
	}
}