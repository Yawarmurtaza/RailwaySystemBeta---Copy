using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;

namespace ServerWCF
{
    [ServiceContract]
    public interface IServerService
    {
        [OperationContract]
        List<Station> LoadStations();
        [OperationContract]
        List<Track> GetTracks();
    }
}
