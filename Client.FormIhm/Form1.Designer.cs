namespace Client.FormIhm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button_getBagageByID = new System.Windows.Forms.Button();
			this.button_getBagageByIata = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_getBagageByID
			// 
			this.button_getBagageByID.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.button_getBagageByID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button_getBagageByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_getBagageByID.Location = new System.Drawing.Point(12, 12);
			this.button_getBagageByID.Name = "button_getBagageByID";
			this.button_getBagageByID.Size = new System.Drawing.Size(115, 31);
			this.button_getBagageByID.TabIndex = 0;
			this.button_getBagageByID.Text = "Get bagage";
			this.button_getBagageByID.UseVisualStyleBackColor = false;
			this.button_getBagageByID.Click += new System.EventHandler(this.button_getBagageByID_Click);
			// 
			// button_getBagageByIata
			// 
			this.button_getBagageByIata.BackColor = System.Drawing.Color.DeepPink;
			this.button_getBagageByIata.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button_getBagageByIata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_getBagageByIata.Location = new System.Drawing.Point(133, 12);
			this.button_getBagageByIata.Name = "button_getBagageByIata";
			this.button_getBagageByIata.Size = new System.Drawing.Size(115, 31);
			this.button_getBagageByIata.TabIndex = 1;
			this.button_getBagageByIata.Text = "Get bagage(s)\n";
			this.button_getBagageByIata.UseVisualStyleBackColor = false;
			this.button_getBagageByIata.Click += new System.EventHandler(this.button_getBagageByIata_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(434, 280);
			this.Controls.Add(this.button_getBagageByIata);
			this.Controls.Add(this.button_getBagageByID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "IHM";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_getBagageByID;
		private System.Windows.Forms.Button button_getBagageByIata;
	}
}

