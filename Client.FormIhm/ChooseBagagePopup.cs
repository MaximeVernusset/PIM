using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormIhm
{
	public partial class ChooseBagagePopup : Form
	{
		/// <summary>
		/// Index de l'item de la combobox choisi.
		/// Correspond à l'index de la liste de bagages fournie.
		/// </summary>
		public int IndexBagageChoisi { get; private set; }

		/// <summary>
		/// Constructeur.
		/// Remplit la combobox avec les ID de chaque bagage et sélectionne le 1er par défaut.
		/// </summary>
		/// <param name="bagages">Liste des bagages</param>
		public ChooseBagagePopup(List<ServiceReferencePim.BagageDefinition> bagages)
		{
			InitializeComponent();

			foreach (ServiceReferencePim.BagageDefinition bag in bagages)
				this.comboBox_IdBagages.Items.Add(String.Format("ID: {0}, Comp: {1}, Ligne: {2}", bag.IdBagage, bag.Compagnie, bag.Ligne));
			this.comboBox_IdBagages.SelectedIndex = this.IndexBagageChoisi = 0;
		}

		/// <summary>
		/// Enregistre l'index sélectionné.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_ok_Click(object sender, EventArgs e)
		{
			if (this.comboBox_IdBagages.SelectedIndex >= 0 && this.comboBox_IdBagages.SelectedIndex < this.comboBox_IdBagages.Items.Count) //Condition toujours vraie normalement
				this.IndexBagageChoisi = this.comboBox_IdBagages.SelectedIndex;
		}
	}
}
