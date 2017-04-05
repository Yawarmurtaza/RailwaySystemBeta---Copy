using System.ServiceModel;

namespace ServerWCF
{
    [ServiceContract]
    public interface ISignUpService
    {
        [OperationContract]
        string AddUser(User u, string userType);
    }
}
