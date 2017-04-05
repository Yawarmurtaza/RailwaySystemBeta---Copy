using System.ServiceModel;
using System.Collections.Generic;


namespace ServerWCF
{
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        string AddTrain(Train tr);

        [OperationContract]
        string AddStation(Station st);

        [OperationContract]
        string AddTrack(Track trk);

        [OperationContract]
        string AddStationToTrack(Track trk, Station st);

        [OperationContract]
        List<Station> LoadStations();

        [OperationContract]
        List<Track> GetTracks();
    }
}
