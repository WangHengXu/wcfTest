using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class CalculatorService : ICalculatorService, IDisposable
    {
        private double _result;
        public void Add(double x)
        {
            Console.WriteLine($"the current SessionID is: {OperationContext.Current.SessionId}");
            this._result += x;
        }

        public double GetResult()
        {
            Console.WriteLine($"the current SessionID is: {OperationContext.Current.SessionId}");

            return _result;
        }
        public CalculatorService()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Calculator object has been created");
            Console.ResetColor();
            ClientIpAndPort();
        }
        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The IDisposable.Dispose method is invoked\r\n");
            Console.ResetColor();
        }

        public void ClientIpAndPort()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties properties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            Console.WriteLine($"{ endpoint.Address}:{endpoint.Port.ToString()}");
        }
    }
}
