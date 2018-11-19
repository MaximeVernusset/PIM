namespace Client.FormIhm
{
	partial class ChooseBagagePopup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBagagePopup));
			this.comboBox_IdBagages = new System.Windows.Forms.ComboBox();
			this.button_ok = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox_IdBagages
			// 
			this.comboBox_IdBagages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_IdBagages.FormattingEnabled = true;
			this.comboBox_IdBagages.Location = new System.Drawing.Point(12, 37);
			this.comboBox_IdBagages.Name = "comboBox_IdBagages";
			this.comboBox_IdBagages.Size = new System.Drawing.Size(355, 23);
			this.comboBox_IdBagages.TabIndex = 0;
			// 
			// button_ok
			// 
			this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_ok.Location = new System.Drawing.Point(12, 75);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(129, 34);
			this.button_ok.TabIndex = 1;
			this.button_ok.Text = "Ok";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Veuillez choisir le bagage à afficher :";
			// 
			// button_cancel
			// 
			this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_cancel.Location = new System.Drawing.Point(230, 75);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(137, 34);
			this.button_cancel.TabIndex = 3;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// ChooseBagagePopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 120);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.comboBox_IdBagages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChooseBagagePopup";
			this.Text = "Choix bagage";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_IdBagages;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_cancel;
	}
}