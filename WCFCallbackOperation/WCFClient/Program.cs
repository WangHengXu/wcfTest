using System;
using System.ServiceModel;
using WCFClient.WCFCallbackService;

namespace WCFClient
{
    // 客户端实现，测试回调操作
    class Program
    {
        static void Main(string[] args)
        {
            CallbackWCFService.CallBackAction = (s) =>
              {
                  Console.WriteLine(s);
              };
            CallbackWCFService.CallBackEvent += CallbackWCFService_CallBackEvent;
            InstanceContext instanceContex = new InstanceContext(new CallbackWCFService());
            CalculatorClient proxy = new CalculatorClient(instanceContex);
            proxy.Multiple(2,3);

            Console.Read();
        }

        private static void CallbackWCFService_CallBackEvent(string str)
        {
            Console.WriteLine(str);
        }
    }
}
