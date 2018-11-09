namespace MyAirport.Pim.Server
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button_open_close = new System.Windows.Forms.Button();
			this.button_create = new System.Windows.Forms.Button();
			this.textBox_state = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.button_open_close);
			this.groupBox1.Controls.Add(this.button_create);
			this.groupBox1.Controls.Add(this.textBox_state);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(335, 94);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// button_open_close
			// 
			this.button_open_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_open_close.Location = new System.Drawing.Point(254, 63);
			this.button_open_close.Name = "button_open_close";
			this.button_open_close.Size = new System.Drawing.Size(75, 23);
			this.button_open_close.TabIndex = 3;
			this.button_open_close.Text = "Ouvrir";
			this.button_open_close.UseVisualStyleBackColor = true;
			this.button_open_close.Click += new System.EventHandler(this.button_open_close_Click);
			// 
			// button_create
			// 
			this.button_create.Location = new System.Drawing.Point(6, 63);
			this.button_create.Name = "button_create";
			this.button_create.Size = new System.Drawing.Size(75, 23);
			this.button_create.TabIndex = 2;
			this.button_create.Text = "Créer";
			this.button_create.UseVisualStyleBackColor = true;
			this.button_create.Click += new System.EventHandler(this.button_create_Click);
			// 
			// textBox_state
			// 
			this.textBox_state.Location = new System.Drawing.Point(44, 26);
			this.textBox_state.Name = "textBox_state";
			this.textBox_state.Size = new System.Drawing.Size(100, 20);
			this.textBox_state.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "State";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 104);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(335, 121);
			this.listBox1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 236);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(375, 324);
			this.MinimumSize = new System.Drawing.Size(375, 275);
			this.Name = "Form1";
			this.Text = "Serveur";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button_open_close;
		private System.Windows.Forms.Button button_create;
		private System.Windows.Forms.TextBox textBox_state;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
	}
}

