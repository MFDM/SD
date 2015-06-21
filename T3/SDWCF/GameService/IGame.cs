using System;
using System.ServiceModel;

namespace GameService
{

    [ServiceContract(Namespace="Silverlight",CallbackContract = typeof(IGamePlayerReceiverCallback))]
    public interface IGamePlayer
    {
        [OperationContract]
        string MakeMove(int n1, int n2);

        [OperationContract]
        void JoinGame();
        
        [OperationContract]
        void ExitGame();

        [OperationContract]
        string TranslateAdv(string targetLng);

    }
    
    // CallBack interface in client 
    public interface IGamePlayerReceiverCallback
    {
        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(FaultException<string>))]
        String NewAnnounce(String msg, int ex);

        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(FaultException<string>))]
        string NewAdvertisement(string msg, int ex);
    }


    [ServiceContract]
    public interface IGameManager
    {
        [OperationContract]
        void StartGame(int n1, int n2);

        [OperationContract]
        void EndGame();

        [OperationContract]
        void SetAdv(string adv);
    }

}
