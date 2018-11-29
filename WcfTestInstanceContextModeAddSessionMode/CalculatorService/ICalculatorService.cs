using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    [ServiceContract(SessionMode =SessionMode.Required)]
   public  interface ICalculatorService
    {
        [OperationContract(IsOneWay =true)]
        void Add(double x);
        [OperationContract]
        double GetResult();
    }
}
