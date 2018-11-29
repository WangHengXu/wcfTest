using System;
using WCFClient.WCFCallbackService;

namespace WCFClient
{
    // 客户端中对回调契约的实现
    public  class CallbackWCFService : ICalculatorCallback
    {
        public static Action<string> CallBackAction;
        public delegate void CallbackHandle(string str);
        public static event CallbackHandle CallBackEvent;
        public void DisplayResult(double a, double b, double result)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, result);
            CallBackAction?.Invoke("回调");
            CallBackEvent?.Invoke("事件");
        }
    }
}
