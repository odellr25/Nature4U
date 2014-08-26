using Nature4U.TYPES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Nature4UService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INatureService" in both code and config file together.
    [ServiceContract]
    public interface INatureService
    {
        [OperationContract]
        List<BodyParts> GetBodyParts();
        [OperationContract]
        int InsertBodyParts(BodyParts objParts);

    }
}
