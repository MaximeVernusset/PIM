using Client.FormIhm;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client.FormIhm
{
	public partial class PIM : Form
	{
		private PimState state;
		private PimState State
		{
			get { return this.state; }
			set { OnPimStateChanged(value); }
		}

		public event PimStateEventHandler PimStateChanged;
		public delegate void PimStateEventHandler(object sender, PimState state);

		/// <summary>
		/// Conexion au webservice.
		/// </summary>
		ServiceReferencePim.ServicePimClient proxy = null;
		

		/// <summary>
		/// Constructeur.
		/// </summary>
		public PIM()
		{
			InitializeComponent();
			this.PimStateChanged += PIM_PimStateChanged;
			this.proxy = new ServiceReferencePim.ServicePimClient();
			this.State = PimState.Deconnecte;
		}

		/// <summary>
		/// Méthode appelée au changement d'état.
		/// </summary>
		/// <param name="newState">Nouvel état.</param>
		private void OnPimStateChanged(PimState newState)
		{
			if(newState != this.state)
			{
				this.state = newState;
				if(this.PimStateChanged != null)
				{
					PimStateChanged(this, this.state);
				}
			}
		}


		/// <summary>
		/// Méthode abonnée à l'événement de changement d'état.
		/// Met à jour la barre de statut.
		/// Appelle la bonne méthode de gestion de l'interface.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="state">Nouvel état</param>
		void PIM_PimStateChanged(object sender, PimState state)
		{
			this.toolStripStatusLabelEtat.Text = state.ToString();
			this.toolStripStatusLabelMessage.Text = "Messages";

			switch (state)
			{
				case PimState.Deconnecte:
					deconnecter();
					break;
				case PimState.AttenteBagage:
					attenteBagage();
					break;
				case PimState.SelectionBagage:
					selectBagage();
					break;
				case PimState.CreationBagage:
					creationBagage();
					break;
				case PimState.AffichageBagage:
					afficherBagage();
					break;
			}
		}


		#region GestionVue
		private void deconnecter()
		{
			this.Enabled = true;

			this.groupBox_recherche.Visible = false;
			this.groupBox_resultat.Visible = false;
			this.groupBox_resultat.Enabled = false;

			this.button_CreerBagage.Visible = false;
		}

		private void attenteBagage()
		{
			this.Enabled = true;

			this.groupBox_resultat.Visible = true;
			this.groupBox_recherche.Visible = true;
			this.groupBox_resultat.Enabled = false;
			this.groupBox_recherche.Enabled = true;

			this.button_GetBagage.Enabled = true;
			this.textBox_CodeIata.Enabled = true;
			this.button_CreerBagage.Visible = false;

			this.textBox_CodeIata.Text = "";
			this.textBox_Compagnie.Text = "";
			this.textBox_Ligne1.Text = "";
			this.textBox_JourExploitation.Text = "";
			this.textBox_Itineraire.Text = "";
			this.textBox_ClasseBagage.Text = "";
			this.checkBox_Continuation.Checked = false;
			this.checkBox_Rush.Checked = false;

			this.textBox_CodeIata.Focus();
		}

		private void selectBagage()
		{
			this.Enabled = false; //Inutile car le popup est modal, mais permet de désactiver l'ensemble de la fenêtre visuellement au lieu de laisser activée la 1ère 
		}

		private void creationBagage()
		{
			this.Enabled = true;

			this.groupBox_resultat.Visible = true;
			this.groupBox_recherche.Visible = true;
			this.groupBox_resultat.Enabled = true;
			this.groupBox_recherche.Enabled = true;

			this.button_GetBagage.Enabled = false;
			this.textBox_CodeIata.Enabled = true;
			this.button_CreerBagage.Visible = true;
		
			this.textBox_Compagnie.Text = "";
			this.textBox_Ligne1.Text = "";
			this.textBox_JourExploitation.Text = "";
			this.textBox_Itineraire.Text = "";
			this.textBox_ClasseBagage.Text = "";
			this.checkBox_Continuation.Checked = false;
			this.checkBox_Rush.Checked = false;

			this.textBox_Compagnie.Focus();
		}

		private void afficherBagage()
		{
			this.Enabled = true;

			this.groupBox_resultat.Visible = true;
			this.groupBox_resultat.Enabled = false;
			this.groupBox_recherche.Visible = true;
			this.groupBox_recherche.Enabled = false;

			this.button_CreerBagage.Visible = false;
		}

		/// <summary>
		/// Affiche dans les champs de la vue les infos du bagage.
		/// </summary>
		/// <param name="bagage">Bagage à afficher.</param>
		private void afficherBagageInfo(ServiceReferencePim.BagageDefinition bagage)
		{
			this.textBox_Compagnie.Text = bagage.Compagnie;
			this.textBox_Ligne1.Text = bagage.Ligne;
			this.textBox_JourExploitation.Text = bagage.DateVol.ToString();
			this.textBox_Itineraire.Text = bagage.Itineraire;
			this.textBox_ClasseBagage.Text = bagage.Classe;
			this.checkBox_Continuation.Checked = bagage.EnContinuation;
			this.checkBox_Rush.Checked = bagage.Rush;
		}
		#endregion

		#region ToolStripMenuItem
		private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.State = PimState.Deconnecte;
		}

		private void attenteBagageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.State = PimState.AttenteBagage;
		}

		private void selectBagageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.State = PimState.SelectionBagage;
		}

		private void creationBagageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.State = PimState.CreationBagage;
		}

		private void afficherBagageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.State = PimState.AffichageBagage;
		}
		#endregion


		/// <summary>
		/// Récupère depuis le webservice le bagage associé au code Iata entré, et affiche les informations du bagage.
		/// Si le code Iata n'existe pas en base, il est alors possible de créer le bagage.
		/// Dans le cas de plusieurs bagages associés au code Iata, un popup demande quel bagage afficher.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_getBagage_Click(object sender, EventArgs e)
		{
			try
			{
				ServiceReferencePim.BagageDefinition bagage = this.proxy.GetBagageByCodeIata(this.textBox_CodeIata.Text);

				if (bagage != null)
				{
					this.afficherBagageInfo(bagage);
					this.State = PimState.AffichageBagage;
				}
				else
				{
					this.State = PimState.CreationBagage;
					this.toolStripStatusLabelMessage.Text = "Aucune correspondance trouvée";
				}
			}
			catch (FaultException<ServiceReferencePim.MultipleBagageFault> ex) //Plusieurs bagages retournés
			{
				this.State = PimState.SelectionBagage;
				this.toolStripStatusLabelMessage.Text = ex.Detail.Message;

				//Ouvre un popup listant les bagages retournés.
				ChooseBagagePopup popup = new ChooseBagagePopup(new List<ServiceReferencePim.BagageDefinition>(ex.Detail.ListBagages));
				if (popup.ShowDialog(this) == DialogResult.OK)
				{
					this.afficherBagageInfo(ex.Detail.ListBagages[popup.IndexBagageChoisi]);
					this.State = PimState.AffichageBagage;
				}
				else
				{
					this.State = PimState.AttenteBagage;
				}
				popup.Dispose();
			}
			catch (FaultException)
			{
				MessageBox.Show("Une erreur s'est produite dans le traitement de votre demande.");
			}
			catch (CommunicationException)
			{
				MessageBox.Show("Une erreur de communication s'est produite dans le traitement de votre demande.");
			}
			catch (Exception)
			{
				MessageBox.Show("Une erreur s’est produite dans le traitement de votre demande.\nMerci de bien vouloir réessayer ultérieurement ou contacter votre administrateur.", "Erreur dans le traitement de votre demande", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		

		/// <summary>
		/// Demande au service web de créer un bagage dans la base de données en lui transmettant les informations du bagage renseignées par l'utilisateur.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_CreerBagage_Click(object sender, EventArgs e)
		{
			try
			{
				ServiceReferencePim.BagageDefinition newBag = new ServiceReferencePim.BagageDefinition
				{
					IdBagage = -1, //ID à -1 car ce n'est pas à nous de le créer, il est auto-incrémenté à l'insertion dans la base
					CodeIata = this.textBox_CodeIata.Text,
					Compagnie = this.textBox_Compagnie.Text,
					Ligne = this.textBox_Ligne1.Text,
					DateVol = DateTime.Parse(this.textBox_JourExploitation.Text), //Conversion string en DateTime
					Itineraire = this.textBox_Itineraire.Text,
					Prioritaire = false, //False par défaut, car pas de champ dans l'interface pour renseigner ce paramètre (également en rapport avec la classe du bagage pas gérée non plus)
					Classe = this.textBox_ClasseBagage.Text,
					EnContinuation = this.checkBox_Continuation.Checked,
					Rush = this.checkBox_Rush.Checked
				};

				if (this.proxy.CreateBagage(newBag))
				{
					this.State = PimState.AffichageBagage;
					this.toolStripStatusLabelMessage.Text = "Bagage créé";
				}
				else
					MessageBox.Show("Le bagage n'a pas pu être créé.");
			}
			catch(FormatException)
			{
				MessageBox.Show("Le jour d'exploitation doit respecter le format jj/mm/aaa hh:mm:ss");
			}
			catch(FaultException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (CommunicationException)
			{
				MessageBox.Show("Une erreur de communication s'est produite dans le traitement de votre demande.");
			}
			catch
			{
				MessageBox.Show("Une erreur s’est produite dans le traitement de votre demande.\nMerci de bien vouloir réessayer ultérieurement ou contacter votre administrateur.", "Erreur dans le traitement de votre demande", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
