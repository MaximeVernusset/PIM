using System;
using System.Runtime.Serialization;

namespace MyAirport.Pim.Entities
{
	/// <summary>
	/// Définition d'un object bagage
	/// </summary>
	[DataContract]
	sealed public class BagageDefinition
    {
		[DataMember]
		public int IdBagage { get; set; }           // Identifiant bagage en base de données permet l'identification unique d'un bagage
		[DataMember]
		public string CodeIata { get; set; }        // Numéro du bagage présent sur l'étiquette
		[DataMember]
		public string Compagnie { get; set; }       // Code Iata de la compagnie aerienne sur 2 lettres
		[DataMember]
		public string Ligne { get; set; }           // Numéro de vol 3 ou 4 digits et parfois une lettre a la fin
		[DataMember]
		public DateTime DateVol { get; set; }       // Jour et heure de depart du vol
		[DataMember]
		public string Itineraire { get; set; }      // Arrêt où descend le passager pour ce vol
		[DataMember]
		public string Classe { get; set; }			// Classe du bagage
		[DataMember]
		public bool Prioritaire { get; set; }       // Est-ce que le passager est un passager prioritaire?
		[DataMember]
		public bool EnContinuation { get; set; }    // Si la destination est différente de l'itineraire, est-ce que le bagage doit être livré au passager au prochain arrêt?
		[DataMember]
		public bool Rush { get; set; }              // Bagage sans passager (pour les bagages ayant ratés un vol)


		public override string ToString()
		{
			return "ID: " + IdBagage 
				+ "\nIata: " + CodeIata 
				+ "\nCompagnie: " + Compagnie 
				+ "\nLigne: " + Ligne
				+ "\nDate: " + DateVol
				+ "\nItinéraire: " + Itineraire
				+ "\nPrioritaire: " + Prioritaire
				+ "\nContinuation: " + EnContinuation 
				+ "\nRush: " + Rush;
		}
	}
}
