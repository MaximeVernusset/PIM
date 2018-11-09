using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;


namespace MyAirport.Pim.Service
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class ServicePim : IServicePim
	{
		/// <summary>
		/// Valide les informations du bagage et appelle la factory pour créer le bagage.
		/// </summary>
		/// <param name="bag">Bagage à créer.</param>
		/// <returns>True si le bagage a bien été créé, False sinon.</returns>
		public bool CreateBagage(BagageDefinition bag)
		{
			this.ValidateBagageInput(bag);
			try
			{
				return MyAirport.Pim.Models.Factory.Model.CreateBagage(bag);
			}
			catch(Exception ex)
			{
				throw new FaultException(ex.Message);
			}
		}


		/// <summary>
		/// Valide l'intégrité des différentes informations du bagage, avant de l'envoyer à la Factory pour création.
		/// Si un attribut n'est pas valide, lève une FaultException transmise au client avec un message correspondant.
		/// Pour la compagnie, regarde si elle existe, et modifie le nom par son code Iata.
		/// </summary>
		/// <param name="bag">Bagage à vérifier.</param>
		private void ValidateBagageInput(BagageDefinition bag)
		{
			//Vérification longueur code Iata
			if (bag.CodeIata.Equals(String.Empty))
				throw new FaultException("Vous n'avez pas renseigné le code Iata.");
			if (bag.CodeIata.Length != 12)
				throw new FaultException("Le code Iata doit contenir 12 chiffres.");

			//Vérification que le code Iata ne contient que des chiffres 
			foreach (char i in bag.CodeIata)
				if(!char.IsDigit(i))
					throw new FaultException("Le code Iata ne doit contenir que des chiffres.");

			//Vérification que la Compagnie existe, et récupère son code pour ne pas insérer dans la table le nom complet (cohérence des données avec ce qui est déjà présent en base)
			if (bag.Compagnie.Equals(String.Empty))
				throw new FaultException("Vous n'avez pas renseigné la compagnie.");
			string companyCode = MyAirport.Pim.Models.Factory.Model.getCompanyCode(bag.Compagnie.ToUpper());
			if (companyCode != null)
				bag.Compagnie = companyCode;
			else
				throw new FaultException("La compagnie renseignée n'existe pas.");

			//Vérification longueur Ligne
			if (bag.Ligne.Equals(String.Empty))
				throw new FaultException("Vous n'avez pas renseigné la ligne.");
			if (bag.Ligne.Length > 5)
				throw new FaultException("Le numéro de ligne ne peut pas dépasser 5 chiffres.");

			//Vérification que la Ligne ne contient que des chiffres
			foreach (char i in bag.Ligne)
				if (!char.IsDigit(i))
					throw new FaultException("La ligne ne doit contenir que des chiffres.");

			//Vérification Itinéraire
			if (bag.Itineraire.Length > 3)
				throw new FaultException("L'itinéraire ne peux pas dépasser 3 lettres.");

			//Vérification que l'Itinéraire ne contient que des lettres
			foreach (char i in bag.Itineraire)
				if (!char.IsLetter(i))
					throw new FaultException("L'itineraire ne doit contenir que des lettres.");

			//Conversion Itinéraire en majuscule
			bag.Itineraire.ToUpper();

			//Vérification Classe
			if (bag.Classe.Equals(String.Empty))
				throw new FaultException("Vous n'avez pas renseigné la classe.");
			if (bag.Classe.Length != 1)
				throw new FaultException("La classe ne peut pas dépasser 1 lettre.");
			if (!char.IsLetter(bag.Classe[0]))
				throw new FaultException("La classe ne doit contenir qu'une lettre.");

			//Conversion Classe en majuscule
			bag.Classe.ToUpper();
		}


		/// <summary>
		/// Récupère le(s) bagage(s) correspondant au code Iata fourni.
		/// Si plusieurs bagages correspondent, une exception est levée, contenant la liste des bagages.
		/// </summary>
		/// <param name="codeIata">Code Iata du bagage</param>
		/// <returns>Le bagage correspondant au code Iata</returns>
		public BagageDefinition GetBagageByCodeIata(string codeIata)
		{
			List<BagageDefinition> res = MyAirport.Pim.Models.Factory.Model.GetBagage(codeIata);
			if(res != null)
			{
				if(res.Count == 1)
				{
					return res[0];
				}
				else if(res.Count > 1)
				{
					var ex = new MultipleBagageFault();
					ex.CodeIata = codeIata;
					ex.Message = "Il existe " + res.Count + " bagages avec le code Iata " + codeIata;
					ex.ListBagages = res;

					throw new FaultException<MultipleBagageFault>(ex, new FaultReason(ex.Message));
				}
			}

			return null;
		}


		public BagageDefinition GetBagageById(int idBagage)
		{
			return MyAirport.Pim.Models.Factory.Model.GetBagage(idBagage);
		}
	}
}
