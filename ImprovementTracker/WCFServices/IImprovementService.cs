using ImprovementTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImprovementTracker.WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IImprovementService" in both code and config file together.
    [ServiceContract(Namespace="Computacenter",ProtectionLevel=ProtectionLevel.None)]
    public interface IImprovementService
    {
        [OperationContract]
        IImprovement GetImprovement(int Id);
    }
    
    public interface IImprovement {
        [DataMember]
        int Id{get;set;}
        [DataMember]
        string Description{get;set;}
    }
}
