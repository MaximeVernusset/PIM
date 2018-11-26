using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Models
{
    public class Sql : AbstractDefinition
    {
		private string connectionString = ConfigurationManager.ConnectionStrings["MyAirport.Pim.Settings.DbConnect"].ConnectionString;

		/// <summary>
		/// Requête SQL pour récupérer les informations d'un bagagage. Concaténer le "where..." pour sélectionner soit selon l'id, soit le code Iata.
		/// </summary>
		private string commandGetBagage = "SELECT b.ID_BAGAGE, b.CODE_IATA, c.NOM as COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, b.PRIORITAIRE, cast(iif(b.CONTINUATION = 'N', 0, 1) as bit) as CONTINUATION, cast(iif(bp.ID_PARTICULARITE is null, 0, 1) as bit) as 'RUSH' FROM BAGAGE b " +
			"LEFT JOIN BAGAGE_A_POUR_PARTICULARITE bp on bp.ID_BAGAGE = b.ID_BAGAGE and bp.ID_PARTICULARITE = 15 " +
			"LEFT JOIN COMPAGNIE c on c.CODE_IATA = b.COMPAGNIE ";

		/// <summary>
		/// Requête SQL pour créer un bagage dans la base.
		/// Insère les attributs fournis et des valeurs par défaut pour les champs non null par défaut.
		/// </summary>
		private string commandCreateBagage = "INSERT INTO BAGAGE (CODE_IATA, COMPAGNIE, LIGNE, DATE_CREATION, ESCALE, CLASSE, CONTINUATION, ORIGINE_CREATION, JOUR_EXPLOITATION, ORIGINE_SAFIR, EN_CONTINUATION, EN_TRANSFERT) " +
			"VALUES(@codeIata, @compagnie, @ligne, @jourExploitation, @itineraire, @classe, @continuation, 'N', 1, 0, 0, 0);";

		/// <summary>
		/// 
		/// </summary>
		//private string commandGetLastInsertId = "SELECT scope_identity();";

		/// <summary>
		/// Requête SQL pour associer un bagage venant d'être inséré à la particularité "RUSH" (15).
		/// </summary>
		private string commandAssociateBagageRush = "INSERT INTO BAGAGE_A_POUR_PARTICULARITE VALUES(@@IDENTITY, 15);";

		/// <summary>
		/// Requête SQL pour récupérer le code d'une compagnie selon son nom complet.
		/// </summary>
		private string commandGetCompanyCode = "SELECT CODE_IATA FROM COMPAGNIE WHERE NOM=@compagnie;";

		

		/// <summary>
		/// Récupère le bagage par son ID.
		/// </summary>
		/// <param name="idBagage">ID du bagage recherché.</param>
		/// <returns>Liste de bagages correspondant à l'ID.</returns>
		public override BagageDefinition GetBagage(int idBagage)
		{
			string commandGetBagageId = this.commandGetBagage + "WHERE b.ID_BAGAGE=@id;";
			BagageDefinition bagage = null;

			using (SqlConnection connection = new SqlConnection(this.connectionString))
			{
				SqlCommand cmd = new SqlCommand(commandGetBagageId, connection);
				cmd.Parameters.AddWithValue("@id", idBagage);

				connection.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
						bagage = this.constructBagageFromReader(reader);
				}
			}
			return bagage;
		}

		/// <summary>
		/// Récupère le(s) bagage(s) par son(leur) code Iata.
		/// </summary>
		/// <param name="codeIataBagage">Code Iata du bagage recherché.</param>
		/// <returns>Liste de bagages correspondant au côde Iata fourni.</returns>
		public override List<BagageDefinition> GetBagage(string codeIataBagage)
		{
			string commandGetBagageIata = this.commandGetBagage + "WHERE b.CODE_IATA=@codeIataBagageFull OR b.CODE_IATA LIKE @codeIataBagageSimple;";
			List<BagageDefinition> bagages = new List<BagageDefinition>();

			using (SqlConnection connection = new SqlConnection(this.connectionString))
			{
				SqlCommand cmd = new SqlCommand(commandGetBagageIata, connection);
				cmd.Parameters.AddWithValue("@codeIataBagageFull", codeIataBagage);
				cmd.Parameters.AddWithValue("@codeIataBagageSimple", "____" + codeIataBagage + "00");

				connection.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while(reader.Read())
						bagages.Add(this.constructBagageFromReader(reader));
				}
			}

			return bagages;
		}
		
		/// <summary>
		/// Construit un objet Bagage grâce aux informations dans le reader récupéré par la requpete SQL.
		/// </summary>
		/// <param name="reader">Reader retourné par la requête SQL.</param>
		/// <returns>Le bagage construit depuis le reader.</returns>
		private BagageDefinition constructBagageFromReader(SqlDataReader reader)
		{
			return new BagageDefinition
			{
				IdBagage = reader.GetInt32(reader.GetOrdinal("ID_BAGAGE")),
				CodeIata = reader.GetString(reader.GetOrdinal("CODE_IATA")),
				Compagnie = reader.GetString(reader.GetOrdinal("COMPAGNIE")),
				Ligne = reader.GetString(reader.GetOrdinal("LIGNE")),
				DateVol = reader.GetDateTime(reader.GetOrdinal("DATE_CREATION")),
				Itineraire = reader.GetString(reader.GetOrdinal("ESCALE")),
				Classe = reader.GetString(reader.GetOrdinal("CLASSE")),
				Prioritaire = reader.GetBoolean(reader.GetOrdinal("PRIORITAIRE")),
				EnContinuation = reader.GetBoolean(reader.GetOrdinal("CONTINUATION")),
				Rush = reader.GetBoolean(reader.GetOrdinal("RUSH"))
			};
		}


		/// <summary>
		/// Crée le bagage dans la base de données.
		/// Si le bagage est "rush", insère le bagage dans la table BAGAGE_A_POUR_PARTICULARITE.
		/// Utilise une transaction pour rendre le traitement atomique, et pouvoir annuler l'insertion du bagage en cas de problème.
		/// </summary>
		/// <param name="bag">Bagae à créer</param>
		/// <returns>True si le bagae a bien été inséré en base, False sinon.</returns>
		public override bool CreateBagage(BagageDefinition bag)
		{
			using(SqlConnection connection = new SqlConnection(this.connectionString))
			{
				connection.Open();
				SqlTransaction transaction = connection.BeginTransaction();

				SqlCommand cmdCreateBagage = new SqlCommand(this.commandCreateBagage, connection);
				cmdCreateBagage.Parameters.AddWithValue("@codeIata", bag.CodeIata);
				cmdCreateBagage.Parameters.AddWithValue("@compagnie", bag.Compagnie);
				cmdCreateBagage.Parameters.AddWithValue("@ligne", bag.Ligne);
				cmdCreateBagage.Parameters.AddWithValue("@jourExploitation", bag.DateVol);
				cmdCreateBagage.Parameters.AddWithValue("@itineraire", bag.Itineraire);
				cmdCreateBagage.Parameters.AddWithValue("@classe", bag.Classe);
				cmdCreateBagage.Parameters.AddWithValue("@continuation", bag.EnContinuation ? 'Y' : 'N');
				cmdCreateBagage.Connection = connection;
				cmdCreateBagage.Transaction = transaction;

				try
				{
					bool inserted = true;

					//Insertion du bagage
					inserted = cmdCreateBagage.ExecuteNonQuery() == 1;

					//Si le bagage est rush, on insère une entrée dans BAGAGE_A_POUR_PARTICULARITE.
					if (bag.Rush)
					{
						SqlCommand cmdAssociateBagageRush = new SqlCommand(this.commandAssociateBagageRush, connection);
						cmdAssociateBagageRush.Connection = connection;
						cmdAssociateBagageRush.Transaction = transaction;
						inserted &= cmdAssociateBagageRush.ExecuteNonQuery() == 1;
					}

					if (inserted)
						transaction.Commit();
					else
						transaction.Rollback();

					return inserted;
				}
				catch
				{
					try
					{
						transaction.Rollback();
						return false;
					}
					catch
					{
						return false;
					}
				}
			}
		}


		/// <summary>
		/// Récupère le code Iata d'une compagnie en fonction de son nom complet.
		/// </summary>
		/// <param name="companyName">Nom complet (en majuscules) de la compagnie.</param>
		/// <returns>Le code de la compagnie si elle existe, null sinon.</returns>
		public override string getCompanyCode(string companyName)
		{
			using (SqlConnection connection = new SqlConnection(this.connectionString))
			{
				SqlCommand cmd = new SqlCommand(this.commandGetCompanyCode, connection);
				cmd.Parameters.AddWithValue("@compagnie", companyName);

				connection.Open();

				return (string)cmd.ExecuteScalar();
			}
		}
	}
}
