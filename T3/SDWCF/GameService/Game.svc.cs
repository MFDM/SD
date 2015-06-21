using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace GameService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults=true)]
    public class Game : IGamePlayer, IGameManager
    {

        private List<IGamePlayerReceiverCallback> players = new List<IGamePlayerReceiverCallback>(); 
        private Board b;
        private string adv;
        public void StartGame(int n1, int n2)
        {
            b = new Board(n1, n2);
        }

        public void EndGame()
        {
            b = null;
        }

        public void SetAdv(string adv)
        {
            this.adv = adv;
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

        public string TranslateAdv(string targetLng)
        {
            string translatedAdv, sourceLng;
            IGamePlayerReceiverCallback currClient = OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>();
            
            BasicHttpBinding bind = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://api.microsofttranslator.com/V2/soap.svc");

            ChannelFactory<MicrosoftTranslator.LanguageService> factory = new ChannelFactory<MicrosoftTranslator.LanguageService>(bind, address);
            MicrosoftTranslator.LanguageService svc = factory.CreateChannel();

            sourceLng = svc.Detect("F4E6E0444F32B660BED9908E9744594B53D2E864", adv);
            translatedAdv = svc.Translate("F4E6E0444F32B660BED9908E9744594B53D2E864", adv, sourceLng, targetLng, "text/html", "general");

            currClient.NewAdvertisement(translatedAdv, 0);

            return translatedAdv;
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
