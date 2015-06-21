using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace GameService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults=true)]
    public class Game : IGamePlayer, IGameManager
    {

        //private List<IGamePlayerReceiverCallback> players = new List<IGamePlayerReceiverCallback>(); 
        private List<PlayerInfo> _players = new List<PlayerInfo>();
        private Board b;

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
            _players.ForEach((c) => { c.Callback.NewAdvertisement(TranslateAdv(c.Language, adv), 0); });
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

                    _players.ForEach((c)=> { if (!c.Callback.Equals(currClient)) c.Callback.NewAnnounce("GAME OVER", 0); });
                }
                catch (FaultException<string> e)
                {
                    Console.WriteLine("exception on callback: " + e.Message + " " + e.Reason);
                }
            return res;
        }

        private string TranslateAdv(string targetLng, String msg)
        {
            string translatedAdv, sourceLng;
            
            BasicHttpBinding bind = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://api.microsofttranslator.com/V2/soap.svc");

            ChannelFactory<MicrosoftTranslator.LanguageService> factory = new ChannelFactory<MicrosoftTranslator.LanguageService>(bind, address);
            MicrosoftTranslator.LanguageService svc = factory.CreateChannel();

            sourceLng = svc.Detect("F4E6E0444F32B660BED9908E9744594B53D2E864", msg);
            translatedAdv = svc.Translate("F4E6E0444F32B660BED9908E9744594B53D2E864", msg, sourceLng, targetLng, "text/html", "general");

            return translatedAdv;
        }

        public void JoinGame(string name, string language)
        {
            //players.Add(OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>());
            _players.Add(new PlayerInfo(name, language, OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>()));
        }

        public void ExitGame()
        {
            //players.Remove(OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>());
            IGamePlayerReceiverCallback curr =
                OperationContext.Current.GetCallbackChannel<IGamePlayerReceiverCallback>();
            PlayerInfo aux = null;
            _players.ForEach((c) => { if (c.Callback == curr) aux = c; });
            _players.Remove(aux);
        }

        public class PlayerInfo
        {
            public string Name { get; set; }
            public string Language { get; set; }
            public IGamePlayerReceiverCallback Callback { get; set; }

            public PlayerInfo(string n, string l, IGamePlayerReceiverCallback c)
            {
                Name = n;
                Language = l;
                Callback = c;
            }
        }

    }
}
