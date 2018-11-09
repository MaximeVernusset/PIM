using MyAirport.Pim.Entities;
using System.Collections.Generic;

namespace MyAirport.Pim.Models
{
    public abstract class AbstractDefinition
    {
        public abstract BagageDefinition GetBagage(int idBagage);
		public abstract List<BagageDefinition> GetBagage(string codeIataBagage);
		public abstract bool CreateBagage(BagageDefinition bagage);
		public abstract string getCompanyCode(string companyName);
	}
}
