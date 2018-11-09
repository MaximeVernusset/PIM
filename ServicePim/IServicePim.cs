using System.ServiceModel;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Service
{
	[ServiceContract]
	public interface IServicePim
	{
		[OperationContract]
		BagageDefinition GetBagageById(int idBagage);

		[OperationContract]
		[FaultContract(typeof(MultipleBagageFault))]
		BagageDefinition GetBagageByCodeIata(string codeIata);

		[OperationContract]
		bool CreateBagage(BagageDefinition bag);
	}
}