using System.ServiceModel;

namespace ServerWCF
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        string CheckCredentials(User u);
    }
}
