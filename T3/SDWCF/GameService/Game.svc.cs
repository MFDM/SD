using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GameService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults=true)]
    public class Game : IGamePlayer, IGameManager
    {

        private List<IGamePlayerReceiverCallback> players = new List<IGamePlayerReceiverCallback>(); 
        private Board b;
        public void StartGame(int n1, int n2)
        {
            b = new Board(n1, n2);
        }

        public void EndGame()
        {
            b = null;
        }
        
        public string MakeMove(int n1, int n2)
        {
            IGamePlayerReceiverCallback currClient = OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>();
            String res = b._celsContainer[n1][n2].cellContent;
            if (res != "Treasure")
                b._celsContainer[n1][n2].SetRandomContent();
            else if (res.Equals("Treasure"))
                try
                {
                    currClient.NewAnnounce("YOU WIN", 0);

                    players.ForEach((c)=> { if (!c.Equals(currClient)) c.NewAnnounce("GAME OVER", 0); });
                }
                catch (FaultException<string> e)
                {
                    Console.WriteLine("exception on callback: " + e.Message + " " + e.Reason);
                }
            return res;
        }

        public void JoinGame()
        {
            players.Add(OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>());
        }

        public void ExitGame()
        {
            players.Remove(OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>());
        }
    }
}
