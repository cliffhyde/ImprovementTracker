﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImprovementTracker.WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ImprovementService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ImprovementService.svc or ImprovementService.svc.cs at the Solution Explorer and start debugging.
    public class ImprovementService : IImprovementService
    {

        public IImprovement GetImprovement(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
