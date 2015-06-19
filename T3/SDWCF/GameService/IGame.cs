using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GameService
{

    [ServiceContract]
    public interface IGamePlayer
    {
        [OperationContract]
        string SetPlay(int n1, int n2);
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
