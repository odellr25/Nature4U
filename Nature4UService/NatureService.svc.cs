using Nature4U.TYPES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Nature4U.ADO;
using System.Configuration;

namespace Nature4UService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NatureService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NatureService.svc or NatureService.svc.cs at the Solution Explorer and start debugging.
    public class NatureService : INatureService
    {
        private string conString = ConfigurationManager.ConnectionStrings["NatureConString"].ConnectionString;
        public List<BodyParts> GetBodyParts()
        {
            return Elements.Parts(conString);
        }
        public int InsertBodyParts(BodyParts objParts)
        {
            return Elements.InsertParts(conString, objParts);
        }
 
        
    }
}
