using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfTestInstanceContextModeAddSessionMode
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(CalculatorService.CalculatorService)))
            {
                serviceHost.Open();

                Console.WriteLine("serviceHost.Open()");
                Console.Read();

            }
        }
    }
}
