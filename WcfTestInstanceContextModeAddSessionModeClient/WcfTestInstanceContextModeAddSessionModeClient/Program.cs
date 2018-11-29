using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTestInstanceContextModeAddSessionModeClient.ServiceReference1;

namespace WcfTestInstanceContextModeAddSessionModeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient calculatorServiceClient = new CalculatorServiceClient();
            calculatorServiceClient.Add(1.0);
            Console.WriteLine("calculatorServiceClient.Add(1.0)={0}", calculatorServiceClient.GetResult());
            calculatorServiceClient.Add(22.0);
            Console.WriteLine("calculatorServiceClient.Add(22.0)={0}", calculatorServiceClient.GetResult());
            Console.Read();

        } 
    }
}
