using System.ServiceModel;

namespace WCFServices
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
