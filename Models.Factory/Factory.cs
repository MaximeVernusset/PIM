using System.Configuration;

namespace MyAirport.Pim.Models
{
    public static class Factory
    {
        private static AbstractDefinition singleton = null;
        public static AbstractDefinition Model
        {
            get
            {
                if (singleton == null)
                {
                    switch (ConfigurationManager.AppSettings["Factory"])
                    {
                        case "Sql":
                            singleton = new Models.Sql();
                            break;
                        case "Natif":
                            singleton = new Models.Natif();
                            break;
                        default:
                            singleton = new Models.Natif();
                            break;
                    }
                }
                return singleton;
            }
        }

    }
}
