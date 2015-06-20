using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
    }
    
    // CallBack interface in client 
    public interface IGamePlayerReceiverCallback
    {
        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(FaultException<string>))]
        String NewAnnounce(String msg, int ex);
    }


    [ServiceContract]
    public interface IGameManager
    {
        [OperationContract]
        void StartGame(int n1, int n2);

        [OperationContract]
        void EndGame();
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
