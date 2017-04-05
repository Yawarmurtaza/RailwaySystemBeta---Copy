using System.Collections;
using System.ServiceModel;

namespace ServerWCF
{
    [ServiceContract]
    public interface IPasagerService
    {
        [OperationContract]
        string MakeBooking(User u, Track trk, string number);
        [OperationContract]
        ArrayList LoadHours(Track track);
    }
}
