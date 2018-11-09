using System;
using System.Collections.Generic;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Models
{
    public class Natif : AbstractDefinition
    {
		public override bool CreateBagage(BagageDefinition bagage)
		{
			throw new NotImplementedException();
		}

		public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<Entities.BagageDefinition> GetBagage(string codeIataBagage)
        {
            throw new NotImplementedException();
        }

		public override string getCompanyCode(string companyName)
		{
			throw new NotImplementedException();
		}
	}
}
